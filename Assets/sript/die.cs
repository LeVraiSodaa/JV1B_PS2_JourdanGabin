using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Référence à l'EnemyKillCounter
    private EnemyKillCounter enemyKillCounter;

    void Start()
    {
        // Trouver l'EnemyKillCounter dans la scène
        enemyKillCounter = GameObject.FindObjectOfType<EnemyKillCounter>();
    }

    // Méthode pour détruire l'ennemi
    public void Die()
    {
        // Appeler la méthode pour augmenter le compteur d'ennemis
        if (enemyKillCounter != null)
        {
            enemyKillCounter.EnemyDestroyed();
        }

        // Code pour détruire l'ennemi
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        // Assurez-vous de vérifier que l'ennemi est tué par le joueur
        PowerBarController powerBarController = FindObjectOfType<PowerBarController>();
        if (powerBarController != null)
        {
            powerBarController.EnemyKilled();
        }
    }
}
