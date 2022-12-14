using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia
{
    internal class Farmacia
    {
        private string nombre;
        private ArrayList ventas;
        private ArrayList stockMedicamentos;
        private ArrayList empleados;

        public Farmacia(string nombre) 
        {
            this.nombre = nombre;
            this.ventas = new ArrayList();
            this.stockMedicamentos = new ArrayList();
            this.empleados = new ArrayList();
        }
        
        public int ToFindStok(int CodMedicine) 
        {
            int i = 0;
            foreach (Stock item in stockMedicamentos) 
            {
                if (item.Medicine.Codigo == CodMedicine) 
                {
                    return i; 
                }
                i++;
            }
            return -1;
        }
        public int ToFindVenta(string tiket)
        {
            int i = 0;
            foreach (Factura item in ventas)
            {
                if (item.TiketFactura == tiket)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public int ToFindEmpleado(int documento)
        {
            int i = 0;
            foreach (Employed item in ventas)
            {
                if (item.DNI == documento)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public void AddStok(Medicamento medicine, int cantidad) 
        {
            
        }

        private void Default() 
        {
            nombre = "Farmacia";
            var vendedorUno = new Vendedor(1234567, 40548231, "Torres", "Oscar", 90000);
            var vendedorDos = new Vendedor(1234568, 35949556, "Roman", "Roberto", 91000);
            var farmaceutico = new Farmaceutico( 35518211, "Aguirre", "Marcela", 12000);
            var mantenimiento = new Mantenimiento("Limpieza", 20777189, "Delolla", "Rosa", 600000);

            var ibu = new Medicamento(5554131, "Ibuprofeno 500mg", 500, "antiinflamatoria no esteroide (AINE)");
            var paracetamol = new Medicamento(8944533, "Ibuprofeno 500mg", 520, "acetaminofeno");
            var cloracepam = new Medicamento(1234533, "Clonex", 6200, "benzodiacepinas", "Gotero");
            var planB = new Medicamento(5554478, "Plan B One-Step", 1000, "levonorgestrel 0,75 mg", "Comprimido");
            var redusterol = new Medicamento(3564978, "redusterol", 1562, "Simvastatina", "Comprimido");
            var acovil = new Medicamento(99912978, "acovil", 2247, "ramipril", "Comprimido");

            var stokIbu = new Stock(ibu, 50);
            var stokParacetamol = new Stock(paracetamol, 60);
            var stokCloracepam = new Stock(cloracepam, 30);
            var stokPlanB = new Stock(planB, 20);
            var stokRedusterol = new Stock(redusterol, 10);
            var stokAcovil = new Stock(acovil, 2);

            var medicamentos = new Medicamentos(2,ibu);
            var medicamentosDos = new Medicamentos(5, planB);


        }

    }
}
