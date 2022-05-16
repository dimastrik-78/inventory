using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemInfo : MonoBehaviour
{
    [HideInInspector] public int RandomItem;
    private Object[] items;
    [HideInInspector] public Objects[] itemtype;
    public ObjectsData Item;
    public GameObject PanelItem;
    public Transform PanelItemT;
    private void Start()
    {
        items = Resources.LoadAll("items", typeof(Objects));
        itemtype = new Objects[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            itemtype[i] = (Objects)items[i];
        }
        RandomItem = Item.RandomNum;
    }
    private void OnMouseEnter()
    {
        PanelItem.SetActive(true);
        PanelItemT.GetChild(0).GetComponent<Text>().text = $"Name: {itemtype[RandomItem].ItemName}";
        PanelItemT.GetChild(1).GetComponent<Text>().text = $"Cost: {itemtype[RandomItem].ItemCost}";
        PanelItemT.GetChild(2).GetComponent<Text>().text = $"Type: {itemtype[RandomItem].ItemType.ToString()}";
        PanelItemT.GetChild(3).GetComponent<Text>().text = $"Special: {itemtype[RandomItem].ItemSpecial}";
    }
    private void OnMouseExit()
    {
        PanelItem.SetActive(false);
    }
}
