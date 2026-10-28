namespace rtoasaRepasoA.Views;

public partial class vDos : ContentPage
{
	public vDos(string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Alerta", "Bienvenido " + usuario, "ok");
	}

    private void btnReporte_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Views.vTres(txtDesarrolado.Text, txtAsignatura.Text, txtNivel.Text,txtNota.Text, txtExamen.Text));
    }
}