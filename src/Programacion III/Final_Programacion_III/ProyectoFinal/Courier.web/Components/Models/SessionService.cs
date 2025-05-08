namespace Courier.web.Components.Models
{
    public static class SessionService
    {
        public static string UsuarioActualId { get; set; }

        public static bool EstaLogeado => !string.IsNullOrEmpty(UsuarioActualId);
    }
}
