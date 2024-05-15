using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform[] backgrounds; // Tableau des plans de fond � d�placer
    public float[] parallaxScales; // �chelle de parallaxe pour chaque plan
    public float smoothing = 1f; // Douceur du d�placement parallaxe

    private Transform cam; // R�f�rence � la transform de la cam�ra
    private Vector3 previousCamPos; // Position pr�c�dente de la cam�ra

    void Awake()
    {
        // R�cup�re la r�f�rence de la cam�ra
        cam = Camera.main.transform;
    }

    void Start()
    {
        // Initialise la position pr�c�dente de la cam�ra
        previousCamPos = cam.position;

        // Initialise les �chelles de parallaxe en fonction de la profondeur des plans de fond
        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    void Update()
    {
        // Pour chaque plan de fond
        for (int i = 0; i < backgrounds.Length; i++)
        {
            // Calcule le parallaxe (d�placement)
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

            // Calcule la nouvelle position cible du plan de fond
            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            // Calcule la nouvelle position interpol�e du plan de fond
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            // Applique l'effet de parallaxe avec une interpolation
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        // Met � jour la position pr�c�dente de la cam�ra
        previousCamPos = cam.position;
    }
}
