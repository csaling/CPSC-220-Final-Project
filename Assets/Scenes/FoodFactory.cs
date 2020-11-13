using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FoodFactory : MonoBehaviour
{
    [SerializeField] private GameObject food;
    private float maxX = 13;
    private float minX = -9;
    private bool wait = false;

    public void Update()
    {
        if (!wait)
        {
            StartCoroutine(timer());
        }
    }

    public void foodSpawner()
    {
        StartCoroutine(timer());
    }

    public IEnumerator timer()
    {
        wait = true;
        yield return new WaitForSeconds(0.5f);
        float range = Random.Range(minX, maxX);
        Vector3 spawn = new Vector3(range, 16, 15.5f);
        Instantiate(food, spawn, Quaternion.identity);
        wait = false;
    }
}
