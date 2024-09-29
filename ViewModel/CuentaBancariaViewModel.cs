using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apppractica_2.Models;

namespace apppractica_2.ViewModel
{
    public class CuentaBancariaViewModel
    {
        public CuentaBancaria? FormCuentaBancaria { get; set; }
        public List<CuentaBancaria>? ListarCuentaBancaria { get; set; }
    }
}