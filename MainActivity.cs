﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace ConversorDeMoneda1
{
    [Activity(Label = "Conversor de Moneda1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private EditText cantidadChilenos;
        private TextView cantidadMexicanos;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set the layout for this activity
            SetContentView(Resource.Layout.activity_main);

            cantidadChilenos = FindViewById<EditText>(Resource.Id.cantidad_chilenos);
            cantidadMexicanos = FindViewById<TextView>(Resource.Id.cantidad_mexicanos);

            Button btnConvertir = FindViewById<Button>(Resource.Id.btn_convertir);
            btnConvertir.Click += BtnConvertir_Click;

            Button btnLimpiar = FindViewById<Button>(Resource.Id.btn_limpiar);
            btnLimpiar.Click += BtnLimpiar_Click;
        }

        private void BtnConvertir_Click(object sender, System.EventArgs e)
        {
            // Obtener la tasa de cambio actual
            double tasaDeCambio = 0.023; // 1 peso chileno = 0.023 pesos mexicanos

            // Convertir la cantidad ingresada de pesos chilenos a pesos mexicanos
            double cantidadCh = double.Parse(cantidadChilenos.Text.Trim());
            double cantidadMex = cantidadCh * tasaDeCambio;

            // Mostrar el resultado en la etiqueta correspondiente
            cantidadMexicanos.Text = "Tu conversión es: " + cantidadMex.ToString("N2");
        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            // Limpiar los campos de entrada y salida
            cantidadChilenos.Text = "";
            cantidadMexicanos.Text = "Aqui aparecera tu convercion";
        }
    }
}

