using System.Data;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{
    public Text displayTexto;
    private string input = "";

    public void AgregarNumero(int numero)
    {
        input += numero.ToString();
        ActualizarDisplay();
    }

    public void AgregarOperacion(string operacion)
    {
        input += operacion;
        ActualizarDisplay();
    }

    public void CalcularResultado()
    {
        try
        {
            DataTable table = new DataTable();
            var result = table.Compute(input, "");
            if (result != null)
            {
                input = result.ToString();
                ActualizarDisplay();
            }
        }
        catch (Exception)
        {
            input = "Error";
            ActualizarDisplay();
        }
    }

    public void Limpiar()
    {
        input = "";
        ActualizarDisplay();
    }

    private void ActualizarDisplay()
    {
        displayTexto.text = input;
    }

    private float Evaluate(string expression)
    {
        // Este m�todo utiliza la funci�n eval de C# para evaluar la expresi�n matem�tica.
        // Esto es solo para simplificar el ejemplo y puede no ser la mejor soluci�n en un entorno de producci�n.

        System.Data.DataTable table = new System.Data.DataTable();
        return float.Parse((string)table.Compute(expression, string.Empty));
    }
}

