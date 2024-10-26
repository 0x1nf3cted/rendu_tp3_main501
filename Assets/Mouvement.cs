using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Mouvement : MonoBehaviour
{
     void Start()
    {
        
    }

    // Méthode Update appelée une fois par frame pour gérer les entrées utilisateur
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Déplace l'objet vers le bas, vitesse dépendante de l'état de la touche Ctrl
            transform.Translate(Vector3.down * ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) ? 0.02f : 0.005f));
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {  
            // Déplace l'objet vers le haut, vitesse dépendante de l'état de la touche Ctrl
            transform.Translate(Vector3.up * ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) ? 0.02f : 0.005f));
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Fait tourner l'objet vers la gauche
            transform.Rotate(Vector3.forward, 0.5f);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Fait tourner l'objet vers la droite
            transform.Rotate(Vector3.forward, -0.5f);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            // Déplace l'objet en avant
            transform.Translate(Vector3.forward * 0.02f);
        }
    }
}
