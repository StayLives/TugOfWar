using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickedScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool clickedIs = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        clickedIs = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        clickedIs = false;
    }
}
