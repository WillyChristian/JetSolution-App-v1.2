using System;
using System.Collections.Generic;
using System.Text;

namespace jetSolutions.Models
{
    public class Combustivel
    {
        public string Distribuidor { get; set; }
        public string Fornecedor { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Total_Combustivel { get; set; }
        public string url { get; set; }
    }
}