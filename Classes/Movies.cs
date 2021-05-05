using System;

namespace DIO.Series
{
    public class Movies : BaseEntity
    {
         private Gender Genero { get; set; }
		private string Titulo { get; set; }
		private string Sinopse { get; set; }
		private int Ano { get; set; }
        private bool Excluded {get; set;}

        //methods
        public Movies(int id, Gender genero, string titulo, string sinopse, int ano)
		{
		this.Id = id;
		this.Genero = genero;
		this.Titulo = titulo;
		this.Sinopse = sinopse;
		this.Ano = ano;
        this.Excluded = false;
        }

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            //retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

         public string getTitulo()
		{
			return this.Titulo;
		}

		public int getId()
		{
			return this.Id;
		}

        public void Delete(){
            this.Excluded = true;
        }
        public bool getDeleted()
		{
			return this.Excluded;
		}
    }
}