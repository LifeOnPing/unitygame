using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class RuntimeText: MonoBehaviour
{
    public Object_Placement ObjectPlacement;

    /*[MenuItem("Tools/Write file")]
    public static void WriteString()
    {
        string path = Directory.GetCurrentDirectory() + "/Assets/Beatmaps";
        Directory.CreateDirectory(path);
        path += "/lvl.txt";
        //System.Windows.Forms.MessageBox.Show("My message here");


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

    [MenuItem("Tools/Test")]
    public static void Test()
    {
        string path = EditorUtility.OpenFolderPanel("Save map", "", "");
        print(path);
        path += "/lvl.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine((float)ObjectPlacement.ComboBoostPlacement[0].x);
        writer.Close();
    }*/
}