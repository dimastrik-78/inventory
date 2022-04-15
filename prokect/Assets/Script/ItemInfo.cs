using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemInfo : MonoBehaviour
{
    [SerializeField] private Objects Item;
    [SerializeField] private Text Name;
    [SerializeField] private Text description;
    [SerializeField] private Image icon;
    [SerializeField] private Text Cost;
    [SerializeField] private Text Special;
    [SerializeField] private Text Type;
    public GameObject PanelItem;
    private void OnMouseEnter()
    {
        PanelItem.SetActive(true);
        Name.text = $"Название {Item.ItemName}";
        description.text = Item.ItemDescription;
        icon.sprite = Item.Icon;
        Cost.text = $"Стоит {Item.ItemCost}";
        Special.text = $"Униальность {Item.ItemSpecial}";
        Type.text = Item.ItemType.ToString();
    }
    private void OnMouseExit()
    {
        PanelItem.SetActive(false);
    }
}
