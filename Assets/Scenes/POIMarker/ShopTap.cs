using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTap : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneTransitionManager.Instance.GoToScene("Shop", new List<GameObject>());
    }
}
