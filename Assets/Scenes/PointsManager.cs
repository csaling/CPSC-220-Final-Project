using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    private GameObject text;

    void Start()
    {
        text = GameObject.FindGameObjectWithTag("Points");
        text.GetComponent<Text>().text = "Credits: " + PlayerData.Instance.Points;
    }
}
