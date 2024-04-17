using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private List<dialogueData> dialogueDataList = new List<dialogueData>();

    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text tagText;
    [SerializeField] private SpriteRenderer characterPortrait;

    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private Button option1Button;
    [SerializeField] private Button option2Button;
    [SerializeField] private Button option3Button;
    [SerializeField] private Button nextButton;
    [SerializeField] private Button backButton;

    [SerializeField] private TMP_Text log1;
    [SerializeField] private TMP_Text log2;
    [SerializeField] private TMP_Text log3;

    [SerializeField] private GameObject defaultIcon;
    [SerializeField] private GameObject exclaimIcon;
    [SerializeField] private GameObject questionIcon;
    [SerializeField] private GameObject angerIcon;

    private int currentDialogueIndex = 0;
    private bool started = false;
    [SerializeField] private int branchIndex;

    
    public void ContinueClicked()
    {
        if(currentDialogueIndex < dialogueDataList.Count)
        {
            dialogueData nextDialogue = dialogueDataList[currentDialogueIndex];

            if(nextDialogue.isQuestion)
            {
                StartCoroutine(TypeDialogue(nextDialogue));                
            }
            else
            {
                StartCoroutine(TypeDialogue(nextDialogue));
            }
        }
    }

    public void DialogueStart()
    {
        if (!started)
        {
            ContinueClicked();
            started = true;
        }
    }

    private IEnumerator TypeDialogue(dialogueData dialogue) //helper hethod which types the dialogue to the ui
    {
        nextButton.interactable = false;
        backButton.interactable = false;

        nameText.text = dialogue.charName;
        tagText.text = dialogue.tagText;
        dialogueText.text = "";
        characterPortrait.sprite = dialogue.charSprite;
        DisplayEmotionIcon(dialogue);

        foreach (char letter in dialogue.speech)
        {
            //SFXManager.Instance.PlayAudio("dialog");
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f); // Add a slight delay for typing effect
        }

        nextButton.interactable = true;
        backButton.interactable = true;

        currentDialogueIndex++;

        if(dialogue.isQuestion)
            optionsPanel.gameObject.SetActive(true);

        if (dialogue.isEnd)
        {
            if(!option1Button.interactable && !option2Button.interactable && !option3Button.interactable)
            {
                StopDialogue();
            }
            else
            {
                currentDialogueIndex = branchIndex;
            }
        }
    }

    private void StopDialogue()
    {
        currentDialogueIndex = 11;
        nextButton.enabled = false;
    }

    private void DisplayEmotionIcon(dialogueData dialogue)
    {
        switch(dialogue.emotion)
        {
            case dialogueData.EmotionEnum.normal:
                defaultIcon.SetActive(true);
                exclaimIcon.SetActive(false);
                questionIcon.SetActive(false);
                angerIcon.SetActive(false);
                break;
            case dialogueData.EmotionEnum.angry:
                defaultIcon.SetActive(false);
                exclaimIcon.SetActive(false);
                questionIcon.SetActive(false);
                angerIcon.SetActive(true);
                break;
            case dialogueData.EmotionEnum.questioning:
                defaultIcon.SetActive(false);
                exclaimIcon.SetActive(false);
                questionIcon.SetActive(true);
                angerIcon.SetActive(false);
                break;
            case dialogueData.EmotionEnum.shocked:
                defaultIcon.SetActive(false);
                exclaimIcon.SetActive(true);
                questionIcon.SetActive(false);
                angerIcon.SetActive(false);
                break;
        }
    }

    public void DisableOptions()
    {
        optionsPanel.gameObject.SetActive(false);
    }

    public void SelectOption(int indexAnswer)
    {
        switch(indexAnswer)
        {
            case 2:
                option1Button.interactable = false;
                log1.enabled = true;
                break;
            case 5:
                option2Button.interactable = false;
                log2.enabled = true;
                break;
            case 8:
                option3Button.interactable = false;
                log3.enabled = true;
                break;
        }

        DisableOptions();

        currentDialogueIndex = indexAnswer;

        ContinueClicked();
    }
}

[System.Serializable]
public class dialogueData
{
    public bool isEnd;

    [Header("Displayed")]
    [TextArea(3, 10)]
    public string speech;    
    public string charName;
    public string tagText;
    public Sprite charSprite;

    public enum EmotionEnum
    {
        normal,
        angry,
        questioning,
        shocked
    }

    public EmotionEnum emotion;
    
    [Header("Branch")]
    public bool isQuestion;
    public int option1IndexJump;
    public int option2IndexJump;
    public int option3IndexJump;
}