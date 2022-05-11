using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ObjectsData : MonoBehaviour
{
    public Transform canvas;
    //[SerializeField] private GameObject itemPrefab;
    public GameObject[] ArrayImageItem;
    public ItemInfo[] Iitem;
    [HideInInspector] public int RandomNum;
    private int InventoryLen = 0;
    private Object[] items;
    [HideInInspector] public Objects[] itemtype;
    private void Start()
    {
        items = Resources.LoadAll("items", typeof(Objects));
        itemtype = new Objects[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            itemtype[i] = (Objects)items[i];
        }
    }
    public void OpenChest()
    {
        if (InventoryLen < 21)
        {
            ArrayImageItem[InventoryLen].SetActive(true);
            //Iitem.GetComponent<ItemInfo>();
            RandomNum = Random.Range(0, 12);

            //Debug.Log("ran = " + ran);
            //Instantiate(itemPrefab, canvas.GetChild(0));
            //canvas.GetChild(0).GetChild(InventoryLen).GetComponent<GameObject>().SetActive(true);

            //Iitem.Item = itemtype[ran];




            Iitem[InventoryLen].GetComponent<Image>().sprite = itemtype[RandomNum].Icon;
            //Iitem. = itemtype[1].Icon;
            //Iitem = itemtype[1].ItemName;
            //Iitem = itemtype[1].name;
            //Iitem = itemtype[1].ItemType;
            //Iitem = itemtype[1].ItemSpecial;
            //Iitem.icon = itemtype[1].Icon;
            //Iitem.Item = itemtype[ran];


            InventoryLen++;
        }
    }
    public void reset()
    {
        SceneManager.LoadScene(0);
    }
    //[SerializeField] private GameObject itemPrefab;
    //private int howManyItemsCreated = 0;
    //private int rnd;
    //[Range(1, 10)]
    //[SerializeField] private int howManyItems;
    //private Object[] itemDataHelp;
    //[HideInInspector] public Objects[] itemData;

    //private void Start()
    //{
    //    itemDataHelp = Resources.LoadAll("Items", typeof(Objects));
    //    itemData = new Objects[itemDataHelp.Length];
    //    for (int i = 0; i < itemDataHelp.Length; i++)
    //    {
    //        itemData[i] = (Objects)itemDataHelp[i];
    //    }
    //}

    //public void OpenChaest()
    //{
    //    if (howManyItemsCreated < howManyItems)
    //    {
    //        rnd = Random.Range(0, 10);
    //        itemPrefab.GetComponent<Image>().sprite = itemData[rnd].Icon;
    //        Instantiate(itemPrefab, transform.GetChild(0));
    //        ItemInfo.whereToPutDataSaver = itemData[rnd];
    //        howManyItemsCreated++;
    //    }
    //}
}