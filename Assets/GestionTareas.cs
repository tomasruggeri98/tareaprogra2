using UnityEngine;
using UnityEngine.UI;

public class GestionTareas : MonoBehaviour
{
    public Text textoTareas;
    private string tareas = "";

    public void AgregarTarea()
    {
        tareas += "X"; // Agrega un caracter (en este caso, "X")
        ActualizarTextoTareas();
    }

    public void QuitarTarea()
    {
        if (tareas.Length > 0)
        {
            tareas = tareas.Substring(0, tareas.Length - 1); // Quita un caracter
            ActualizarTextoTareas();
        }
    }

    private void ActualizarTextoTareas()
    {
        textoTareas.text = "Tareas: " + tareas;
    }
}

