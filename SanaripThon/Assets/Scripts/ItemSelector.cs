using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelector : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI itemName;
    [SerializeField]
    private TextMeshProUGUI description; 
    [SerializeField]
    private Image icon; 
    
    public void UpdateDisplayUI(ItemData itemData)
    {
        itemName.text = itemData.ItemName;
        description.text = itemData.Description;
        icon.sprite = itemData.Icon;
    }
}