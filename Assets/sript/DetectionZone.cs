using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    private EnemyFollow enemyFollow;

    void Start()
    {
        enemyFollow = GetComponentInParent<EnemyFollow>(); // Récupère le script EnemyFollow attaché à l'ennemi
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemyFollow.StartFollowing(); // Active le suivi lorsque le joueur entre dans la zone
        }
    }
}
