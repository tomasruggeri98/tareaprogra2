using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    void Update()
    {
        // Movimiento del personaje
        MoverPersonaje();

        // Disparo al hacer clic
        if (Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }

    void MoverPersonaje()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);
        movimiento.Normalize();

        // Mover el personaje
        transform.Translate(movimiento * velocidadMovimiento * Time.deltaTime);
    }

    void Disparar()
    {
        // Obtener la posición del ratón en el mundo
        Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Realizar el raycast desde la posición del personaje en dirección al ratón
        RaycastHit2D hit = Physics2D.Raycast(transform.position, (posicionMouse - transform.position).normalized);

        // Verificar si el raycast golpea a un enemigo
        if (hit.collider != null && hit.collider.CompareTag("Enemigo"))
        {
            // Destruir al enemigo
            Destroy(hit.collider.gameObject);
        }
    }
}
