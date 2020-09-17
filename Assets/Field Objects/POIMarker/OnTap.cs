using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTap : MonoBehaviour
{
    private bool isLeftButtonDown = Input.GetMouseButton(0);
    void Start()
    {
        
    }
    
    void Update()
    {
        if (isLeftButtonDown)
        {
            Debug.Log("True or False?:" + isLeftButtonDown);
        }
    }
}
