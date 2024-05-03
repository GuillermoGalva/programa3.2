

namespace programa3._2.Class
{
    using System;

    class PromedioAlumno
    {
        public static bool EsPromocionado(double nota1, double nota2, double nota3)
        {
            double promedio = (nota1 + nota2 + nota3) / 3.0;
            return promedio >= 7.0;
        }
    }
}
