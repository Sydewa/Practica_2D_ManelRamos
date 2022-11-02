using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    //Sonidos
    private AudioSource audioSource;
    public AudioClip bomba;
    public AudioClip estrella;
    
    void Awake()
    {
        // if la instancia de este script no es igual a nulo, y la instancia no es esta (refiriendose al primer srcipt game manager) me mato
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }  
        audioSource = GetComponent<AudioSource>();
    }
    
    public void BombaSound()
    {
        audioSource.PlayOneShot(bomba);
    }
    public void EstrellaSound()
    {
        audioSource.PlayOneShot(estrella);
    }
}
