using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private bool specialAbilityEnabled = false; // Indique si la capacit� sp�ciale est activ�e

    // Fonction pour activer la capacit� sp�ciale (par exemple, le changement de sc�ne)
    public void EnableSpecialAbility()
    {
        // Activer la capacit� sp�ciale (par exemple, le changement de sc�ne)
        Debug.Log("Special Ability enabled!");
        specialAbilityEnabled = true;
    }

    void Update()
    {
        // V�rifier si la touche "W" est enfonc�e et si la capacit� sp�ciale est activ�e
        if (specialAbilityEnabled && Input.GetKeyDown(KeyCode.V))
        {
            // Charger la nouvelle sc�ne
            SceneManager.LoadScene(1);
        }
    }
}
