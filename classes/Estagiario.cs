using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitos.classes
{
    class Estagiario : Employee
    {
        public Estagiario(string cpf) : base(1200, cpf)
        {
            Console.WriteLine("Criando o Estágiario");
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificao()
        {
            throw new NotImplementedException();
        }
    }
}