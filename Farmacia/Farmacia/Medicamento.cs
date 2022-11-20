using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia
{
    /// ******************************
    ///     CLASE MEDICAMENTO  
    /// ******************************
    internal class Medicamento
    {
        // Atributos de la clase (privadas)
        private int codigo;
        private int precio;
        private string nombreComercial;
        private string droga;
        private string nombreLaboratorio;
        private string presentacion;

        //CONSTRUCTOR

        public Medicamento(int Codigo, string nameMedicine, int amount, string Droga, string Presentacion = "Capsulas", string NameLab = "Sin Definir")
        {
            codigo = Codigo;
            nombreComercial = nameMedicine;
            precio = amount;
            droga = Droga;
            presentacion = Presentacion;
            nombreLaboratorio = NameLab;
        }
        // METODOS DE GET y SET

        public int Precio 
        {
            get { return precio; }
            set { precio = value; }
        }
        public string NombreComercial 
        {
            get { return nombreComercial; }
            set { nombreComercial = value; }
        }
        public string NombreLaboratorio
        {
            get { return nombreLaboratorio; }
            set { nombreLaboratorio = value; }
        }
        public string Droga 
        {
            get { return droga; }
            set { droga = value; }
        }
        //DE SOLO LECTURA 
        public int Codigo { get { return codigo; } }
        public string Presentacion { get { return presentacion; } }

        // SOBREESCRIBIENDO TO STRING
        public override string ToString()
        {
            return "Medicamento ["+ nombreComercial +", droga:  "+droga+", presentacion: "+presentacion+", laboratorio: "+nombreLaboratorio+"] PRECIO: $"+precio+" pesos";
        }
    }

    /// *****************************************************************************
    ///     CLASE MEDICAMENTOS QUE GUARDA VARIAS CANTIDADES DE MEDICAMENTOS
    /// *****************************************************************************
    internal class Medicamentos
    {
        // Atributos de la clase (privadas)
        private int cantidad;
        private Medicamento medicine;
        private int importe;

        //CONSTRUCTOR

        public Medicamentos(int cantidad, Medicamento medicine)
        {
            this.cantidad = cantidad;
            this.medicine = medicine;
            generarImporte();
        }
        // SOLO  LECTURA
        public int Cantidad { get { return cantidad; } }
        public Medicamento Medicine { get { return medicine; } }

        public void Add()
        {
            cantidad++;
            generarImporte();
        }
        public void Add(int cant)
        {
            cantidad += cant;
            generarImporte();
        }

        public void Delete()
        {
            if (cantidad > 0)
            {
                cantidad--;
                generarImporte();
            }
            else Console.WriteLine("No queda ningun elemento para quitar");
        }
        public void Delete(int cant)
        {
            cantidad -= cant;
            generarImporte();
        }
        public void AllDelete()
        {
            cantidad = 0;
            generarImporte();
        }

        private void generarImporte() => importe = cantidad * medicine.Precio;

        public int GetImporte() => importe;

        public override string ToString()
        {
            return "Cantidad : " + cantidad + " de " + medicine.NombreComercial;
        }
    }
}
