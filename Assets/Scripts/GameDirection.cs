using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirection : MonoBehaviour
{
    public Camera main;
    public Camera test;
    public GameObject gameUI;
    public CameraMovement change;
    public CameraChange ClickingCamera;
    public string transport = "main";
    // Start is called before the first frame update
    void Start()
    {
        main.gameObject.SetActive(false);
        gameUI.SetActive(false);
        test.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (change.switching is true)
        {
            main.gameObject.SetActive(true);
            gameUI.SetActive(true); 
            test.gameObject.SetActive(false);
           // Debug.Log("Camera has changed");
        }

        
    }

    public void EvidenceDisplay()
    {
      ClickingCamera.EvidenceDisplay();
    }


}
