
using SVRepository.Entities;
using SVRepository.Implementation;
using SVRepository.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementation
{
    public class MedidaService : IMedidaService
    {
        //***********************************
        //Constructor para recibir la inyeccion de dependencia
        //**********************************
        private readonly IMedidaRepository _medidaRepository;  //Variable
        public MedidaService(IMedidaRepository medidaRepository)  
        {
            _medidaRepository = medidaRepository; //Valor del constructor
        }

        public async Task<List<Medida>> Lista()
        {
            return await _medidaRepository.Lista();
        }
    }
}
