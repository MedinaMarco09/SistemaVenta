
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using SVServices.Interfaces;
using SVServices.Recursos.Cloudinary;
using System.Net;

namespace SVServices.Implementation
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly IConfiguration _configuracion;
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration configuration)
        {
            _configuracion = configuration;

            var CloudName = _configuracion["Cloudinary:CloudName"];
            var ApiKey = _configuracion["Cloudinary:ApiKey"];
            var ApiSecret = _configuracion["Cloudinary:ApiSecret"];

            _cloudinary = new Cloudinary(new Account(CloudName,ApiKey,ApiSecret));
        }
        public async Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen)
        {
            var cloudinaryResponse = new CloudinaryResponse();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(nombreImagen, formatoImagen),
                AssetFolder = "sistemaVentaWF"
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams); //respuesta personalizada

            if(uploadResult.StatusCode == HttpStatusCode.OK)
            {
                cloudinaryResponse.PublicId= uploadResult.PublicId;                     //Se corrigio un error que daba un valor null en PublicId
                cloudinaryResponse.SecureUrl = uploadResult.SecureUrl.ToString();       //, el error estaba en que la variaba estaba como "uploadParams" en vez de "uploadResult"
            }
            else
            {
                cloudinaryResponse.PublicId = "";

            }
            return cloudinaryResponse;
          
        }
        public async Task<bool> EliminarImagen(string publicid)
        {
            var deleteParams = new DeletionParams(publicid);
            var deleteResult = await _cloudinary.DestroyAsync(deleteParams);

            if(deleteResult.StatusCode == HttpStatusCode.OK)
                return true;
            else
                return false;
        }


    }
}
