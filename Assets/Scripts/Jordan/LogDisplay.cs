using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LogDisplay : MonoBehaviour
{
  public GameObject LogInScreen;
    public GameObject GameUI;
    //dialogue2 logs;
    bool isLogged;
    // Start is called before the first frame update
    void Start()
    {
        LogInScreen.SetActive(false);
    }

    // Update is called once per frame

    public void goBack()
    {
        LogInScreen.SetActive(false);
        GameUI.SetActive(true);
        isLogged = false;
    }


    public void Logon()
    {
        LogInScreen.SetActive(true);
        GameUI?.SetActive(false);
        isLogged = true;
    }
}
