using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject levelSelectPanel;
    public GameObject howToPlayPanel;

    // Start is called before the first frame update
    void Start()
    {
        levelSelectPanel.SetActive(false);
        startPanel.SetActive(true);
        howToPlayPanel.SetActive(false);
    }

    public void PlayClick()
    {
        startPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }

    public void HowToPlayClick()
    {
        howToPlayPanel.SetActive(true);
        startPanel.SetActive(false);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Case1Court");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Case2Court");
    }

    // public void LoadLevel3()
    // {
    //     SceneManager.LoadScene(3);
    // }

    public void Back()
    {
        startPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
        howToPlayPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}



