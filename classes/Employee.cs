using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitos.classes
{
    public abstract class Employee
    {

        public static int QuantidadeFuncionarios { get; private set; }
        public string name { get; set; }
        public string CPF { get; private set; }
        public double _saldo { get; protected set; }

        public Employee(double saldo, string cpf)
        {
            this._saldo = saldo;
            this.CPF = cpf;

            QuantidadeFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificao();
    }
}
