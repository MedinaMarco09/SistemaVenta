
using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IMedidaRepository   //Metodos
    {
        Task<List<Medida>> Lista();
    }
}
