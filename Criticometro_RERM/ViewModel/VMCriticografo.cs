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
        public string _Genero { get; set; }
        //string caracteristica1 = "";
        //string caracteristica2 = "";
        //string caracteristica3 = "";
        //string caracteristica4 = "";
        //string caracteristica5 = "";
        //string caracteristica6 = "";
        //public string _Nombre { get; set; }
        //string _Mujer;
        //public string _Hombre { get; set; }
        bool _Caracteristica1;
        bool _Caracteristica2;
        bool _Caracteristica3;
        bool _Caracteristica4;
        bool _Caracteristica5;
        bool _Caracteristica6;
        string _Mensaje;
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
        //public string Caracteristica1
        //{
        //    get { return _Caracteristica1; }
        //    set { SetValue(ref _Caracteristica1, value); }
        //}
        //public string Caracteristica2
        //{
        //    get { return _Caracteristica2; }
        //    set { SetValue(ref _Caracteristica2, value); }
        //}
        //public string Caracteristica3
        //{
        //    get { return _Caracteristica3; }
        //    set { SetValue(ref _Caracteristica3, value); }
        //}
        //public string Caracteristica4
        //{
        //    get { return _Caracteristica4; }
        //    set { SetValue(ref _Caracteristica4, value); }
        //}
        //public string Caracteristica5
        //{
        //    get { return _Caracteristica5; }
        //    set { SetValue(ref _Caracteristica5, value); }
        //}
        //public string Caracteristica6
        //{
        //    get { return _Caracteristica6; }
        //    set { SetValue(ref _Caracteristica6, value); }
        //}
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
        public void Criticar(string nombre, string sexo)
        {
            Mensaje = $"{nombre} es {sexo}";
        }
        public async void BtnCriticar()
        {
            Criticar(Nombre, _Genero);
            if (_Caracteristica1 == true)
            {
                Mensaje += "Alto";
            }
            if (_Caracteristica2 == true)
            {
                Mensaje += "Feo";
            }
            if (_Caracteristica3 == true)
            {
                Mensaje += "Listo";
            }
            if (_Caracteristica4 == true)
            {
                Mensaje += "Extrabagante";
            }
            if (_Caracteristica5 == true)
            {
                Mensaje += "Raro";
            }
            if (_Caracteristica6 == true)
            {
                Mensaje += "Grande";
            }
            await DisplayAlert("Estado", Mensaje, "Sair");
        }
        public ICommand CriticarCommand => new Command(BtnCriticar);
    }
}
