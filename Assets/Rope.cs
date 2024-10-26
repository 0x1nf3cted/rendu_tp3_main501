using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public float heightChangeAmount = 0.1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            IncreaseHeight(); 
        }
        
        else if (Input.GetKeyDown(KeyCode.L))
        {
            DecreaseHeight(); 
        }
    }

    // Méthode pour augmenter la hauteur de l'objet
    void IncreaseHeight()
    {
        Vector3 scale = transform.localScale; 
        scale.y += heightChangeAmount; 
        transform.localScale = scale; 
    }

    // Méthode pour diminuer la hauteur de l'objet
    void DecreaseHeight()
    {
        Vector3 scale = transform.localScale; 
        if (scale.y > heightChangeAmount) 
        {
            scale.y -= heightChangeAmount;
            transform.localScale = scale; 
        }
    }
}
