using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia
{
    internal class Factura
    {
        private string tiketFactura;
        private DateTime fechaHora;
        private string prestacion;
        private Vendedor vendedor;
        private ArrayList carrito = new ArrayList();
        private int total=0;

        public Factura(string tiket, DateTime hora, Vendedor Vendedor, ArrayList list,string prestacion="Particular") 
        {
            this.tiketFactura = tiket;
            this.fechaHora = hora;
            this.prestacion = prestacion;
            this.vendedor = Vendedor;
            foreach (var item in list)
            {
                carrito.Add(item);
            }
            GeneratorImporte();
        }

        public Factura(string tiket, DateTime hora, Vendedor Vendedor, string prestacion = "Particular")
        {
            this.tiketFactura = tiket;
            this.fechaHora = hora;
            this.prestacion = prestacion;
            this.vendedor = Vendedor;
        }
        public string TiketFactura { get { return tiketFactura; } }
        public DateTime Fecha 
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }
        public Vendedor Vendedor 
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public void  AddMedicine(Medicamentos medicine) 
        {
            carrito.Add(medicine);
            GeneratorImporte();
        }
        public int ImporteTotal() => total;
        private void GeneratorImporte() 
        {
            total = 0;
            foreach (Medicamentos medicamentos in carrito) 
            {
                total += Convert.ToInt16( medicamentos.GetImporte);
            }
        }
        
    }
   

    internal class Medicamentos
    {
        private int cantidad;
        private Medicamento medicine;
        private int importe;

        public Medicamentos(int cantidad, Medicamento medicine)
        {
            this.cantidad = cantidad;
            this.medicine = medicine;
            generarImporte();
        }

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
            return "Cantidad : "+cantidad+" de "+ medicine.NombreComercial;
        }
    }
}
