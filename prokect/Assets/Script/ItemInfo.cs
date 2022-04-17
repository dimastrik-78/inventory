using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemInfo : MonoBehaviour
{
    [HideInInspector] public Objects Item;
    private Image icon;
    public GameObject PanelItem;
    public Transform PanelItemT;
    private void OnMouseEnter()
    {
        PanelItem.SetActive(true);
        icon.sprite = Item.Icon;
        PanelItemT.GetChild(0).GetComponent<Text>().text = $"��������: {Item.ItemName}";
        PanelItemT.GetChild(1).GetComponent<Text>().text = $"�����: {Item.ItemCost}";
        PanelItemT.GetChild(3).GetComponent<Text>().text = Item.ItemType.ToString();
        PanelItemT.GetChild(4).GetComponent<Text>().text = $"�����������: {Item.ItemSpecial}";
    }
    private void OnMouseExit()
    {
        PanelItem.SetActive(false);
    }
}
