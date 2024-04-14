using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabCollection tabColl;

    public Image bgImage;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabColl.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabColl.OnTabEntered(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabColl.OnTabExited(this);
    }

    private void Start()
    {
        bgImage = GetComponent<Image>();

        tabColl.Subscribe(this);
    }


}
