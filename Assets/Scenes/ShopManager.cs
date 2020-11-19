using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Button redColor;
    [SerializeField] private Button blueColor;
    [SerializeField] private Button greenColor;
    [SerializeField] private Button cyanColor;
    [SerializeField] private Button blackColor;
    
    [SerializeField] private Button hat;
    [SerializeField] private Button shield;

    public GameObject player;
    private GameObject text;
    PlayerData data = new PlayerData();
    public MeshRenderer[] playerColor;

    private void Start()
    {
        text = GameObject.FindGameObjectWithTag("Points");
        text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
    }

    public void RedColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            PlayerData.Instance.ColorVal = 1;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }
    
    public void BlueColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            PlayerData.Instance.ColorVal = 2;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }
    
    public void GreenColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            PlayerData.Instance.ColorVal = 3;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }
    
    public void CyanColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            PlayerData.Instance.ColorVal = 4;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }
    
    public void BlackColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            PlayerData.Instance.ColorVal = 5;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }

    public void Hat()
    {
        if (PlayerData.Instance.Points >= 50)
        {
            PlayerData.Instance.Hat = true;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 50;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }
    
    public void Shield()
    {
        if (PlayerData.Instance.Points >= 100)
        {
            PlayerData.Instance.Shield = true;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 100;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
            PlayerData.Instance.Save();
        }
    }
}
