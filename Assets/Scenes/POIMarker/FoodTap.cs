using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTap : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneTransitionManager.Instance.GoToScene("FoodMinigame", new List<GameObject>());
    }
}
