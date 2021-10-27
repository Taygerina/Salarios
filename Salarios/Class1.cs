using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace Salario
    {
        class funcionarios
        {
            //Variaveis da classe
            public string Nome { get; set; }
            public double Salario { get; set; }
            public int Id { get; set; }

            //contrutor 
            public funcionarios(string nome, double salario, int id)
            {
                Nome = nome;
                Salario = salario;
                Id = id;
            }
            //formatação de salarios em listas
            public override string ToString()
            {
                return Id + " , " + Nome + " , " + Salario;
            }
            //Função para o aumento do salario
            public void AumentarSalario(double porcentagem)
            {
                Salario = Salario * porcentagem / 100;
            }
        }
    }


