using UnityEngine;

public class PhantomBehavior : MonoBehaviour
{
    public float speed = 3f; // Velocidad del phantom
    public float detectionRadius = 7f; // Radio de detección del jugador
    private Transform player; // Referencia al jugador
    private Vector2 initialPosition; // Posición inicial del phantom
    private bool isActive = false; // Estado del phantom: activo o inactivo

    void Start()
    {
        // Guardar la posición inicial del phantom
        initialPosition = transform.position;

        // Encontrar al jugador automáticamente por la etiqueta
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogError("No se encontró un objeto con la etiqueta 'Player'.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Comprobar si el jugador está dentro del radio de detección
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            if (distanceToPlayer <= detectionRadius)
            {
                // Activar el phantom si el jugador está cerca
                isActive = true;
            }
            else
            {
                // Desactivar el phantom si el jugador está fuera del rango
                isActive = false;
            }

            // Moverse hacia el jugador si está activo
            if (isActive)
            {
                Vector2 direction = (player.position - transform.position).normalized;
                transform.position += (Vector3)direction * speed * Time.deltaTime;
            }
        }
    }

    // Método para reiniciar el phantom al cambiar de área
    public void ResetPhantom()
    {
        transform.position = initialPosition; // Volver a la posición inicial
        isActive = false; // Detener el movimiento hasta que el jugador se acerque
    }

    // Dibujar el radio de detección en el editor para depuración
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green; // Cambiar el color para distinguirlo de otros enemigos
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
