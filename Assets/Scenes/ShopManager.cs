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

    private void Start()
    {
        text = GameObject.FindGameObjectWithTag("Points");
    }

    public void RedColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }
    
    public void BlueColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.blue;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }
    
    public void GreenColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.green;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }
    
    public void CyanColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.cyan;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }
    
    public void BlackColor()
    {
        if (PlayerData.Instance.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.black;
            PlayerData.Instance.Points = PlayerData.Instance.Points - 10;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }

    public void Hat()
    {
        if (PlayerData.Instance.Points >= 50)
        {
            transform.GetChild(2).gameObject.SetActive(true);
            PlayerData.Instance.Points = PlayerData.Instance.Points - 50;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }
    
    public void Shield()
    {
        if (PlayerData.Instance.Points >= 100)
        {
            transform.GetChild(3).gameObject.SetActive(true);
            PlayerData.Instance.Points = PlayerData.Instance.Points - 100;
            text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        }
    }
}
