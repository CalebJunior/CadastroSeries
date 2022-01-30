using System.Collections.Generic;
namespace CadastroDio.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere (T entidade);

        void Exclui (int ID);

        void Atualiza (int id, T entidade);

        int ProximoID();
         
    }
}