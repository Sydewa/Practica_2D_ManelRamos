using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            anim.SetBool("Explotar", true);
            GameManager.Instance.ContadorVidas();
            AudioManager.Instance.BombaSound();
        }
        
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }

}
