using System;

namespace DIO.Series
{
    public class Catalog
    {
        static RepositorySeries serie = new RepositorySeries();
        static RepositoryMovies movie = new RepositoryMovies();

//METODOS EXTERNOS ---------------------------------------------------------
//Listar     
        public void Listar(){
            var ser = serie.List();
            var mov = movie.List();

            Console.WriteLine("======SERIES======");
            if (ser.Count == 0) {
				Console.WriteLine("Nenhuma série cadastrada."); 
            } else{
                foreach (var serie in ser){
                    var excluido = serie.getDeleted();
				    Console.WriteLine("#ID {0}: - {1}, {2}º Temporada {3}", serie.getId(), serie.getTitulo(),
                                     serie.getSeason(), (excluido ? "- *Excluído*" : "")); }
		    }

            Console.WriteLine("======FILMES======");
            if (mov.Count == 0) {
				Console.WriteLine("Nenhum filme cadastrado.");
			} else{
                foreach (var filme in mov){
                    var excluido = filme.getDeleted();
				    Console.WriteLine("#ID {0}: - {1} {2}", filme.getId(), filme.getTitulo(),
                                     (excluido ? " - *Excluído*" : "")); }
		    }
        }
//Inserir
        public void InserirTitulo() {
			Console.WriteLine("Inserir novo Titulo: 1 - Filme // 2 - Serie");
            int t = Int32.Parse(Console.ReadLine());

            if(t==1){
                InsertMov();
            } else if(t==2){
                InsertSer();
            }
		}
//Atualiza
        public void AtualizaTitulo() {
			Console.WriteLine("Atulizar um Título existente: 1 - Filme // 2 - Serie");
            int t = Int32.Parse(Console.ReadLine());
            if(t==1){
                AtualizaMov(); 
            } else if(t==2){
                AtualizaSer();
            }
		}
//Visualiza
        public void VisualizaTitulo(){
            Console.WriteLine("Visualizar um Título existente: 1 - Filme // 2 - Série");
            int t = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o id do título: ");
			int indicetitulo = int.Parse(Console.ReadLine());

            if(t==1){
			    var titulo = movie.getId(indicetitulo);
                Console.WriteLine(titulo);
            } else if(t==2){
                var titulo = serie.getId(indicetitulo);
                Console.WriteLine(titulo);
            }
        }
//Exlcuir
        public void ExcluirTitulo(){
            Console.WriteLine("DELETAR um título existente: 1 - Filme // 2 - Série");
			int t = int.Parse(Console.ReadLine());

            if(t==1){
                DeletarMov();
            } else if(t==2){
                DeletarSer();
            }
        }
//METODOS INTERNOS -------------------------------------------------------------------
//Filmes

//insere_filme
        private void InsertMov(){
            Console.WriteLine("INSERIR NOVO FILME!");
            foreach (int i in Enum.GetValues(typeof(Gender))) {
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse do Filme: ");
			string entradaDescricao = Console.ReadLine();

			Movies novoFilme = new Movies(id: movie.NextId(),
										genero: (Gender)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										sinopse: entradaDescricao);

			movie.Insert(novoFilme);
		}
//atualiza_filme
        private void AtualizaMov(){
            Console.WriteLine("ATUALIZAR UM FILME REGISTRADO!");
            Console.Write("Digite o ID do FILME a ser ATUALIZADO: ");
            int indicefilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Gender))) {
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse do Filme: ");
			string entradaDescricao = Console.ReadLine();

			Movies atualizaMov = new Movies(id: indicefilme,
										genero: (Gender)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										sinopse: entradaDescricao);

			movie.Update(indicefilme, atualizaMov);
		}
//deletar_filme
        private void DeletarMov(){
            Console.Write("Digite o ID do FILME a ser EXCLUÍDO: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            movie.Delete(indiceFilme);
        }
        
//Series

//insere_serie
        private void InsertSer(){
            Console.WriteLine("INSERIR NOVA SÉRIE!");
            foreach (int i in Enum.GetValues(typeof(Gender))) {
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Temporada da Série: ");
            int entradaTemporada = Int16.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse do Filme: ");
			string entradaSinopse = Console.ReadLine();

			Series novaSerie = new Series(id: serie.NextId(),
										genero: (Gender)entradaGenero,
										titulo: entradaTitulo,
                                        temporada: entradaTemporada,
										sinopse: entradaSinopse,
                                        ano: entradaAno);

			serie.Insert(novaSerie);
        }
//atualiza_serie
        private void AtualizaSer(){
            Console.WriteLine("ATUALIZAR SÉRIE REGISTRADA!");
            Console.Write("Digite o ID da SERIE a ser ATUALIZADA: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Gender))) {
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Temporada da Série: ");
            int entradaTemporada = Int16.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse do Filme: ");
			string entradaSinopse = Console.ReadLine();

			Series atualizaserie = new Series(id: indiceSerie,
										genero: (Gender)entradaGenero,
										titulo: entradaTitulo,
                                        temporada: entradaTemporada,
										sinopse: entradaSinopse,
                                        ano: entradaAno);

			serie.Update(indiceSerie, atualizaserie);
        }
//deletar_serie
        private void DeletarSer(){
            Console.Write("Digite o ID da SERIE a ser EXCLUÍDA: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            serie.Delete(indiceSerie);
        }

    }
}