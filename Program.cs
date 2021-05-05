using System;

namespace DIO.Series
{
    class Program
    {
        static Catalog catalogo = new Catalog();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						catalogo.Listar();
						break;
					case "2":
						catalogo.InserirTitulo();
						break;
					case "3":
						catalogo.AtualizaTitulo();
						break;
					case "4":
						catalogo.ExcluirTitulo();
						break;
					case "5":
						catalogo.VisualizaTitulo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			//Console.ReadLine();
        }

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Seja bem vindo ao DIO-STREAMING!!!");
			Console.WriteLine("Informe sua opção:");

			Console.WriteLine("1- Listar Catálogo");
			Console.WriteLine("2- Inserir novo título");
			Console.WriteLine("3- Atualizar título");
			Console.WriteLine("4- Excluir título");
			Console.WriteLine("5- Visualizar título");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}