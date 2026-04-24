using System;
using System.Collections.Generic;
using System.Text;

namespace Jueves.BLL
{
    public class EstudianteBLL
    {
            public string matricula { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string materia { get; set; }
            public double practica1 { get; set; }
            public double practica2 { get; set; }
            public double practicaFinal { get; set; }
            public double examen1 { get; set; }
            public double examen2 { get; set; }
            public double examenFinal { get; set; }
            public double NotaFinal { get; set; }
            public string Estado { get; set; }

            public void CalculoNotaFinal()
            {
                NotaFinal = ((practica1 + practica2 + practicaFinal) / 3) * 0.4
                                     + ((examen1 + examen2 + examenFinal) / 3) * 0.6;

                // redondeamos la nota final a 2 decimales
                NotaFinal = Math.Round(NotaFinal, 2);


            if (NotaFinal >= 70)
                {
                    Estado = "Aprobado";
                }
                else
                {
                    Estado = "Reprobado";
                }
            }



        
    }
}
