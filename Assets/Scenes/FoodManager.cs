using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class FoodManager : MonoBehaviour
{
    PlayerData data = new PlayerData();
    private Vector2 originalLatLng = new Vector2(0,0);
    private Vector2 newLatLng = new Vector2(0,0);
    private GameObject text;

    private void Start()
    {
        originalLatLng = transform.position;
        text = GameObject.FindGameObjectWithTag("Points");
    }

    public void Update()
    {
        removeFood();
    }

    public void OnMouseDown()
    {
        PlayerData.Instance.Points++;
        text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
        Destroy(gameObject);
    }

    public void removeFood()
    {
        newLatLng = transform.position;

        if (newLatLng.y < originalLatLng.y - 30)
        {
            Destroy(gameObject);
        }
    }
}
