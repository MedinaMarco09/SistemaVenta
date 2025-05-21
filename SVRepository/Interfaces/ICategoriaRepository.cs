
using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> Lista(String busca = "");
        Task<string> Crear(Categoria Objeto);
        Task<string> Editar(Categoria Objeto);
    }
}
