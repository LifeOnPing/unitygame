﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class RuntimeText: MonoBehaviour
{
    [MenuItem("Tools/Write file")]
    public static void WriteString()
    {
        string path = Directory.GetCurrentDirectory() + "/Assets/Beatmaps";
        Directory.CreateDirectory(path);
        path += "/lvl.txt";
        System.Windows.Forms.MessageBox.Show("My message here");  make it use the save as prompt


        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
        writer.Close();
        
        StreamReader reader = new StreamReader(path);
        //Print the text from the file
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    [MenuItem("Tools/Read file")]
    public static void ReadString()
    {
        string path = Application.persistentDataPath + "/test.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}
