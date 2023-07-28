namespace Dinosaurio5834324;

public partial class MainPage : ContentPage
{
    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DE LA IMAGEN
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        string nombre = Convert.ToString(NDino.Text);
        double peso = Convert.ToDouble(pesKg.Text);
        double altura = Convert.ToDouble(altMts.Text);

        dinoNom.Text = "Nombre del dinosaurio: " + nombre;
        pesoLb.Text = "Peso en LB: " + (peso * 2.2);
        altCm.Text = "Altura en CM: " + (altura * 100);
    }
}

