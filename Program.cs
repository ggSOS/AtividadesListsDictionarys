namespace AtividadeListsDictionarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Alunos registroDeAlunos1 = new Alunos();

            while (true)
            {
                Program.ExibirMenu();
                escolha = Console.ReadLine() ?? "";

                while (!opcoesMenu.ContainsKey(escolha))
                {
                    Console.WriteLine("\n> Opção inválida, tente novamente.");
                    Program.ExibirMenu();
                    escolha = Console.ReadLine() ?? "";
                }

                if (escolha.Equals("1")){
                    Console.Write("\n> Insira o ID:\n\t> ");
                    int idInt;
                    if (int.TryParse(Console.ReadLine() ?? "", out idInt)){
                        Console.Write("\n> Insira o nome do aluno:\n\t> ");
                        string nomeAluno = Console.ReadLine() ?? "";
                        registroDeAlunos1.AdicionarAluno(idInt, nomeAluno);
                    }
                    else
                    {
                        Console.WriteLine("\n ID inválido! ");
                    }
                }
                else if (escolha.Equals("2"))
                {
                    registroDeAlunos1.ListarAlunos();
                }
                else if (escolha.Equals("3"))
                {
                    Console.Write("\n> Insira o ID:\n\t> ");
                    int idInt;
                    if (int.TryParse(Console.ReadLine() ?? "", out idInt))
                    {
                        registroDeAlunos1.BuscarAluno(idInt, true);
                    }
                    else
                    {
                        Console.WriteLine("\n ID inválido! ");
                    }
                }
                else
                {
                    break;
                }
            }
        }


        private static Dictionary<string, string> opcoesMenu = new Dictionary<string, string>() {
                {"1", "Adicionar Aluno"},
                {"2", "Listar Alunos"},
                {"3", "Buscar Aluno"},
                {"4", "Sair"}
            };


        public static void ExibirMenu()
        {
            Console.WriteLine("\n> Insira um comando:");
            foreach (var opcao in opcoesMenu)
            {
                Console.WriteLine($"\t{opcao.Key} - {opcao.Value}");
            }
            Console.Write("\t> ");
            return;
        }
    }
}