using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : Singleton<PlayerData>
{
    private int points = 100;
    private int colorVal;
    private bool hat = false;
    private bool shield = false;
    
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
        get => hat;
        set => hat = value;
    }

    //Save and Load here
}
