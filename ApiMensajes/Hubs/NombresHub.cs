using Microsoft.AspNetCore.SignalR;
namespace ApiMensajes.Hubs
{
    public class NombresHub:Hub
    {

        public async void AgregarNombre(string nombre)
        {
            await Clients.All.SendAsync("NombreNuevo", nombre);
        }

        public async void EliminarNombre(string nombre)
        {
            await Clients.All.SendAsync("NombreEliminado", nombre);
        }
    }
}
