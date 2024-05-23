using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    private EnemyFollow enemyFollow;

    void Start()
    {
        enemyFollow = GetComponentInParent<EnemyFollow>(); // R�cup�re le script EnemyFollow attach� � l'ennemi
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemyFollow.isFollowing = true; // Active le suivi lorsque le joueur entre dans la zone
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemyFollow.isFollowing = false; // D�sactive le suivi lorsque le joueur quitte la zone
        }
    }
}
