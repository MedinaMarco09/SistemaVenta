
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;

namespace SVRepository.Implementation
{
    public class RolRepository : IRolRepository
    {
        private readonly Conexion _conexion;

        public RolRepository(Conexion conexion)
        {
            _conexion = conexion;

        }
        public Task<List<Rol>> Lista()
        {
         
        }
    }
}
