using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Save : MonoBehaviour
{
    private const string PATH = @"Assets\Resources\DataBase.txt";
    void Start()
    {
        if (!File.Exists(PATH))
            File.Create(PATH);
    }

    void Update()
    {
        
    }
}