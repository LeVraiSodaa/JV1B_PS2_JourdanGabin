using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Fonction appelée lorsque l'ennemi meurt
    public void Die()
    {
        // Détruit l'ennemi
        Destroy(gameObject);
        EnemyCounter.EnemyKilled();
    }
}
