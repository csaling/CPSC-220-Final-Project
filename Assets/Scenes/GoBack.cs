using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    public void MainWorldScene()
    {
        SceneTransitionManager.Instance.GoToScene("MainWorldScene", new List<GameObject>());
    }
}
