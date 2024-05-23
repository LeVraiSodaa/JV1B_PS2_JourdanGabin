using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Référence au joueur
    public float speed = 20.0f; // Vitesse de l'ennemi
    public float rotationSpeed = 200f; // Vitesse de rotation de l'ennemi
    private bool isFollowing = false;

    void Update()
    {
        // Si l'ennemi suit le joueur, il se déplace vers le joueur
        if (isFollowing)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            RotateEnemy();
        }
    }

    // Méthode pour faire tourner l'ennemi sur lui-même
    private void RotateEnemy()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    public void StartFollowing()
    {
        isFollowing = true; // Active le suivi du joueur
    }
}
