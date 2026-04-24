
using Jueves.BLL;
using Jueves.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using static Jueves.DAL.absEstudianteDAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Jueves

{


    public partial class frmEstudiante : Form
    {
        //inicializamos las variables para las imagenes de felicitaciones y suerte
        private Image imagenFelicitaciones;
        private Image imagenSuerte;


        ConexionDAL conexion = new ConexionDAL();
        AgregarCL objAgregar;
        ConsultarCL objConsultar;
        EstudianteBLL objestudiante = new EstudianteBLL();


        public frmEstudiante()
        {
            InitializeComponent();


            // Cargamos las imágenes desde la ruta especificada
            imagenFelicitaciones = Image.FromFile("C:/Users/ykaru/Downloads/Felicitaciones (3).png");
            imagenSuerte = Image.FromFile("C:/Users/ykaru/Downloads/Suerte (4).png");



            // hacemos que el cambio de la iamgen no sea tan brusco
            this.DoubleBuffered = true;


            objAgregar = new AgregarCL(conexion);
            objConsultar = new ConsultarCL(conexion);
            llegarGrid();
            LimpiarFormulario();


            // definimos el diseño del DataGridView
            dgvRegistroEstudiantil.EnableHeadersVisualStyles = false;

        }



        // Boton para agrear un registro
        private void btnCrear_Click(object sender, EventArgs e)
        {
            // haciendo uso del polimorfismo
            EjecutarAccion(new AgregarCL(conexion));
        }





        /* Consultamos un estudiante por su matricula
        No usamos polimorfismo por tema de incompatibilidad por los requerimientos de "EjecutarAccion"
        que necesita campos obligatorios para agregar o modificar un estudiante, y en este caso solo se necesita la matricula */
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objestudiante.matricula = txtMatricula.Text;
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Ingrese la matrícula para consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return;
            }

            DataSet ds = objConsultar.ConsultarEstudiante(objestudiante);
            if (ds?.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Si hay datos, los pasamos a los TextBox
                DataRow fila = ds.Tables[0].Rows[0];
                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                cbbMateria.Text = fila["Materia"].ToString();
                txtNotaFinal.Text = fila["Nota Final"].ToString();
                txtEstado.Text = fila["Estado"].ToString();
                txt1erExamen.Text = fila["Examen 1"].ToString();
                txt2doExamen.Text = fila["Examen 2"].ToString();
                txtExamenFinal.Text = fila["Examen Final"].ToString();
                txt1raPractica.Text = fila["Practica 1"].ToString();
                txt2daPractica.Text = fila["Practica 2"].ToString();
                txtPracticaFinal.Text = fila["Practica Final"].ToString();

                if (double.Parse(txtNotaFinal.Text) > 70)
                {
                    txtEstado.BackColor = Color.FromArgb(46, 204, 113); // Verde
                    pnMensajeEstado.Image = imagenFelicitaciones;
                    pnMensajeEstado.Visible = true;
                } else
                {
                    txtEstado.BackColor = Color.FromArgb(231, 76, 60); // Rojo
                    pnMensajeEstado.Image = imagenSuerte;
                    pnMensajeEstado.Visible = true;
                }


            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
            }



        }



        // Boton para modificar un registro
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // haciendo uso del polimorfismo
            EjecutarAccion(new ModificarCL(conexion));
        }



        // Boton para eliminar un registro
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Mostramos un mensaje de confirmación antes de eliminar el registro
            var result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // haciendo uso del polimorfismo
                EjecutarAccion(new EliminarCL(conexion));
            }
        }



        // Boton para limpiar los campos del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }



        //limpiamos los campos del formulario
        private void LimpiarFormulario()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cbbMateria.SelectedIndex = -1;
            txt1raPractica.Clear();
            txt2daPractica.Clear();
            txtPracticaFinal.Clear();
            txt1erExamen.Clear();
            txt2doExamen.Clear();
            txtExamenFinal.Clear();
            txtEstado.Clear();
            txtEstado.BackColor = Color.FromArgb(105, 105, 105);
            pnMensajeEstado.Visible = false;
            txtNotaFinal.Clear();
        }



        // Metodo para seleccionar un estudiante del DataGridView y mostrar sus datos en los TextBox correspondientes
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice < 0 || dgvRegistroEstudiantil.Rows == null || dgvRegistroEstudiantil.Rows == null || indice >= dgvRegistroEstudiantil.Rows.Count)
                return;

            var row = dgvRegistroEstudiantil.Rows[indice];

            if (row.Cells.Count > 0)
                txtMatricula.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 1)
                txtNombre.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 2)
                txtApellido.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 3)
                cbbMateria.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 4)
                txt1raPractica.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 5)
                txt2daPractica.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 6)
                txtPracticaFinal.Text = row.Cells[6].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 7)
                txt1erExamen.Text = row.Cells[7].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 8)
                txt2doExamen.Text = row.Cells[8].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 9)
                txtExamenFinal.Text = row.Cells[9].Value?.ToString() ?? string.Empty;
            if (row.Cells.Count > 10)
                txtNotaFinal.Text = row.Cells[10].Value?.ToString() ?? string.Empty;

            if (row.Cells.Count > 11)
            {
                txtEstado.Text = row.Cells[11].Value?.ToString() ?? string.Empty;
                this.SuspendLayout();
                if (txtEstado.Text == "Aprobado")
                {
                    txtEstado.BackColor = Color.FromArgb(46, 204, 113); // Verde
                    pnMensajeEstado.Image = imagenFelicitaciones;
                    pnMensajeEstado.Visible = true;
                }
                else if (txtEstado.Text == "Reprobado")
                {
                    txtEstado.BackColor = Color.FromArgb(231, 76, 60); // Rojo
                    pnMensajeEstado.Image = imagenSuerte;
                    pnMensajeEstado.Visible = true;
                }
                this.ResumeLayout();
            }
        }



        // capturamos los datos de los txtbox y los arignamos al objeto "estudiante"
        public EstudianteBLL CapturarDatos(EstudianteBLL estudiante)
        {
            estudiante.matricula = txtMatricula.Text;
            estudiante.nombre = txtNombre.Text;
            estudiante.apellido = txtApellido.Text;
            estudiante.materia = cbbMateria.Text;
            estudiante.practica1 = double.TryParse(txt1raPractica.Text, out double practica1) ? practica1 : 0;
            estudiante.practica2 = double.TryParse(txt2daPractica.Text, out double practica2) ? practica2 : 0;
            estudiante.practicaFinal = double.TryParse(txtPracticaFinal.Text, out double practicaFinal) ? practicaFinal : 0;
            estudiante.examen1 = double.TryParse(txt1erExamen.Text, out double examen1) ? examen1 : 0;
            estudiante.examen2 = double.TryParse(txt2doExamen.Text, out double examen2) ? examen2 : 0;
            estudiante.examenFinal = double.TryParse(txtExamenFinal.Text, out double examenFinal) ? examenFinal : 0;

            return estudiante;
        }



        // validamos que solo se puedan ingresar letras en los campos de nombre y apellido
        public void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite letras y la tecla de borrar o enter
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        // validamos que solo se puedan ingresar numeros en los campos de notas
        public void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y la tecla de borrar o enter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }



        // validamos que las notas ingresadas estén entre 50 y 100, si no es así, se muestra un mensaje de error y se borra el campo
        private void NotaPermitida_leave(object sender, EventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (double.TryParse(texto.Text, out double nota) && (nota < 50 || nota > 100))
            {
                MessageBox.Show("nota invalida debe estar en 50 y 100");
                texto.Clear();
                texto.Focus();

            }
        }



        // hacemos un metodo para ejecutar la acción de agregar, modificar o eliminar un estudiante 
        // A partir de este metodo podemos tener el polimoprfismo
        private void EjecutarAccion(absEstudianteDAL estudiante)
        {
            if (!ValidarCamposNulos()) return;

            CapturarDatos(objestudiante);

            objestudiante.CalculoNotaFinal();

            if (estudiante.operacion(objestudiante))
            {
                llegarGrid();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al realizar la operación.");
            }
        }



        // Nos aseguramos de que los campos obligatorios no estén vacíos antes de realizar cualquier operación
        public bool ValidarCamposNulos(bool soloMatricula = false)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Falta la Matricula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return false;
            }

            if (txtMatricula.Text.Length != 9)

            {
                MessageBox.Show("La Matricula debe tener exactamente 9 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Introduzca el nombre del estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Introduzca el apellido del estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbbMateria.Text))
            {
                MessageBox.Show("Seleccione la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMateria.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt1raPractica.Text))
            {
                MessageBox.Show("Falta la nota de la 1ra practica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt1raPractica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt2daPractica.Text))
            {
                MessageBox.Show("Falta la nota de la 2da practica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt2daPractica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPracticaFinal.Text))
            {
                MessageBox.Show("Falta la nota de la practica final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPracticaFinal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt1erExamen.Text))
            {
                MessageBox.Show("Falta la nota del 1er examen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt1erExamen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt2doExamen.Text))
            {
                MessageBox.Show("Falta la nota del 2do examen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt2doExamen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExamenFinal.Text))
            {
                MessageBox.Show("Falta la nota del examen final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamenFinal.Focus();
                return false;
            }

            return true;
        }

        

        // Metodo para llenar el DataGridView con los datos de la base de datos
        public void llegarGrid()
        {
            MostrarResultadoDAL objMostrar = new MostrarResultadoDAL();
            DataSet ds = objMostrar.ObtenerEstudiantes();
            if (ds?.Tables.Count > 0)
            {
                dgvRegistroEstudiantil.DataSource = ds.Tables[0];

            }

        }


        // Cambiamos el color de fondo y el color de letra de la fila del DataGridView al pasar el mouse por encima
        private void dgvRegistroEstudiantil_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvRegistroEstudiantil.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                dgvRegistroEstudiantil.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Empty;

                // Forzamos el repintado para que el cambio sea instantáneo
                dgvRegistroEstudiantil.InvalidateRow(e.RowIndex);
            }
        }


        // y volvemos a los colores originales al salir
        private void dgvRegistroEstudiantil_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvRegistroEstudiantil.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
                dgvRegistroEstudiantil.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }


    }




}
