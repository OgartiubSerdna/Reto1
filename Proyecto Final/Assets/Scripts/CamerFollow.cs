using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float xOffset = 0f;
    public float moveSpeed = 10f;

    private float initialYPosition;

    private void Start()
    {
        initialYPosition = transform.position.y;
    }

    private void Update()
    {
        // Obtener la posición actual de la cámara
        Vector3 currentPosition = transform.position;

        // Calcular la posición objetivo en el eje X
        Vector3 targetPosition = new Vector3(playerTransform.position.x + xOffset, initialYPosition, currentPosition.z);

        // Si el jugador está en el centro de la cámara, mover la cámara de manera inmediata
        if (Mathf.Abs(playerTransform.position.x - currentPosition.x) <= 0.01f)
        {
            transform.position = targetPosition;
        }
        else
        {
            // Si no, mover la cámara hacia la posición objetivo suavemente
            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
