using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Référence au joueur
    public float speed = 2.0f; // Vitesse de l'ennemi

    [HideInInspector]
    public bool isFollowing = false;

    void Update()
    {
        // Si l'ennemi suit le joueur, il se déplace vers le joueur
        if (isFollowing)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
