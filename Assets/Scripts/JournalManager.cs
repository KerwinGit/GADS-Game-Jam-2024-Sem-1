using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JournalManager : MonoBehaviour
{
    public float totalGuilties;
    public float totalInnocents;
    public float guiltyPercentage;
    
    public GameObject journalMenu;
    public TMP_Text guiltyLikelyhood;
    public TMP_Text line1Text;
    public Toggle line1IBtn;
    public Toggle line1GBtn;
    public TMP_Text line2Text;
    public Toggle line2IBtn;
    public Toggle line2GBtn;

    void Start()
    {
        totalGuilties = 0;
        totalInnocents = 0;
        guiltyPercentage = 0;
    }

    void Update()
    {
        guiltyPercentage = (totalGuilties / (totalGuilties + totalInnocents)) * 100;
        guiltyLikelyhood.text = "" + guiltyPercentage + "%";
    }

    //all innocent presses
    public void onInnocent1Click()
    {
        if (line1GBtn.isOn == true && line1IBtn.isOn == true)
        {
            line1GBtn.isOn = false;
            line1IBtn.isOn = true;
            //totalGuilties = totalGuilties-1;
        }

        if (line1IBtn.isOn == true)
        {
            line1Text.color = Color.green;
            totalInnocents = totalInnocents+1;
        }

        if (line1IBtn.isOn == false)
        {
            line1Text.color = Color.white;
            totalInnocents = totalInnocents-1;
        }
    }

    public void onInnocent2Click()
    {
        if (line2GBtn.isOn == true && line2IBtn.isOn == true)
        {
            line2GBtn.isOn = false;
            line2IBtn.isOn = true;
            //totalGuilties = totalGuilties-1;
        }

        if (line2IBtn.isOn == true)
        {
            line2Text.color = Color.green;
            totalInnocents = totalInnocents+1;
        }

        if (line2IBtn.isOn == false)
        {
            line2Text.color = Color.white;
            totalInnocents = totalInnocents-1;
        }
    }

    //all guilty presses
    public void onGuilty1Click()
    {
        if (line1IBtn.isOn == true && line1GBtn.isOn == true)
        {
            line1IBtn.isOn = false;
            line1GBtn.isOn = true;
            //totalInnocents = totalInnocents-1;
        }
        

        if (line1GBtn.isOn == true)
        {
            line1Text.color = Color.red;
            totalGuilties = totalGuilties+1;
        }

        if (line1GBtn.isOn == false)
        {
            line1Text.color = Color.white;
            totalGuilties = totalGuilties-1;
        }
    }
    public void onGuilty2Click()
    {
        if (line2IBtn.isOn == true && line2GBtn.isOn == true)
        {
            line2IBtn.isOn = false;
            line2GBtn.isOn = true;
            //totalInnocents = totalInnocents-1;
        }
        

        if (line2GBtn.isOn == true)
        {
            line2Text.color = Color.red;
            totalGuilties = totalGuilties+1;
        }

        if (line2GBtn.isOn == false)
        {
            line2Text.color = Color.white;
            totalGuilties = totalGuilties-1;
        }
    }
}