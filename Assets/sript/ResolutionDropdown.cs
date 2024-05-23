using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ResolutionManager : MonoBehaviour
{
    public Dropdown resolutionDropdown;

    private Resolution[] customResolutions;

    void Start()
    {
        // Cr�er des r�solutions personnalis�es
        customResolutions = new Resolution[]
        {
            new Resolution { width = 1920, height = 1080,},
            new Resolution { width = 1600, height = 900,},
            new Resolution { width = 1280, height = 720,}
            // Ajoutez d'autres r�solutions personnalis�es si n�cessaire
        };

        // Cr�er une liste d'options de r�solution
        List<string> resolutionOptions = new List<string>();
        foreach (Resolution resolution in customResolutions)
        {
            resolutionOptions.Add(resolution.width + " x " + resolution.height);
        }

        // Ajouter les options au dropdown
        resolutionDropdown.ClearOptions();
        resolutionDropdown.AddOptions(resolutionOptions);

        // G�rer les �v�nements de changement de r�solution
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
