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
        //RandomItem = Random.Range(0, 12);
        //Debug.Log(itemtype[1].Icon);
        //icon = itemtype[1].Icon;
        //icon.GetComponent<SpriteRenderer>();
        //icon.sprite = itemtype[1].Icon;
        //Debug.Log(RandomItem);
    }

    private void OnMouseEnter()
    {
        PanelItem.SetActive(true);

        //icon = itemtype[1].Icon;
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
//прошлая попытка;
//[HideInInspector] public ObjectsData Item;
//[HideInInspector] public Sprite icon;
//public GameObject PanelItem;
//public Transform PanelItemT;
//private void OnMouseEnter()
//{
//    PanelItem.SetActive(true);
//    //icon = Item.itemtype[1].Icon;
//    PanelItemT.GetChild(0).GetComponent<Text>().text = $"Name: {Item.itemtype[1].ItemName}";
//    PanelItemT.GetChild(1).GetComponent<Text>().text = $"Cost: {Item.itemtype[1].ItemCost}";
//    PanelItemT.GetChild(2).GetComponent<Text>().text = Item.itemtype[1].ItemType.ToString();
//    PanelItemT.GetChild(3).GetComponent<Text>().text = $"Special: {Item.itemtype[1].ItemSpecial}";

// ещё одна попытка
//[HideInInspector] public Objects Item;
//[HideInInspector] public Sprite icon;
//public GameObject PanelItem;
//public Transform PanelItemT;
//private void OnMouseEnter()
//{
//    PanelItem.SetActive(true);
//    //icon = Item.itemtype[1].Icon;
//    PanelItemT.GetChild(0).GetComponent<Text>().text = $"Name: {Item.ItemName}";
//    PanelItemT.GetChild(1).GetComponent<Text>().text = $"Cost: {Item.ItemCost}";
//    PanelItemT.GetChild(2).GetComponent<Text>().text = Item.ItemType.ToString();
//    PanelItemT.GetChild(3).GetComponent<Text>().text = $"Special: {Item.ItemSpecial}";

// 3 и лучшая по моему мнению
//public ObjectsData Item;
//[HideInInspector] public Sprite icon;
//private int num;
//public GameObject PanelItem;
//public Transform PanelItemT;
//private Object[] items;
//[HideInInspector] public Objects[] itemtype;
//private void Start()
//{
//    items = Resources.LoadAll("items", typeof(Objects));
//    itemtype = new Objects[items.Length];
//    for (int i = 0; i < items.Length; i++)
//    {
//        itemtype[i] = (Objects)items[i];
//    }
//}

//private void OnMouseEnter()
//{
//    PanelItem.SetActive(true);
//    Debug.Log(num);
//    PanelItemT.GetChild(0).GetComponent<Text>().text = $"Name: {itemtype[1].ItemName}";
//    PanelItemT.GetChild(1).GetComponent<Text>().text = $"Cost: {itemtype[1].ItemCost}";
//    PanelItemT.GetChild(2).GetComponent<Text>().text = itemtype[1].ItemType.ToString();
//    PanelItemT.GetChild(3).GetComponent<Text>().text = $"Special: {itemtype[1].ItemSpecial}";
//}