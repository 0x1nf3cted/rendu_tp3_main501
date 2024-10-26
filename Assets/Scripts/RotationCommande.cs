using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCommande : MonoBehaviour
{
    public GameObject Rotation;  
    public string axe; 
    public int Sens = 1; 

    void Update()
    {
        float input = Input.GetAxis(axe); 
        EtatRotation rotationState = MoveStateForInput(input);  
        RotationControleur controller = Rotation.GetComponent<RotationControleur>(); 
        controller.rotationState = rotationState; 
    }

    // Détermine l'état de rotation basé sur l'entrée utilisateur et le sens
    EtatRotation MoveStateForInput(float input)
    {
        if (Sens == 1) // Sens de rotation normal
        {
            if (input > 0) 
            {
                return EtatRotation.Positif; // Retourne l'état Positif
            }
            else if (input < 0)  
            {
                return EtatRotation.Negatif; // Retourne l'état Négatif
            }
            else
            {
                return EtatRotation.Fixe; 
            }
        }
        else if (Sens == -1) 
        {
            if (input < 0) 
            {
                return EtatRotation.Positif; // Retourne l'état Positif
            }
            else if (input > 0)  
            {
                return EtatRotation.Negatif; // Retourne l'état Négatif
            }
            else
            {
                return EtatRotation.Fixe; 
            }
        }
        else  
        {
            return EtatRotation.Fixe; // Retourne l'état Fixe
        }
    }
}
