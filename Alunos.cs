using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeListsDictionarys
{
    internal class Alunos
    {
        private Dictionary<int, string> alunos = new Dictionary<int, string>();


        // Adicionar um aluno ao dicionario depois de checar se seu id ja existe
        public bool AdicionarAluno(int matricula, string nome)
        {
            if(BuscarAluno(matricula, false))
            {
                Console.WriteLine("\n> ID ja existente, insira outro");
                return false;
            }

            alunos.Add(matricula, nome);
            Console.WriteLine($"\n> Aluno {nome} de ID {matricula} adicionado com sucesso");
            return true;
        }


        // Listar alunos do dicionario atraves de um foreach
        public void ListarAlunos()
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("\n> Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine("\n> Alunos Registrados:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"\t- ID: {aluno.Key}   -   Nome: {aluno.Value}");
            }
        }


        // Buscar um aluno no dicionario pelo id 
        public bool BuscarAluno(int matricula, bool resultado)
        {
            if (alunos.TryGetValue(matricula, out var nome))
            {
                if (resultado)
                {
                    Console.WriteLine($"\n> Aluno encontrado:\n\t- ID: {matricula}\t-\tNome: {nome}");
                }
                return true;
            }
            else
            {
                if (resultado)
                {
                    Console.WriteLine("\n> Aluno não encontrado.");
                }
                return false;
            }
        }

    }
}
