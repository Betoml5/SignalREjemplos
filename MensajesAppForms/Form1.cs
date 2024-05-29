using Microsoft.AspNetCore.SignalR.Client;

namespace MensajesAppForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HubConnection hub;

        private async void Form1_Load(object sender, EventArgs e)
        {
            hub = new HubConnectionBuilder()
                .WithUrl("https://octavo.itesrc.net/nombres")
                .WithAutomaticReconnect()
                .Build();

            hub.On<string>("NombreNuevo", nombre =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    lstMensajes.Items.Add(nombre);
                    lstMensajes.SelectedIndex = lstMensajes.Items.Count - 1;
                }));
            });

            hub.On<string>("NombreBorrado", nombre =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    lstMensajes.Items.Remove(nombre);
                }));
            });

            await hub.StartAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAgregar.Text))
            {
                await hub.InvokeAsync("AgregarNombre", txtAgregar.Text);
            }
        }

        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lstMensajes.Text))
            {
                await hub.InvokeAsync("EliminarNombre", lstMensajes.Text);
            }
        }
    }
}
