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
        // Obtener la posici�n actual de la c�mara
        Vector3 currentPosition = transform.position;

        // Calcular la posici�n objetivo en el eje X
        Vector3 targetPosition = new Vector3(playerTransform.position.x + xOffset, initialYPosition, currentPosition.z);

        // Si el jugador est� en el centro de la c�mara, mover la c�mara de manera inmediata
        if (Mathf.Abs(playerTransform.position.x - currentPosition.x) <= 0.01f)
        {
            transform.position = targetPosition;
        }
        else
        {
            // Si no, mover la c�mara hacia la posici�n objetivo suavemente
            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
