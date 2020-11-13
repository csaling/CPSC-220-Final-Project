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
    PlayerData data = new PlayerData();

    public void RedColor()
    {
        if (data.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    public void BlueColor()
    {
        if (data.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    public void GreenColor()
    {
        if (data.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    public void CyanColor()
    {
        if (data.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    public void BlackColor()
    {
        if (data.Points >= 10)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void Hat()
    {
        if (data.Points >= 50)
        {
            transform.GetChild(2).gameObject.SetActive(true);   
        }
    }
    
    public void Shield()
    {
        if (data.Points >= 100)
        {
            transform.GetChild(3).gameObject.SetActive(true);   
        }
    }
}
