namespace CadastroDio
{
    public abstract class EntidadeBase
    {
        public int id { get; protected set; }

        protected int RetornaId(){
            return this.id;
        }
        
    }

}