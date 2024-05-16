using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool specialAbilityEnabled = false; // Indique si la capacité spéciale est activée
    private int eliminationCount = 0; // Compteur d'éliminations

    // Référence à l'objet de téléportation
    public GameObject teleportObject;

    // Fonction pour activer la capacité spéciale (par exemple, téléportation)
    public void EnableSpecialAbility()
    {
        // Activer la capacité spéciale (par exemple, téléportation)
        Debug.Log("Special Ability enabled!");
        specialAbilityEnabled = true;
    }

    // Fonction pour augmenter le compteur d'éliminations
    public void IncreaseEliminationCount()
    {
        eliminationCount++;
        Debug.Log("Elimination count increased: " + eliminationCount);
    }

    void Update()
    {
        // Vérifier si la touche "V" est enfoncée et si la capacité spéciale est activée
        if (specialAbilityEnabled && Input.GetKeyDown(KeyCode.V))
        {
            // Vérifier si l'objet de téléportation est assigné
            if (teleportObject != null)
            {
                // Téléporter le joueur à la position de l'objet de téléportation
                transform.position = teleportObject.transform.position;

                // Soustraire 3 du compteur d'éliminations après la téléportation
                eliminationCount -= 3;
                Debug.Log("Elimination count decremented by 3: " + eliminationCount);

                // Si le compteur devient négatif, le remettre à zéro
                if (eliminationCount < 0)
                {
                    eliminationCount = 0;
                }
            }
            else
            {
                Debug.LogWarning("Teleport object is not assigned!");
            }
        }
    }
}