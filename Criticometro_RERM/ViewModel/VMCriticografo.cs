using System;
using System.Collections.Generic;
using System.Text;
using Criticometro_RERM.ViewModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;

namespace Criticometro_RERM.ViewModel
{
    public class VMCriticografo : ViewModelBase
    {
        string _Nombre;

        //string caracteristica1 = "";
        //string caracteristica2 = "";
        //string caracteristica3 = "";
        //string caracteristica4 = "";
        //string caracteristica5 = "";
        //string caracteristica6 = "";
        //public string _Nombre { get; set; }
        //string _Mujer;
        //public string _Hombre { get; set; }
        private bool _Mujer;
        private bool _Hombre;
        private bool _Caracteristica1;
        private bool _Caracteristica2;
        private bool _Caracteristica3;
        private bool _Caracteristica4;
        private bool _Caracteristica5;
        private bool _Caracteristica6;
        private string _Mensaje;
        public VMCriticografo()
        {

        }
        public VMCriticografo(INavigation navigation)
        {
            Navigation = navigation;
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }
        //public string Genero
        //{
        //    get { return _Genero; }
        //    set { SetValue(ref _Genero, value); }
        //}
        public bool Hombre
        {
            get { return _Hombre; }
            set { SetValue(ref _Hombre, value); }
        }
        public bool Mujer
        {
            get { return _Mujer; }
            set { SetValue(ref _Mujer, value); }
        }
        public bool Caracteristica1
        {
            get { return _Caracteristica1; }
            set { SetValue(ref _Caracteristica1, value); }
        }
        public bool Caracteristica2
        {
            get { return _Caracteristica2; }
            set { SetValue(ref _Caracteristica2, value); }
        }
        public bool Caracteristica3
        {
            get { return _Caracteristica3; }
            set { SetValue(ref _Caracteristica3, value); }
        }
        public bool Caracteristica4
        {
            get { return _Caracteristica4; }
            set { SetValue(ref _Caracteristica4, value); }
        }
        public bool Caracteristica5
        {
            get { return _Caracteristica5; }
            set { SetValue(ref _Caracteristica5, value); }
        }
        public bool Caracteristica6
        {
            get { return _Caracteristica6; }
            set { SetValue(ref _Caracteristica6, value); }
        }
        private void RBH_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            /*RadioButton rdb = sender as RadioButton;
            //Mensaje = _Mensaje;
            //Mensaje = $" eres {rdb.Content}";
            //if (Hombre == "Hombre")
            //{
            //    Mensaje = "Es Hombre";
            //}
            //else if (Mujer == "Mujer")
            //{
            //    Mensaje = "Es Hombre";
            //}
            //else
            //{
            //    Mensaje = "error";
            //}
            //DisplayAlert("Mensaje", Mensaje, "salir");*/
        }
        public void Criticar(string nombre)
        {
            Mensaje = $"{nombre} es ";
        }
        public async void BtnCriticar()
        {
            Criticar(Nombre);
            if (_Caracteristica1 == true)
            {
                if(Hombre == true)
                {
                    Mensaje += "Alto ";
                }
                else { Mensaje += "Alta "; }
            }
            if (_Caracteristica2 == true)
            {
                if (Hombre == true)
                {
                    Mensaje += "Feo ";
                }
                else { Mensaje += "Fea "; }
            }
            if (_Caracteristica3 == true)
            {
                if (Hombre == true)
                {
                    Mensaje += "Listo ";
                }
                else { Mensaje += "Lista "; }
            }
            if (_Caracteristica4 == true)
            {
                Mensaje += "Extrabagante ";
            }
            if (_Caracteristica5 == true)
            {
                if (Hombre == true)
                {
                    Mensaje += "Raro ";
                }
                else { Mensaje += "Rara "; }
            }
            if (_Caracteristica6 == true)
            {
                Mensaje += "Grande ";
            }
            //await DisplayAlert("Estado", Mensaje, "Sair");
            string[]aux = Mensaje.Split(',');
            int coma = Mensaje.LastIndexOf(",");
            string buscado = ", ";
            Mensaje = Mensaje.Remove(coma, buscado.Length).Insert(coma," y ");
        }
        public ICommand CriticarCommand => new Command(BtnCriticar);
    }
}
