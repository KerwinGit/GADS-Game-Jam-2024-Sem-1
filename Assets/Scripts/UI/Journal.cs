using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Journal : MonoBehaviour
{
    public List<Evidence> evidences = new List<Evidence>();

    public int innocentCount = 0;
    public int neutralCount;
    public int guiltyCount = 0;

    public int totalCount;
    public Slider guiltSlider;

    public Button innocentButton;
    public Button guiltyButton;
    private bool canInnocent = false;
    private bool canGuilty = false;

    private void Start()
    {
        totalCount = evidences.Count;
        neutralCount = totalCount;
        innocentButton.interactable = false;
        guiltyButton.interactable = false;
    }

    public void UpdateCount()
    {
        innocentCount = 0;
        neutralCount = 0;
        guiltyCount = 0;

        foreach (Evidence evidence in evidences)
        {
            switch (evidence.GetGuiltStatus())
            {
                case Evidence.GuiltStatus.innocent:
                    innocentCount++;
                    break;
                case Evidence.GuiltStatus.neutral:
                    neutralCount++;
                    break;
                case Evidence.GuiltStatus.guilty:
                    guiltyCount++;
                    break;
            }
        }

        guiltSlider.value = Mathf.Clamp(0.5f - (((float)guiltyCount/totalCount)*0.5f - ((float)innocentCount /totalCount)*0.5f), 0, 1);

        if(guiltSlider.value<0.25f)
        {
            guiltyButton.interactable = true;
            innocentButton.interactable = false;
        }
        else if (guiltSlider.value > 0.75f)
        {
            guiltyButton.interactable = false;
            innocentButton.interactable = true;
        }
        else
        {
            guiltyButton.interactable = false;
            innocentButton.interactable = false;
        }        
    }
    public void CloseJournal()
    {
        this.gameObject.SetActive(false);
    }
}
