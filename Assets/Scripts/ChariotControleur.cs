using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatChariot { Fixe = 0, Positif = 1, Negatif = -1 };

public class ChariotControleur : MonoBehaviour
{
    public EtatChariot translationEtat = EtatChariot.Fixe; 
    public float vitesse = 1.0f;  

    // Méthode FixedUpdate appelée à une fréquence fixe, utilisée pour la physique
    private void FixedUpdate()
    {
        // Vérifie si le chariot n'est pas dans l'état fixe
        if (translationEtat != EtatChariot.Fixe)
        {
            ArticulationBody articulation = GetComponent<ArticulationBody>(); 

            float xDrivePostion = articulation.jointPosition[0];  
            Debug.Log(xDrivePostion);  

            float targetPosition = xDrivePostion + (float)translationEtat * Time.fixedDeltaTime * vitesse;

            var drive = articulation.xDrive; 
            drive.target = targetPosition;  
            articulation.xDrive = drive;  
        }
    }
}
