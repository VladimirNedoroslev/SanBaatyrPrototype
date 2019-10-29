using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool ButtonIsPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        ButtonIsPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ButtonIsPressed = false;

    }
}
