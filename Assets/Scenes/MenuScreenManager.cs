using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreenManager : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        PlayerData.Instance.Load();
        SceneTransitionManager.Instance.GoToScene("MainWorldScene", new List<GameObject>());
    }
}
