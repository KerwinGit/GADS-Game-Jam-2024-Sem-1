using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Evidence : MonoBehaviour
{
    public TMP_Text evidenceText;

    public Toggle innocent;
    public Toggle neutral;
    public Toggle guilty;

    public enum GuiltStatus
    {
        innocent,
        neutral,
        guilty
    }

    private GuiltStatus guiltStatus = GuiltStatus.neutral;

    public void OnInnocentClick()
    {
        if (innocent.isOn)
        {
            neutral.isOn = false;
            guilty.isOn = false;

            innocent.interactable = false;
            neutral.interactable = true;
            guilty.interactable = true;

            guiltStatus = GuiltStatus.innocent;

            evidenceText.color = Color.green;
        }        
    }
    public void OnNeutralClick()
    {
        if (neutral.isOn)
        {
            innocent.isOn = false;
            guilty.isOn = false;

            innocent.interactable = true;
            neutral.interactable = false;
            guilty.interactable = true;

            guiltStatus = GuiltStatus.neutral;

            evidenceText.color = Color.black;
        }        
    }

    public void OnGuiltyClick()
    {
        if (guilty.isOn)
        {
            innocent.isOn = false;
            neutral.isOn = false;

            innocent.interactable = true;
            neutral.interactable = true;
            guilty.interactable = false;

            guiltStatus = GuiltStatus.guilty;

            evidenceText.color = Color.red;
        }        
    }

    public GuiltStatus GetGuiltStatus()
    {
        return guiltStatus;
    }

}
