namespace rtoasaRepasoA.Views;

public partial class vTres : ContentPage
{
	public vTres(string Desarrollo, string asignatura, string nivel, string nota, string examen)
	{
		InitializeComponent();
		txtDesarrollado.Text = Desarrollo;
		txtAsignatura.Text = asignatura;
		txtNivel.Text = nivel;
		double notaS = Convert.ToDouble(nota);
		double examenF = Convert.ToDouble(examen);
		double final = (notaS * 0.3) + (examenF * 0.2);
		txtFinal.Text = final.ToString();


	}
}