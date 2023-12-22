using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos_Explorando.Models
{
    
    public class Pessoa
    {
        //Construtor - caso queira receber um valor desconhecido do usuario
        public Pessoa()
        {

        }
        //Construtor - para valores ja definidos/ ja sabidos
        public Pessoa (string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;

        }
        private string _nome;
        private int _Idade;
        public string Nome 
        { 
            // Validação do NOME
            get => _nome.ToUpper();// Retornará maiusculo
        
            set
            {
                if(value =="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }

        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

        public int Idade 
        { 
            // Validação de IDADE
            get => _Idade; 

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0.");
                }
                _Idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }

    
}