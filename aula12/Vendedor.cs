using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula12
{
    public class Vendedor : Funcionario
    {
        public string Regiao { get; set; }
        public double Calcular(int comissao)
        {
            return Salario * comissao / 100;
        }
    }
}
