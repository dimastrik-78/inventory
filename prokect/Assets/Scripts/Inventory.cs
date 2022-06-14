using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Inventory : MonoBehaviour
{
    public Transform canvas;
    public GameObject[] ArrayImageItem;
    public ItemInfo[] ItemInfo;

    [HideInInspector] public AllItems[] itemtype;
    [HideInInspector] public int RandomNum;
    [HideInInspector] public int LocateNum;
    [HideInInspector][SerializeField] public int[,] SelectImageItem;

    private Object[] items;

    SaveData saveData;

    private const string PATH = @"Assets\Resources\DataBase.txt";
    private void Start()
    {
        items = Resources.LoadAll("items", typeof(AllItems));
        itemtype = new AllItems[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            itemtype[i] = (AllItems)items[i];
        }

        SelectImageItem = new int[ArrayImageItem.Length, 2];

        saveData = new SaveData();

        if (!File.Exists(PATH))
        {
            File.Create(PATH);

            saveData.ActiveImageItem = new int[SelectImageItem.GetLength(0)];
            saveData.ActiveItem = new int[SelectImageItem.GetLength(0)];

            for (int i = 0; i < SelectImageItem.GetLength(0); i++)
            {
                SelectImageItem[i, 0] =  -1;
                SelectImageItem[i, 1] =  -1;
            }
        }
        else
        {
            string jsonStr = File.ReadAllText(PATH);
            saveData = JsonUtility.FromJson<SaveData>(jsonStr);

            for (int i = 0; i < ArrayImageItem.Length; i++)
            {
                SelectImageItem[i, 0] = saveData.ActiveImageItem[i];
                SelectImageItem[i, 1] = saveData.ActiveItem[i];

                if (saveData.ActiveImageItem[i] != -1)
                {
                    ArrayImageItem[i].SetActive(true);

                    ItemInfo[i].InstallingItem(SelectImageItem[i, 1], SelectImageItem[i, 0]);
                    ItemInfo[i].GetComponent<Image>().sprite = itemtype[SelectImageItem[i, 1]].Icon;

                }
            }
        }
    }
    public void DeletItem()
    {
        ArrayImageItem[LocateNum].SetActive(false);

        SelectImageItem[LocateNum, 0] = -1;
        SelectImageItem[LocateNum, 1] = -1;

        SaveData();
    }
    public void OpenChest()
    {
        RandomNum = Random.Range(1, 20);
        if (RandomNum == 1)
        {
            for (int i = 0; i < ArrayImageItem.Length; i++)
            {
                ArrayImageItem[i].SetActive(false);
                for (int j = 0; j < SelectImageItem.GetLength(0); j++)
                {
                    SelectImageItem[j, 0] = -1;
                    SelectImageItem[j, 1] = -1;
                }
            }
        }
        else 
        {
            for (int i = 0; i < ArrayImageItem.Length; i++)
            {
                if (!ArrayImageItem[i].activeSelf)
                {
                    ArrayImageItem[i].SetActive(true);

                    RandomNum = Random.Range(0, 12);

                    SelectImageItem[i, 0] = i;
                    SelectImageItem[i, 1] = RandomNum;

                    ItemInfo[i].InstallingItem(SelectImageItem[i, 1], SelectImageItem[i, 0]);
                    ItemInfo[i].GetComponent<Image>().sprite = itemtype[RandomNum].Icon;

                    break;
                }
            }
        }
        SaveData();
    }
    public void HungryChest()
    {
        for (int i = 0; i < ArrayImageItem.Length; i++)
        {
            RandomNum = Random.Range(1, 11);
            if (RandomNum >= 1 && RandomNum <= 3)
            {
                ArrayImageItem[i].SetActive(false);

                SelectImageItem[i, 0] = -1;
                SelectImageItem[i, 1] = -1;
            }
        }
        SaveData();
    }
    private void SaveData()
    {
        for (int i = 0; i < SelectImageItem.GetLength(0); i++)
        {
            saveData.ActiveImageItem[i] = SelectImageItem[i, 0];
            saveData.ActiveItem[i] = SelectImageItem[i, 1];
        }

        string DataStr = JsonUtility.ToJson(saveData);
        File.WriteAllText(PATH, DataStr);
    }
}
