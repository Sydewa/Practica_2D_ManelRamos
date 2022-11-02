using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameMenuManager : MonoBehaviour
{
   public static GameMenuManager Instance;
   
   
   public GameObject title;
   public GameObject mainButtons;
   public GameObject optionsMenu;

   public string nivel1;
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
    }

   public void OpenOptions()
   {
        // hi
        title.SetActive(false);
        mainButtons.SetActive(false);
        optionsMenu.SetActive(true);
   }

   public void PlayButton()
   {
        SceneManager.LoadScene(nivel1);
   }

     public void MainMenu()
     {
          SceneManager.LoadScene("MainMenu");
     }


}
