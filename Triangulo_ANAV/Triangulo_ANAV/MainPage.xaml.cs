using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_ANAV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var baseTriangulo = float.Parse(Base.Text); 
            var alturaTriangulo = float.Parse(Altura.Text);
            var ladoUno = float.Parse(lado1.Text);
            var ladoDos = float.Parse(lado2.Text);

            var areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Calcular.Text = areaTriangulo.ToString();

            string resultado = "";

            if (baseTriangulo == ladoUno && baseTriangulo == ladoDos)
            {
                resultado = "El triangulo es Equilatero";
                imgequilatero.IsVisible = true;
                imgescaleno.IsVisible = false;
                imgisoceles.IsVisible = false;
            }

            else if(baseTriangulo != ladoUno && baseTriangulo != ladoDos)
            {
                resultado = "El triangulo es Escaleno";
                imgescaleno.IsVisible = true;
                imgisoceles.IsVisible= false;
                imgequilatero.IsVisible= false;
            }
            else 
            {
                resultado = "El triangulo es isoceles";
                imgisoceles.IsVisible = true;
                imgequilatero.IsVisible = false;
                imgescaleno.IsVisible= false;
                
            }

            DisplayAlert("Bien!",resultado, "Quitar");

        }
         


    }
}
