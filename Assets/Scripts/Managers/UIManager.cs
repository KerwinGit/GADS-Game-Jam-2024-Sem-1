using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject genCanvas;
    public Canvas dialogueCanvas;
    public GameObject journalCanvas;
    public GameObject holoCanvas;

    private void Start()
    {
        genCanvasActive();
    }

    public void genCanvasActive()
    {
        StartCoroutine(generalActive());
    }

    public void dialogueCanvasActive()
    {
        StartCoroutine(dialogueActive());
    }

    public void journalCanvasActive()
    {
        StartCoroutine(journalActive());
    }

    public void holoCanvasActive()
    {
        StartCoroutine(holoActive());
    }

    private IEnumerator generalActive()
    {        
        dialogueCanvas.enabled = false;
        journalCanvas.SetActive(false);
        holoCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        genCanvas.SetActive(true);
    }

    private IEnumerator dialogueActive()
    {
        genCanvas.SetActive(false);
        journalCanvas.SetActive(false);
        holoCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        dialogueCanvas.enabled = true;
    }

    private IEnumerator journalActive()
    {
        genCanvas.SetActive(false);
        dialogueCanvas.enabled = false;
        holoCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        journalCanvas.SetActive(true);
    }

    private IEnumerator holoActive()
    {
        genCanvas.SetActive(false);
        dialogueCanvas.enabled = false;
        journalCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        holoCanvas.SetActive(true);
    }
}
