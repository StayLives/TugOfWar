using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickedScript : MonoBehaviour
{

    public bool clickedIs = false;

    private void OnMouseDown(){
        clickedIs = true;
    }

    void OnMouseUp(){
        clickedIs = false;
    }

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    
    //    
    //        clickedIs = true;
    //    
    //}

    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    clickedIs = false;
    //}
}
