using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Operaciones
    {
        // Precios de los procedimientos
        public float cLimpieza = 15000;
        public float cCalzas = 25000;
        public float cExtraccion = 10000;
        public float cBlanqueamiento = 35000;
        public float cOrtodoncia = 355000;

        // Tasa de IVA
        public float iva = 0.13f;  // 13% de IVA

        // Método para calcular el costo total del procedimiento, IVA y adelanto
        public float CalcularCostoTotal(int procedimiento)
        {
            float costo = 0;

            // Asignar el costo según el procedimiento
            switch (procedimiento)
            {
                case 0: costo = cLimpieza; break;
                case 1: costo = cCalzas; break;
                case 2: costo = cExtraccion; break;
                case 3: costo = cBlanqueamiento; break;
                case 4: costo = cOrtodoncia; break;
                default: costo = 0; break;
            }

            // Calcular IVA y monto total
            float ivaCalculado = costo * iva;
            float totalConIva = costo + ivaCalculado;
            return totalConIva;
        }

        // Método para calcular el adelanto (42% del total con IVA)
        public float CalcularAdelanto(float totalConIva)
        {
            return totalConIva * 0.42f;
        }
    }
}

