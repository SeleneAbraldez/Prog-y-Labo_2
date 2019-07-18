using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        public enum TipoCompetencia{ F1, MotoCross }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores { get { return this.cantidadCompetidores;} set{ this.cantidadCompetidores = value;} }
        public short CantidadVueltas { get { return this.cantidadVueltas;} set{ this.cantidadVueltas = value; }}
        public TipoCompetencia Tipo { get { return this.tipo; } set { this.tipo = value; } }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) :this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
            
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            for(int i = 0; i < this.competidores.Count; i++)
            {
                datos.Append(this.competidores[i].mostrarDatos());
            }

            return datos.ToString();
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if (c.competidores.Contains(a))
            {
                retorno = true;
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                c.competidores.Remove(a);
            }

            return retorno;

        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            Random cantidadCombustible = new Random();
            switch (c.Tipo)
            {
                case TipoCompetencia.F1:
                    try
                    {
                        if (c.competidores.Count < c.CantidadCompetidores && c != a)
                        {
                            //if(a.GetType() == typeof(MotoCross))
                            if (a is AutoF1)
                            {
                                retorno = true;
                                a.EnCompetencia = true;
                                a.VueltasRestantes = c.CantidadVueltas;
                                a.CantidadCombustible = (short)cantidadCombustible.Next(15, 100);
                                c.competidores.Add(a);
                            }
                        }
                    }
                    catch (CompetenciaNoDisponibleException e)
                    {
                        throw new CompetenciaNoDisponibleException("Competencia Incorrecta", c.GetType().Name, "Operator +",e);
                    }
                    break;

                case TipoCompetencia.MotoCross:
                    try
                    {
                        if (c.competidores.Count < c.CantidadCompetidores && c != a)
                        {
                            //if(a.GetType() == typeof(MotoCross))
                            if (a is MotoCross)
                            {
                                retorno = true;
                                a.EnCompetencia = true;
                                a.VueltasRestantes = c.CantidadVueltas;
                                a.CantidadCombustible = (short)cantidadCombustible.Next(15, 100);
                                c.competidores.Add(a);
                            }
                        }
                    }
                    catch (CompetenciaNoDisponibleException e)
                    {
                        throw new CompetenciaNoDisponibleException("Competencia Incorrecta", c.GetType().Name, "Operator +",e);
                    }

                    break;
            }           

            return retorno;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            foreach (VehiculoDeCarrera auto in c.competidores)
            {
                if(auto == a)
                {
                    retorno = true;
                    break;
                }
            }
            if (retorno == false)
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia.", c.GetType().Name, "Operator ==");

            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }



    }
}
