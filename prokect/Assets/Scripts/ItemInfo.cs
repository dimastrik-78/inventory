using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    [HideInInspector] public AllItems[] itemtype;
    [HideInInspector] public int SelectItem;
    [HideInInspector] public int LocationItem;
    //[HideInInspector] public GameObject ImageObj;

    public Inventory Item;
    public GameObject PanelItem;
    public Transform PanelItemT;

    private Object[] _objectItem;
    private Text _name;
    private Text _cost;
    private Text _type;
    private Text _special;

    private void Start()
    {
        //ImageObj = GetComponent<GameObject>();
        _name = PanelItemT.GetChild(0).GetComponent<Text>();
        _cost = PanelItemT.GetChild(1).GetComponent<Text>();
        _type = PanelItemT.GetChild(2).GetComponent<Text>();
        _special = PanelItemT.GetChild(3).GetComponent<Text>();
    }
    private void OnMouseUp()
    {
        PanelItem.SetActive(true);
        _name.text = $"Name: {itemtype[SelectItem].ItemName}";
        _cost.text = $"Cost: {itemtype[SelectItem].ItemCost}";
        _type.text = $"Type: {itemtype[SelectItem].ItemType}";
        _special.text = $"Special: {itemtype[SelectItem].ItemSpecial}";
        Item.LocateNum = LocationItem;
    }
    public void InstallingItem(int Item, int Locate)
    {
        _objectItem = Resources.LoadAll("items", typeof(AllItems));
        itemtype = new AllItems[_objectItem.Length];
        for (int i = 0; i < _objectItem.Length; i++)
        {
            itemtype[i] = (AllItems)_objectItem[i];
        }
        SelectItem = Item;
        LocationItem = Locate;
    }
}
