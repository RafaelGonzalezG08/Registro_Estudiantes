namespace Jueves
{
    partial class frmEstudiante
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiante));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnCrear = new Button();
            label1 = new Label();
            txtMatricula = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            cbbMateria = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txt1raPractica = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt2daPractica = new TextBox();
            txtPracticaFinal = new TextBox();
            txt1erExamen = new TextBox();
            txt2doExamen = new TextBox();
            txtExamenFinal = new TextBox();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvRegistroEstudiantil = new DataGridView();
            label12 = new Label();
            label13 = new Label();
            txtNotaFinal = new TextBox();
            txtEstado = new TextBox();
            btnLimpiar = new Button();
            pnMensajeEstado = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEstudiantil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnMensajeEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.None;
            btnCrear.BackColor = Color.Transparent;
            btnCrear.BackgroundImage = (Image)resources.GetObject("btnCrear.BackgroundImage");
            btnCrear.BackgroundImageLayout = ImageLayout.Zoom;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderColor = Color.FromArgb(36, 174, 96);
            btnCrear.FlatAppearance.BorderSize = 2;
            btnCrear.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCrear.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            btnCrear.ForeColor = Color.FromArgb(39, 174, 96);
            btnCrear.ImageAlign = ContentAlignment.BottomLeft;
            btnCrear.Location = new Point(33, 144);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(189, 116);
            btnCrear.TabIndex = 0;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.IBeam;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 242);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 1;
            label1.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.None;
            txtMatricula.BackColor = SystemColors.ControlDarkDark;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txtMatricula.ForeColor = Color.White;
            txtMatricula.Location = new Point(294, 268);
            txtMatricula.MaxLength = 9;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(280, 27);
            txtMatricula.TabIndex = 2;
            txtMatricula.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(629, 242);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BackColor = SystemColors.ControlDarkDark;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(629, 268);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 5;
            txtNombre.KeyPress += txtSoloLetras_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.BackColor = SystemColors.ControlDarkDark;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(966, 268);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(280, 27);
            txtApellido.TabIndex = 6;
            txtApellido.KeyPress += txtSoloLetras_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.IBeam;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(965, 242);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 7;
            label4.Text = "Apellido:";
            // 
            // cbbMateria
            // 
            cbbMateria.AccessibleRole = AccessibleRole.DropList;
            cbbMateria.Anchor = AnchorStyles.None;
            cbbMateria.BackColor = SystemColors.ControlDarkDark;
            cbbMateria.Cursor = Cursors.Hand;
            cbbMateria.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            cbbMateria.ForeColor = Color.White;
            cbbMateria.FormattingEnabled = true;
            cbbMateria.ImeMode = ImeMode.Off;
            cbbMateria.Items.AddRange(new object[] { "Análisis Lineal Y Matricial (MAT2330)", "Lab de Lenguaje de Programac I (INF5130)", "Lenguaje de Programación I (INF5120)", "Matemática Financiera (MAT1430)", "Sistemas Operativos (INF3240)" });
            cbbMateria.Location = new Point(295, 346);
            cbbMateria.Margin = new Padding(0);
            cbbMateria.Name = "cbbMateria";
            cbbMateria.Size = new Size(951, 28);
            cbbMateria.TabIndex = 8;
            cbbMateria.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.IBeam;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(294, 325);
            label5.Name = "label5";
            label5.Size = new Size(175, 18);
            label5.TabIndex = 9;
            label5.Text = "Seleccione la Materia:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(303, 437);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 10;
            label6.Text = "1ʳᵃ Practica:";
            // 
            // txt1raPractica
            // 
            txt1raPractica.Anchor = AnchorStyles.None;
            txt1raPractica.BackColor = SystemColors.ControlDarkDark;
            txt1raPractica.BorderStyle = BorderStyle.FixedSingle;
            txt1raPractica.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txt1raPractica.ForeColor = Color.White;
            txt1raPractica.Location = new Point(422, 435);
            txt1raPractica.Name = "txt1raPractica";
            txt1raPractica.Size = new Size(90, 27);
            txt1raPractica.TabIndex = 11;
            txt1raPractica.KeyPress += txtSoloNumeros_KeyPress;
            txt1raPractica.Leave += NotaPermitida_leave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.IBeam;
            label7.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(303, 507);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 12;
            label7.Text = "2da Practica:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(303, 577);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 13;
            label8.Text = "Practica final:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Cursor = Cursors.IBeam;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(663, 437);
            label9.Name = "label9";
            label9.Size = new Size(102, 18);
            label9.TabIndex = 14;
            label9.Text = "1er Examen:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Cursor = Cursors.IBeam;
            label10.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(663, 507);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 15;
            label10.Text = "2do Examen:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Cursor = Cursors.IBeam;
            label11.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(663, 577);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 16;
            label11.Text = "3er Examen:";
            // 
            // txt2daPractica
            // 
            txt2daPractica.Anchor = AnchorStyles.None;
            txt2daPractica.BackColor = SystemColors.ControlDarkDark;
            txt2daPractica.BorderStyle = BorderStyle.FixedSingle;
            txt2daPractica.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txt2daPractica.ForeColor = Color.White;
            txt2daPractica.Location = new Point(422, 505);
            txt2daPractica.Name = "txt2daPractica";
            txt2daPractica.Size = new Size(90, 27);
            txt2daPractica.TabIndex = 17;
            txt2daPractica.KeyPress += txtSoloNumeros_KeyPress;
            txt2daPractica.Leave += NotaPermitida_leave;
            // 
            // txtPracticaFinal
            // 
            txtPracticaFinal.Anchor = AnchorStyles.None;
            txtPracticaFinal.BackColor = SystemColors.ControlDarkDark;
            txtPracticaFinal.BorderStyle = BorderStyle.FixedSingle;
            txtPracticaFinal.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txtPracticaFinal.ForeColor = Color.White;
            txtPracticaFinal.Location = new Point(422, 574);
            txtPracticaFinal.Name = "txtPracticaFinal";
            txtPracticaFinal.Size = new Size(90, 27);
            txtPracticaFinal.TabIndex = 18;
            txtPracticaFinal.KeyPress += txtSoloNumeros_KeyPress;
            txtPracticaFinal.Leave += NotaPermitida_leave;
            // 
            // txt1erExamen
            // 
            txt1erExamen.Anchor = AnchorStyles.None;
            txt1erExamen.BackColor = SystemColors.ControlDarkDark;
            txt1erExamen.BorderStyle = BorderStyle.FixedSingle;
            txt1erExamen.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txt1erExamen.ForeColor = Color.White;
            txt1erExamen.Location = new Point(787, 435);
            txt1erExamen.Name = "txt1erExamen";
            txt1erExamen.Size = new Size(89, 27);
            txt1erExamen.TabIndex = 19;
            txt1erExamen.KeyPress += txtSoloNumeros_KeyPress;
            txt1erExamen.Leave += NotaPermitida_leave;
            // 
            // txt2doExamen
            // 
            txt2doExamen.Anchor = AnchorStyles.None;
            txt2doExamen.BackColor = SystemColors.ControlDarkDark;
            txt2doExamen.BorderStyle = BorderStyle.FixedSingle;
            txt2doExamen.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txt2doExamen.ForeColor = Color.White;
            txt2doExamen.Location = new Point(786, 505);
            txt2doExamen.Name = "txt2doExamen";
            txt2doExamen.Size = new Size(90, 27);
            txt2doExamen.TabIndex = 20;
            txt2doExamen.KeyPress += txtSoloNumeros_KeyPress;
            txt2doExamen.Leave += NotaPermitida_leave;
            // 
            // txtExamenFinal
            // 
            txtExamenFinal.Anchor = AnchorStyles.None;
            txtExamenFinal.BackColor = SystemColors.ControlDarkDark;
            txtExamenFinal.BorderStyle = BorderStyle.FixedSingle;
            txtExamenFinal.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            txtExamenFinal.ForeColor = Color.White;
            txtExamenFinal.Location = new Point(786, 575);
            txtExamenFinal.Name = "txtExamenFinal";
            txtExamenFinal.Size = new Size(89, 27);
            txtExamenFinal.TabIndex = 21;
            txtExamenFinal.KeyPress += txtSoloNumeros_KeyPress;
            txtExamenFinal.Leave += NotaPermitida_leave;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.None;
            btnConsultar.BackColor = Color.Transparent;
            btnConsultar.BackgroundImage = (Image)resources.GetObject("btnConsultar.BackgroundImage");
            btnConsultar.BackgroundImageLayout = ImageLayout.Zoom;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnConsultar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.FromArgb(52, 152, 219);
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(33, 266);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(189, 115);
            btnConsultar.TabIndex = 22;
            btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.BackgroundImageLayout = ImageLayout.Zoom;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(243, 156, 18);
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            btnModificar.ForeColor = Color.FromArgb(243, 156, 18);
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(33, 387);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(189, 116);
            btnModificar.TabIndex = 23;
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.FromArgb(192, 57, 43);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(33, 509);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(189, 116);
            btnEliminar.TabIndex = 24;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvRegistroEstudiantil
            // 
            dgvRegistroEstudiantil.AllowUserToAddRows = false;
            dgvRegistroEstudiantil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvRegistroEstudiantil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistroEstudiantil.Anchor = AnchorStyles.None;
            dgvRegistroEstudiantil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroEstudiantil.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRegistroEstudiantil.BackgroundColor = Color.Gray;
            dgvRegistroEstudiantil.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRegistroEstudiantil.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistroEstudiantil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistroEstudiantil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroEstudiantil.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistroEstudiantil.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistroEstudiantil.GridColor = Color.DimGray;
            dgvRegistroEstudiantil.Location = new Point(14, 658);
            dgvRegistroEstudiantil.Name = "dgvRegistroEstudiantil";
            dgvRegistroEstudiantil.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRegistroEstudiantil.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRegistroEstudiantil.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Gray;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvRegistroEstudiantil.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRegistroEstudiantil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistroEstudiantil.Size = new Size(1669, 294);
            dgvRegistroEstudiantil.TabIndex = 25;
            dgvRegistroEstudiantil.CellMouseClick += Seleccionar;
            dgvRegistroEstudiantil.CellMouseEnter += dgvRegistroEstudiantil_CellMouseEnter;
            dgvRegistroEstudiantil.CellMouseLeave += dgvRegistroEstudiantil_CellMouseLeave;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Cursor = Cursors.IBeam;
            label12.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1115, 420);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 26;
            label12.Text = "Nota Final:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Cursor = Cursors.IBeam;
            label13.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1125, 535);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 27;
            label13.Text = "Estado:";
            // 
            // txtNotaFinal
            // 
            txtNotaFinal.Anchor = AnchorStyles.None;
            txtNotaFinal.BackColor = SystemColors.ControlDarkDark;
            txtNotaFinal.BorderStyle = BorderStyle.None;
            txtNotaFinal.Cursor = Cursors.IBeam;
            txtNotaFinal.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNotaFinal.ForeColor = Color.FromArgb(0, 210, 255);
            txtNotaFinal.Location = new Point(1083, 455);
            txtNotaFinal.Name = "txtNotaFinal";
            txtNotaFinal.ReadOnly = true;
            txtNotaFinal.Size = new Size(158, 36);
            txtNotaFinal.TabIndex = 28;
            txtNotaFinal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.None;
            txtEstado.BackColor = SystemColors.ControlDarkDark;
            txtEstado.BorderStyle = BorderStyle.FixedSingle;
            txtEstado.Cursor = Cursors.IBeam;
            txtEstado.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEstado.ForeColor = Color.White;
            txtEstado.Location = new Point(1083, 569);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(157, 35);
            txtEstado.TabIndex = 29;
            txtEstado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.White;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1263, 128);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(172, 132);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = " ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnMensajeEstado
            // 
            pnMensajeEstado.Anchor = AnchorStyles.None;
            pnMensajeEstado.BackColor = Color.Transparent;
            pnMensajeEstado.BackgroundImageLayout = ImageLayout.Zoom;
            pnMensajeEstado.Location = new Point(1263, 272);
            pnMensajeEstado.Name = "pnMensajeEstado";
            pnMensajeEstado.Size = new Size(380, 380);
            pnMensajeEstado.SizeMode = PictureBoxSizeMode.CenterImage;
            pnMensajeEstado.TabIndex = 36;
            pnMensajeEstado.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(663, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 144);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(491, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(683, 55);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // frmEstudiante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1696, 976);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbbMateria);
            Controls.Add(pnMensajeEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(txtEstado);
            Controls.Add(txtNotaFinal);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dgvRegistroEstudiantil);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(txtExamenFinal);
            Controls.Add(txt2doExamen);
            Controls.Add(txt1erExamen);
            Controls.Add(txtPracticaFinal);
            Controls.Add(txt2daPractica);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt1raPractica);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1712, 1015);
            Name = "frmEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administardor de Registro Estudiantil";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEstudiantil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnMensajeEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Button btnCrear;
        protected Label label1;
        public TextBox txtMatricula;
        protected Label label3;
        protected TextBox txtNombre;
        protected TextBox txtApellido;
        protected Label label4;
        protected ComboBox cbbMateria;
        protected Label label5;
        protected Label label6;
        protected TextBox txt1raPractica;
        protected Label label7;
        protected Label label8;
        protected Label label9;
        protected Label label10;
        protected Label label11;
        protected TextBox txt2daPractica;
        protected TextBox txtPracticaFinal;
        protected TextBox txt1erExamen;
        protected TextBox txt2doExamen;
        protected TextBox txtExamenFinal;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvRegistroEstudiantil;
        protected Label label12;
        protected Label label13;
        protected TextBox txtNotaFinal;
        protected TextBox txtEstado;
        protected Button btnLimpiar;
        private PictureBox pnMensajeEstado;
        private BotonRedondeado botonRedondeado1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
