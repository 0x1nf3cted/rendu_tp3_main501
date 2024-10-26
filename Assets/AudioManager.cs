using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource Music; // Source audio pour la musique de fond
    public AudioSource sfx;   // Source audio pour les effets sonores

    [Header("---------- Audio clip ----------------")]
    public AudioClip background; 
    public AudioClip truck;      

    void Start()
    {
        if (background != null)  
        {
            Music.clip = background; // Assigne le clip de fond à la source musicale
            Music.loop = true;       // Définit la musique pour qu'elle se répète
            Music.Play();            // Démarre la lecture de la musique de fond
        }
    }

    // Méthode pour jouer un effet sonore
    public void PlaySfx()
    {
        sfx.PlayOneShot(truck); // Joue l'effet sonore de camion une seule fois
    }
}
