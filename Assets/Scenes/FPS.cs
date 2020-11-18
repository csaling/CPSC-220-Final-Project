using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public bool showFPS = true;
    Rect fpsRect;
    GUIStyle style;
    private float fps;

    void Start()
    {
        fpsRect = new Rect(5, 5, 400, 100);
        style = new GUIStyle();
        style.fontSize = 30;

        StartCoroutine(CalculateFPS());
    }

    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(fpsRect, "FPS: " + string.Format("{0:0.0}", fps,style));
    }

    private IEnumerator CalculateFPS()
    {
        while (showFPS)
        {
            fps = 1 / Time.deltaTime;
            yield return new WaitForSeconds(1);
        }
    }
}
