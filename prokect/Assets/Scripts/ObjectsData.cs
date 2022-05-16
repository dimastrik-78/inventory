using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ObjectsData : MonoBehaviour
{
    public Transform canvas;
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
            RandomNum = Random.Range(0, 12);
            Iitem[InventoryLen].GetComponent<Image>().sprite = itemtype[RandomNum].Icon;
            InventoryLen++;
        }
    }
    public void reset()
    {
        SceneManager.LoadScene(0);
    }
}
