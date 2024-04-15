using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    bool Menu;
    bool Starting;
   public GameObject MenuSc;
   public  GameObject StartSc;

        
    // Start is called before the first frame update
    void Start()
    {
        Menu = false;
        Starting = true;
        MenuSc.SetActive(false);
        StartSc.SetActive(true);

    }

    // Update is called once per frame
   /* void Update()
    {
        if (Menu is true && Starting is false)
        {
            
            LoadGame();
            Back();
        }

        else
        {
            MenuClick();
        }
    }*/

   public void MenuClick()
    {
       
        StartSc.SetActive(false);
        MenuSc.SetActive(true);
        Starting = false;
        Menu = true;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Back()
    {
        StartSc.SetActive(true);
        MenuSc.SetActive(false);
        Starting = true;
        Menu = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

   

