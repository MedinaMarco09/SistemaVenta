
using SVRepository.Entities;
using SVRepository.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementation
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository; //Inyeccion de instancias

        public RolService(IRolRepository rolRepository) //constructor
        {
            _rolRepository = rolRepository;
        }
        public Task<List<Rol>> Lista()
        {
            return _rolRepository.Lista();
        }
    }
}
