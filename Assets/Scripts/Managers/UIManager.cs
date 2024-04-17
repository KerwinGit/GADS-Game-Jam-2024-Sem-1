using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject genCanvas;
    public Canvas dialogueCanvas;
    public GameObject journalCanvas;
    public GameObject holoCanvas;

    public void genCanvasActive()
    {
        genCanvas.SetActive(true);
        dialogueCanvas.enabled = false;
        journalCanvas.SetActive(false);
        holoCanvas.SetActive(false);
    }

    public void dialogueCanvasActive()
    {
        genCanvas.SetActive(false);
        dialogueCanvas.enabled = true;
        journalCanvas.SetActive(false);
        holoCanvas.SetActive(false);
    }

    public void journalCanvasActive()
    {
        genCanvas.SetActive(false);
        dialogueCanvas.enabled = false;
        journalCanvas.SetActive(true);
        holoCanvas.SetActive(false);
    }

    public void holoCanvasActive()
    {
        genCanvas.SetActive(false);
        dialogueCanvas.enabled = false;
        journalCanvas.SetActive(false);
        holoCanvas.SetActive(true);
    }
}
