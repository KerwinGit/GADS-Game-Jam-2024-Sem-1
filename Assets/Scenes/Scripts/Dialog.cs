using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]

public class Dialog : MonoBehaviour
{

    private Queue<string> lines;
    public List<string> login;
    public GameObject character;
    public Text Charname;
    public string nameDisplay;
    string colon = ":";
    public Text description;
    public int counter = 0;
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
        nameDisplay = dialogue.name + colon;
        lines.Clear();
        
        foreach (string sentence in dialogue.sentences)
        {
          lines.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        //Debug.Log("next dialogue");
        if(lines.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = lines.Dequeue();
       // Debug.Log(sentence);
       description.text = sentence;
        login.Add(sentence);
        counter += 1;
        
    }

    void EndDialogue()
    {
        character.SetActive(false);
        end = true;
        counter = 0;
    }
}
