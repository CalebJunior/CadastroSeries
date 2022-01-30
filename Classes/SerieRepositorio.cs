using CadastroDio.Classes;
using CadastroDio.Interfaces;

namespace CadastroDio
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int ID)
        {
            listaSerie[ID].Exclui();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoID()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}