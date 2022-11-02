using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int vidas = 3;
    public static int estrellasNum = 0;

    //Contador de vidas del canvas y cosas canvas
    public Text estrellas;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject YouLost;
    public GameObject YouWon;

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

        DontDestroyOnLoad(this);
        YouLost.SetActive(false);
        YouWon.SetActive(false);
        vidas = 3;
        estrellasNum = 0;
    }
   
    public void ContadorVidas()
    {
        vidas --;
        if(vidas == 2)
        {
            vida3.SetActive(false);
        }
        else if(vidas == 1)
        {
            vida2.SetActive(false);
        }
        else if(vidas == 0)
        {
            vida1.SetActive(false);
            YouLost.SetActive(true);
            PlayerMovement.Instance.Stop();
        }
        else if(vidas == 3)
        {
            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);
        }
    }
    public void SumarEstrellas()
    {
        estrellasNum ++;
        estrellas.text = estrellasNum.ToString();
        if(estrellasNum == 4)
        {
            PlayerMovement.Instance.Stop();
            YouWon.SetActive(true);
        }
    }


}
