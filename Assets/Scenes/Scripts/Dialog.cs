using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]

public class Dialog : MonoBehaviour
{

    private Queue<string> lines;
    public GameObject character;
    public Text Charname;
    public Text description;
    public bool end;
    private void Start()
    {
        lines = new Queue<string>();
        end = false;
    }

    public void StartDialogue(dialogue2 dialogue)
    {
       // character.SetActive(true); 
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
        Debug.Log("next dialogue");
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
        character.SetActive(false);
        end = true;
    }
}
