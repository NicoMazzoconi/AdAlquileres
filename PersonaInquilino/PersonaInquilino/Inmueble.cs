using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
    public enum EEstado
    {
        libre,
        alquilado,
        en_venta

    }

    public abstract class Inmueble
    {
        protected string direccion;
        protected string localidad;
        protected Inquilino eInquilino;
        protected DateTime antiguedad;
        protected EEstado estado;
        protected float precio;
        //private int id;
        protected short ambientes;
        protected float tamanio;
        protected float deposito;
        protected bool garaje;
        protected bool pileta;
        protected bool patio;
        protected short baños;
        protected bool parrilla;
        protected string notas;

        public Inmueble(string direccion,string localidad, Inquilino inquilino, DateTime antiguedad, EEstado estado, float precio/*,int id*/,short ambientes,float tamanio, float deposito, bool garaje, bool pileta, bool patio,short baños,bool parrilla,string notas )
        {
            this.direccion = direccion;
            this.localidad = localidad;
            this.eInquilino = inquilino;
            this.antiguedad = antiguedad;
            this.estado = estado;
            this.precio = precio;
            //this.id = id;
            this.ambientes = ambientes;
            this.tamanio = tamanio;
            this.deposito = deposito;
            this.garaje = garaje;
            this.pileta = pileta;
            this.patio = patio;
            this.baños = baños;
            this.parrilla = parrilla;
            this.notas = notas;

        }

        public abstract string Notas
        {
            get;
            set;
        }

        public abstract bool Parrilla
        {
            get;
            set;
        }

        public abstract short Baños
        {
            get;
            set;
        }

        public abstract bool Pileta
        {
            get;
            set;
        }

        public abstract bool Patio
        {
            get;
            set;
        }
        public abstract string Direccion
        {
            get;
            set;
        }

        public abstract string Localidad
        {
            get;
            set;
        }

        public abstract Inquilino EInquilino
        {
            get;
            set;
        }

        public abstract DateTime Antiguedad
        {
            get;
            set;
        }

        public abstract EEstado Estado
        {
            get;
            set;
        }

        public abstract float Precio
        {
            get;
            set;
        }

      

        public abstract short Ambientes
        {
            get;
            set;
        }

        public abstract float Tamanio
        {
            get;
            set;
        }

        public abstract float Deposito
        {
            get;
            set;
        }

        public abstract bool Garaje
        {
            get;
            set;
        }
    }
}
