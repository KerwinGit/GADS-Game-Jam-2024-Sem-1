using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject LevelSelectPanel;

    // Start is called before the first frame update
    void Start()
    {
        LevelSelectPanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    public void PlayClick()
    {
        StartPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void Back()
    {
        StartPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}



