using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    // Classe Elevador
    internal class Elevador
    {
        // Variáveis da classe
        public int andar { get; set;}
        public int numeroAndares { get; set; }
        public int capacidadeMaxima { get; set; }
        public int numeroPessoas { get; set; }

        // Construtor
        public Elevador() {
            andar = 0; // Térreo
            numeroAndares = 3; // 3 andares por padrão
            capacidadeMaxima = 6; // 6 pessoas por padrão 
            numeroPessoas = 0; // Vazio
        }

        // Inicialização de um elevador com valores definidos pelo usuário
        public string Inicializar(int _capMax = 6, int _numAnd = 3)
        {
            andar = 0; // Térreo
            numeroAndares = _numAnd; // 3 andares por padrão
            capacidadeMaxima = _capMax; // 6 pessoas por padrão 
            numeroPessoas = 0; // Vazio

            return "\n--------------Os valores foram definidos--------------";
        }

        // Adiciona uma pessoa ao elevador
        public string Entrar()
        {
            // Verifica se o elevador não está cheio
            if (numeroPessoas < capacidadeMaxima)
            {
                numeroPessoas++;
                return "\n--------------Uma pessoa entrou no elevador--------------";
            }
            else
            {
                return "\n--------------O elevador está cheio--------------";
            }
        }

        // Retira uma pessoa do elevador
        public string Sair()
        {
            // Verifica se o elevador não está vazio
            if (numeroPessoas > 0)
            {
                numeroPessoas--;
                return "\n--------------Uma pessoa saiu do elevador--------------";
            }
            else
            {
                return "\n--------------O elevador está vazio--------------";
            }
        }

        // Sobe um andar
        public string Subir()
        {
            // Verifica se o elevador não está no último andar
            if (andar < numeroAndares)
            {
                andar++;
                return "\n--------------O elevador subiu um andar--------------";
            }
            else
            {
                return "\n--------------O elevador já está no último andar--------------";
            }
        }

        // Desce um andar
        public string Descer()
        {
            // Verifica se o elevador não está cheio
            if (andar > 0)
            {
                andar--;
                return "\n--------------O elevador desceu um andar--------------";
            }
            else
            {
                return "\n--------------O elevador já está no térreo--------------";
            }
        }

    }
}
