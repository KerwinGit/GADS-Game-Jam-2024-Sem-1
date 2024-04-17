using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject defeatScreen;
    
    public void ShowVictory()
    {
        victoryScreen.SetActive(true);
    }

    public void ShowDefeat()
    {
        defeatScreen.SetActive(true);
    }

    public void RestartCase1()
    {
        SceneManager.LoadSceneAsync("Case1Court");
    }
    
    public void RestartCase2()
    {
        SceneManager.LoadSceneAsync("Case2Court");
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync("Case2Court");
    }
    
    public void onMainMenuClick()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
