using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : Singleton<PlayerData>
{
    private int points = 0;
    
    public int Points
    {
        get => points;
        set => points = value;
    }
}
