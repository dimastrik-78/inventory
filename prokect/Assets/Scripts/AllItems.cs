using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemsTypes", menuName = "New item", order = 51)]
public class AllItems : ScriptableObject
{
    public enum ItemsTypes { Armor, Sword, Bow, Staff, Material, Consumable };
    [SerializeField] private ItemsTypes itemsTypes;
    [SerializeField] private Sprite icon;
    [SerializeField] private string itemName;
    [SerializeField] private int itemCost;
    [SerializeField] private int itemSpecial;
    public ItemsTypes ItemType => itemsTypes;
    public Sprite Icon => icon;
    public string ItemName => itemName;
    public int ItemSpecial => itemSpecial;
    public int ItemCost => itemCost;
}