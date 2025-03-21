namespace P.Final.Components.Modelos.Response
{
    public class Response<T>
    {
        public int Exito { get; set; }

        public string Mensaje { get; set; }

        public T Data { get; set; }


    }
}
