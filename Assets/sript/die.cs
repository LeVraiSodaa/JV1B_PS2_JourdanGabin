using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Fonction appel�e lorsque l'ennemi meurt
    public void Die()
    {
        // D�truit l'ennemi
        Destroy(gameObject);
        EnemyCounter.EnemyKilled();
    }
}
