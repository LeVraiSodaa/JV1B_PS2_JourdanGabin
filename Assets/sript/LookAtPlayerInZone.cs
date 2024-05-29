using UnityEngine;

public class FollowPlayerInCircularZone : MonoBehaviour
{
    public Transform player; // Le transform du joueur
    public float followSpeed = 2f; // Vitesse à laquelle l'objet suit le joueur

    private Vector2 initialPosition; // Position initiale de l'objet
    private float zoneRadius = 0.58f; // Rayon fixe de la zone de suivi

    void Start()
    {
        // Enregistrer la position initiale de l'objet
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculer la position cible basée sur la position du joueur
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z);

        // Vérifier si la nouvelle position dépasse les limites du cercle
        Vector2 directionToPlayer = targetPosition - transform.position;
        Vector2 newPosition = transform.position + (Vector3)directionToPlayer.normalized * followSpeed * Time.deltaTime;

        // Calculer la distance par rapport à la position initiale
        float distanceFromInitial = Vector2.Distance(initialPosition, newPosition);

        // Si la nouvelle position est en dehors du cercle, limiter l'objet à rester dans le cercle
        if (distanceFromInitial > zoneRadius)
        {
            // Limiter la position de l'objet pour qu'elle reste dans le cercle
            newPosition = initialPosition + directionToPlayer.normalized * zoneRadius;
        }

        // Mettre à jour la position de l'objet
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }

    void OnDrawGizmos()
    {
        // Utiliser la position initiale comme centre de la zone circulaire
        Vector2 zoneCenter = Application.isPlaying ? initialPosition : transform.position;

        // Dessiner la zone circulaire dans l'éditeur pour la visualiser
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(zoneCenter, zoneRadius);
    }
}
