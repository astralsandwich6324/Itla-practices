using System.Security.Cryptography;

namespace POS.Api.Modelos.Response
{
    public class Response<T>
    {
        public int Exito { get; set; }

        public string Mensaje { get; set; }

        public T Data { get; set; }

        public Response()
        {
            this.Exito = 0;
        }
    }
}
