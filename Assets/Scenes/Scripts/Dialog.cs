using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]

public class Dialog : MonoBehaviour
{

    private Queue<string> lines;
    public Text Charname;
    public Text description;
    private void Start()
    {
        lines = new Queue<string>();
    }

    public void StartDialogue(dialogue2 dialogue)
    {
        //Debug.Log("working");
        Charname.text = dialogue.name;
        lines.Clear();
        
        foreach (string sentence in dialogue.sentences)
        {
          lines.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(lines.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = lines.Dequeue();
       // Debug.Log(sentence);
       description.text = sentence;
    }

    void EndDialogue()
    {

    }
}
