using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehavior : MonoBehaviour
{
    public bool IsChosen;
    public ItemData itemData;

    public TextMeshProUGUI textTitle;
    public TextMeshProUGUI textDescription;
    public Image buttonImage;
    public Image chosenFrameImage;

    public ItemBehavior[] otherOptions;

    
    
    private void Awake()
    {
        textTitle.text = itemData.ItemName;
        textDescription.text = itemData.Description;
        buttonImage.sprite = itemData.Icon;
    }

    public void SetActive()
    {
        IsChosen = true;
        textTitle.gameObject.SetActive(true);
        textDescription.gameObject.SetActive(true);
        chosenFrameImage.gameObject.SetActive(true);
        foreach (var option in otherOptions)
        {
            option.IsChosen = false;
            option.textTitle.gameObject.SetActive(false);
            option.textDescription.gameObject.SetActive(false);
            option.chosenFrameImage.gameObject.SetActive(false);
        }
    }
    
    
}
