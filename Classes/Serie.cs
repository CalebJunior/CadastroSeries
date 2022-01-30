namespace CadastroDio.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero{ get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }
        
        private int Ano { get; set; }


        private bool Excluido {get;set;}

        public Serie(int id, int Ano, string Titulo, string Descricao, Genero genero){
            this.id = id;
            this.Ano = Ano;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Genero = genero;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno ="";
            retorno += "Gênero: " +this.Genero + Environment.NewLine;
            retorno += "Titulo: " +this.Titulo + Environment.NewLine;
            retorno += "Descrição: "+this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: "+this.Ano+Environment.NewLine;
            retorno+="Excluido: "+this.Excluido;
            return retorno;

        }

        public string RetornaTitulo(){
            return this.Titulo;
        }

        public int RetornaiId(){
            return this.id;
        }

        public void Exclui(){
            this.Excluido = true;
        }

        public bool retornaExcluido()
		{
			return this.Excluido;
		}
    }
}