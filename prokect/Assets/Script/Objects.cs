using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemsTypes", menuName = "New item", order = 51)]
public class Objects : ScriptableObject
{
    public enum ItemsTypes { Armor, Sword, Bow, Staff, Material, Consumable };
    [SerializeField] private ItemsTypes itemsTypes;
    [SerializeField] private Sprite icon;
    [SerializeField] private string itemName;
    [SerializeField] private int itemCost;
    [SerializeField] private int itemSpecial;
    public string ItemName
    {
        get
        {
            return itemName;
        }
    }
    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public int ItemCost
    {
        get
        {
            return itemCost;
        }
    }

    public int ItemSpecial
    {
        get
        {
            return itemSpecial;
        }
    }
    public ItemsTypes ItemType
    {
        get
        {
            return itemsTypes;
        }
    }
}