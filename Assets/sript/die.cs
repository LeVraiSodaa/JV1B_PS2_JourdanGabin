using UnityEngine;

public class Enemy : MonoBehaviour
{
    // R�f�rence � l'EnemyKillCounter
    private EnemyKillCounter enemyKillCounter;

    void Start()
    {
        // Trouver l'EnemyKillCounter dans la sc�ne
        enemyKillCounter = GameObject.FindObjectOfType<EnemyKillCounter>();
    }

    // M�thode pour d�truire l'ennemi
    public void Die()
    {
        // Appeler la m�thode pour augmenter le compteur d'ennemis
        if (enemyKillCounter != null)
        {
            enemyKillCounter.EnemyDestroyed();
        }

        // Code pour d�truire l'ennemi
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        // Assurez-vous de v�rifier que l'ennemi est tu� par le joueur
        PowerBarController powerBarController = FindObjectOfType<PowerBarController>();
        if (powerBarController != null)
        {
            powerBarController.EnemyKilled();
        }
    }
}
