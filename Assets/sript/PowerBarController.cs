using UnityEngine;
using UnityEngine.UI;

public class PowerBarController : MonoBehaviour
{
    private int enemiesKilled = 0; // Nombre d'ennemis tués
    public int enemiesRequiredForFullPower = 10; // Nombre d'ennemis requis pour charger complètement la barre
    public Slider powerBarSlider; // Référence à la barre de chargement (Slider UI)
    public Text powerBarText; // Référence au texte UI pour afficher le pourcentage

    void Start()
    {
        // Initialiser la barre de chargement
        UpdatePowerBar();
    }

    // Fonction pour augmenter le compteur d'ennemis tués
    public void EnemyKilled()
    {
        if (enemiesKilled < enemiesRequiredForFullPower)
        {
            enemiesKilled++;
            Debug.Log("Enemy killed. Current count: " + enemiesKilled);
            UpdatePowerBar();
        }
    }

    // Fonction pour mettre à jour la barre de chargement
    private void UpdatePowerBar()
    {
        // Calculer le pourcentage de la barre de chargement
        float powerPercentage = (float)enemiesKilled / enemiesRequiredForFullPower;
        powerBarSlider.value = powerPercentage;

        // Mettre à jour le texte de la barre de chargement
        if (powerBarText != null)
        {
            powerBarText.text = "Power: " + Mathf.RoundToInt(powerPercentage * 100) + "%";
        }
    }

    // Fonction pour réinitialiser le compteur d'ennemis tués et la barre de chargement
    public void ResetPowerBar()
    {
        enemiesKilled = 0;
        UpdatePowerBar();
    }
}
