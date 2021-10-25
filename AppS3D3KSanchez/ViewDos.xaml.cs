using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3D3KSanchez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
        public ViewDos(string usuario)
        {
            InitializeComponent();

            //Se carga los datos para mostrar
            lblUsuario.Text = "Bienvenido: " + usuario.ToString();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Variables de almacenamiento
                double notaUno = Convert.ToDouble(txtNotaUno.Text);
                double examenUno = Convert.ToDouble(txtExamenUno.Text);

                double notaDos = Convert.ToDouble(txtNotaDos.Text);
                double examenDos = Convert.ToDouble(txtExamenDos.Text);

                //Operaciones a calcular
                if (notaUno < 0.1 || notaUno > 10 || notaDos < 0.1 || notaDos > 10 || examenUno < 0.1 || examenUno > 10 || examenDos < 0.1 || examenDos > 10)
                {
                    DisplayAlert("IMPORTANTE", "Los valores de las notas NO deben ser menor a 0.1, NI mayor a 10", "OK");
                }
                else
                {
                    double notaParcialUno = (notaUno * 0.3) + (examenUno * 0.2);
                    double notaParcialDos = (notaDos * 0.3) + (examenDos * 0.2);

                    double notaFinal = notaParcialUno + notaParcialDos;

                    //Visualizar resultado operaciones
                    txtParcialUno.Text = notaParcialUno.ToString();
                    txtParcialDos.Text = notaParcialDos.ToString();
                    txtNotaFinal.Text = notaFinal.ToString();

                    //Condiciones de estado

                    if (notaFinal >= 7)
                    {
                        txtEstado.Text = "APROBADO";
                    }
                    else if (notaFinal >= 5 && notaFinal <= 6.9)
                    {
                        txtEstado.Text = "COMPLEMENTARIO";
                    }
                    else
                    {
                        txtEstado.Text = "REPROBADO";
                    }
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }
        }
    }
}