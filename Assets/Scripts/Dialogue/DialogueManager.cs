using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private List<dialogueData> dialogueDataList = new List<dialogueData>();
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Image emotionIcon;
    [SerializeField] private Sprite characterPortrait;
    [SerializeField] private Button option1Button;
    [SerializeField] private Button option2Button;
    [SerializeField] private Button option3Button;
    [SerializeField] private Button nextButton;


    private IEnumerator TypeDialogue(dialogueData dialogue) //helper hethod which types the dialogue to the ui
    {
        nextButton.interactable = false;

        nameText.text = dialogue.charName;
        dialogueText.text = "";
        characterPortrait = dialogue.charSprite;
        DisplayEmotionIcon(dialogue);
        foreach (char letter in dialogue.speech)
        {
            SFXManager.Instance.PlayAudio("dialog");
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f); // Add a slight delay for typing effect
        }

        nextButton.interactable = true;
    }

    private void DisplayEmotionIcon(dialogueData dialogue)
    {

    }
}

[System.Serializable]
public class dialogueData
{
    public bool isEnd;

    [Header("Displayed")]
    public string speech;
    public string charName;
    public Sprite charSprite;

    public enum EmotionEnum
    {
        normal,
        angry,
        questioning,
        shocked,
    }
    
    [Header("Branch")]
    public bool isQuestion;
    public string answerOption1;
    public string answerOption2;
    public string answerOption3;
    public int option1IndexJump;
    public int option2IndexJump;
    public int option3IndexJump;
}