using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ResolutionManager : MonoBehaviour
{
    public Dropdown resolutionDropdown;

    private Resolution[] customResolutions;

    void Start()
    {
        // Créer des résolutions personnalisées
        customResolutions = new Resolution[]
        {
            new Resolution { width = 1920, height = 1080,},
            new Resolution { width = 1600, height = 900,},
            new Resolution { width = 1280, height = 720,}
            // Ajoutez d'autres résolutions personnalisées si nécessaire
        };

        // Créer une liste d'options de résolution
        List<string> resolutionOptions = new List<string>();
        foreach (Resolution resolution in customResolutions)
        {
            resolutionOptions.Add(resolution.width + " x " + resolution.height);
        }

        // Ajouter les options au dropdown
        resolutionDropdown.ClearOptions();
        resolutionDropdown.AddOptions(resolutionOptions);

        // Gérer les événements de changement de résolution
        resolutionDropdown.onValueChanged.AddListener(SetResolution);
    }

    void SetResolution(int index)
    {
        if (index >= 0 && index < customResolutions.Length)
        {
            Resolution resolution = customResolutions[index];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        }
    }
}
