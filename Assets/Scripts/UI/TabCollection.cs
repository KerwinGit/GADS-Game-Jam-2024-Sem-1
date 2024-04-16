using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class TabCollection : MonoBehaviour
{
    public List<TabButton> tabs;

    public Sprite idle;
    public Sprite hovered;
    public Sprite selected;

    public TabButton selectedTab;

    public List<GameObject> tabPanels;

    public void Subscribe(TabButton button)
    {
        if(tabs == null)
        {
            tabs = new List<TabButton>();
        }

        tabs.Add(button);
    }

    public void OnTabEntered(TabButton tab)
    {
        ResetTabs();

        if (selectedTab == null || tab != selectedTab)
        tab.bgImage.sprite = hovered;
    }

    public void OnTabExited(TabButton tab)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton tab)
    {
        selectedTab = tab;
        ResetTabs();
        tab.bgImage.sprite = selected;
        
        int tabIndex = tab.transform.GetSiblingIndex();
        for(int i = 0; i < tabPanels.Count; i++) 
        {
            if(i == tabIndex)
            {
                tabPanels[i].SetActive(true);
            }
            else
            {
                tabPanels[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach(TabButton tab in tabs)
        {
            if(selectedTab != null && tab == selectedTab) { continue; }
            tab.bgImage.sprite = idle;
        }
    }
}
