using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
    public class Departamento : Inmueble
    {
        private short piso;
        private char letra;
        private bool balcon;


        public Departamento(string direccion, string localidad, DateTime antiguedad, 
            EEstado estado, /*float precio,*/ short ambientes, float tamanio, /*float deposito,*/
            bool garaje, bool pileta, bool patio, short baños, bool parrilla, string notas,short piso,char letra,bool balcon):base(direccion,localidad,antiguedad,estado/*,precio*/,ambientes,tamanio,/*deposito,*/garaje,pileta,patio,baños,parrilla,notas)
        {
            this.Piso = piso;
            this.Letra = letra;
            this.Balcon = balcon;
        }

        public override string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                //le pongo para que no mande cualquier cosa
                if(value.Length > 5 && value.Length < 200)
                {
                    this.direccion = value;
                }
            }
        }

        public override string Localidad
        {
            get
            {
                return this.localidad;
            }
            set
            {
                if (value.Length > 5 && value.Length < 200)
                {
                    this.direccion = value;
                }
            }
        }

        /*public override Inquilino EInquilino
        {
            get
            {
                return this.eInquilino;
            }
            set
            {
                this.eInquilino = value;
            }
        }*/

        public override DateTime Antiguedad
        {
            get
            {
                return this.antiguedad;
            }
            set
            {
                if(value.Date < DateTime.Today)
                {
                    this.antiguedad = value;
                }
            }
        }

        public override EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

       /* public override float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value > 0)
                {
                    this.precio = value;
                }
            }
        }*/

        public override short Ambientes
        {
            get
            {
                return this.ambientes;
            } 
            set
            {
                if(value > 0 && value < 100)
                {
                    this.ambientes = value;
                }
            }                
        }

        public override float Tamanio
        {
            get
            {
                return this.tamanio;
            }
            set
            {
                if(value > 0)
                {
                    this.tamanio = value;
                }
            }
        }

        /*public override float Deposito
        {
            get
            {
                return this.deposito;
            }
            set
            {
                if(value > 0)
                {
                    this.deposito = value;
                }
            }
        }*/

        public override bool Garaje
        {
            get
            {
                return this.garaje;
            }
            set
            {
                this.garaje = value;
            }

        }

        public override bool Pileta
        {
            get
            {
                return this.pileta;
            }
            set
            {
                this.pileta = value;
            }
        }

        public override bool Patio
        {
            get
            {
                return this.patio;
            }
            set
            {
                this.patio = value;
            }
        }

        public override short Baños
        {
            get
            {
                return this.baños;
            }
            set
            {
                if(value > 0)
                {
                    this.baños = value;
                }
            }
        }

        public override bool Parrilla
        {
            get
            {
                return this.parrilla;
            }
            set
            {
                this.parrilla = value;
            }

        }

        public override string Notas
        {
            get
            {
                return this.notas;
            }
            set
            {
                this.notas = value; 
            }

        }

        public short Piso
        {
            get
            {
                return this.piso;
            }
            set
            {
                if(value > 0 && value < 100)
                {
                    this.piso = value;
                }
            }
        }

        public char Letra
        {
            get
            {
                return this.letra;
            }
            set
            {
                this.letra = value;
            }
        }

        public bool Balcon
        {
            get
            {
                return this.balcon;
            }
            set
            {
                this.balcon = value;
            }
        }

        

        public static bool operator ==(Departamento d1, Departamento d2)
        {
            if(d1.Piso == d2.Piso && d1.Letra == d2.Letra && d1.Direccion == d2.Direccion)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Departamento d1, Departamento d2)
        {
            return !(d1 == d2);
        }
    }
}
