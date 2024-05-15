using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackDelay = 0.5f; // Délai entre chaque attaque en secondes
    private float lastAttackTime = 0f; // Temps de la dernière attaque

    void Update()
    {
        // Vérifie si le joueur peut attaquer
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastAttackTime + attackDelay)
        {
            // Effectue l'attaque
            Attack();

            // Met à jour le temps de la dernière attaque
            lastAttackTime = Time.time;
        }
    }

    // Fonction pour effectuer l'attaque
    void Attack()
    {
        // Ajoute ici le code de ton attaque
        Debug.Log("Player attacks!");
    }
}
