using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : Singleton<PlayerData>
{
    private int points;
    private int colorVal;
    private bool hat = false;
    private bool shield = false;
    private String path;

    public int Points
    {
        get => points;
        set => points = value;
    }

    public int ColorVal
    {
        get => colorVal;
        set => colorVal = value;
    }

    public bool Hat
    {
        get => hat;
        set => hat = value;
    }
    
    public bool Shield
    {
        get => shield;
        set => shield = value;
    }

    public void Save()
    {
        path = Application.persistentDataPath + "/player.dat";
        SavingLoading sl = new SavingLoading();
        StreamWriter writer = new StreamWriter(path, false);
        sl.points = Points;
        sl.colorVal = ColorVal;
        sl.hat = Hat;
        sl.shield = Shield;
        string json = JsonUtility.ToJson(sl);
        writer.WriteLine(json);
        writer.Close();
    }

    public void Load()
    {
        path = Application.persistentDataPath + "/player.dat";
        String info;
        if (File.Exists(path))
        {
            Debug.Log("Worked!");
            StreamReader reader = new StreamReader(path);
            info = reader.ReadToEnd();
            SavingLoading myObject = JsonUtility.FromJson<SavingLoading>(info);
            reader.Close();
            
            points = myObject.points;
            colorVal = myObject.colorVal;
            hat = myObject.hat;
            shield = myObject.shield;
        }
    }
}

[Serializable]
class SavingLoading
{
    public int points;
    public int colorVal;
    public bool hat = false;
    public bool shield = false;
}
