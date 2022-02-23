using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitos.aula
{
    public class Garrafa
    {
        private int Total = 0;
        // Encapsulamento 
        public int  Altura {get;set;}
        public int Largura {get;set;}
        public int Capacidade {get;set;}   

        public void Abrir(){}
        public void Fechar(){}  


        private void Encher(){
            while(Total < Capacidade) {
                Total++;
            }
        }

        public virtual void Finalidade() {
            System.Console.WriteLine("Garrafa Genérica");
        }
    }


    public class GarrafaTermica : Garrafa {
        public override void Finalidade(){
            System.Console.WriteLine("Manter Temperatura");
        }
    }

    public class GarrafaVidro : Garrafa {
        public override void Finalidade(){
            System.Console.WriteLine("Manter Sabor");
        }
    }

    public class Barril : Garrafa {
        public override void Finalidade(){
            System.Console.WriteLine("Armazenar grandes quantidades");
        }
    }


}