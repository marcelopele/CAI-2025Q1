using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public class ReporteAlu1
    {
        //Atributos
        String _carrera;
        int _cantMatAprobadas;
        int _cantMatPendientes;
        double _porcentajePendiente;

        //Propiedades
        public string Carrera { get => _carrera; set => _carrera = value; }
        public int CantMatAprobadas { get => _cantMatAprobadas; set => _cantMatAprobadas = value; }
        public int CantMatPendientes { get => _cantMatPendientes; set => _cantMatPendientes = value; }
        public double PorcentajePendiente { get => _porcentajePendiente; set => _porcentajePendiente = value; }

        //Constructor
        public ReporteAlu1(String carrera, int qT, int qA)
        {
            int qP= qT-qA;
            double pP = ((double)qP / (double)qT) * 100;
            this.Carrera = carrera;
            this.CantMatAprobadas = qA;
            this.CantMatPendientes = qT - qA;
            this.PorcentajePendiente = Math.Round(pP,2);
        }

    }
}
