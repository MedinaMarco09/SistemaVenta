
using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<Producto>> Lista(String busca = "");
        Task<string> Crear(Producto Objeto);
        Task<string> Editar(Producto Objeto);
    }
}
