using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirection : MonoBehaviour
{
    public Camera main;
    public Camera test;
    public GameObject gameUI;
    public GameObject evidienceUI;
    public GameObject suspectUI;
    public CameraMovement change;
    public CameraChange ClickingCamera;
    //public string transport;
    bool gameUIdisplay;
    // Start is called before the first frame update
    void Start()
    {
        main.gameObject.SetActive(false);
        gameUI.SetActive(false);
        evidienceUI.SetActive(false);
        suspectUI.SetActive(false);
        test.gameObject.SetActive(true);
        gameUIdisplay = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (change.switching)
        {
            main.gameObject.SetActive(true);
            test.gameObject.SetActive(false);
           // Debug.Log("working");
            if (change.UiSwitching)
            {
                gameUI.SetActive(true);
            }
            //ClickingCamera.movement = "main";

            
            // Debug.Log("Camera has changed");
        }
        
        
      

     /*   switch (ClickingCamera.movement)
        {
            case "main":  gameUI.SetActive(true); break;
            default: gameUI.SetActive(false); break;

        } */
        
    }

    public void EvidenceDisplay()
    {
      ClickingCamera.EvidenceDisplay();
        //test.gameObject.SetActive(false);
        gameUI.SetActive(false);
        evidienceUI.SetActive(true);
        change.UiSwitching = false;


    }

    public void BacktoMain()
    {
        ClickingCamera.MainCamera();
        gameUI.SetActive(true);
        evidienceUI.SetActive(false);
    }


    public void SuspectDisplay()
    {
        ClickingCamera.SuspectDisplay();
        gameUI.SetActive(false);
        suspectUI.SetActive(true);
        change.UiSwitching = false;
    }

    public void BackToMain2()
    {
        ClickingCamera.MainCamera2();
        gameUI.SetActive(true);
        suspectUI.SetActive(false);
    }

}
