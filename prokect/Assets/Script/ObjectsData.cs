using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectsData : MonoBehaviour
{
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
