using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject defeatScreen;

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex!=0)
        {
            StartCoroutine(CrowdChatter());
        }
    }

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
        SceneManager.LoadSceneAsync(1);
    }
    
    public void RestartCase2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(2);
    }
    
    public void onMainMenuClick()
    {
        SceneManager.LoadSceneAsync(0);
    }

    private IEnumerator CrowdChatter()
    {
        SFXManager.Instance.PlayAudio("crowd");
        yield return new WaitForSeconds(1);
        SFXManager.Instance.PlayAudio("gavel");
        StopCoroutine(CrowdChatter());
    }

    public void playGasp()
    {
        SFXManager.Instance.PlayAudio("gasp");
    }
    public void playGavel()
    {
        SFXManager.Instance.PlayAudio("gavel");
    }
    public void playPage()
    {
        SFXManager.Instance.PlayAudio("page");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
