using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpdater : MonoBehaviour
{
    public MeshRenderer[] playerColor;

    void Start()
    {
        playerColor = GetComponentsInChildren<MeshRenderer>();

        if (PlayerData.Instance.Hat == true)
        {
            foreach (MeshRenderer mesh in playerColor)
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
        }

        if (PlayerData.Instance.Shield == true)
        {
            foreach (MeshRenderer mesh in playerColor)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
        }

        switch (PlayerData.Instance.ColorVal)
        {

            case 1:
                foreach (MeshRenderer mesh in playerColor)
                {
                    mesh.material.SetColor("_Color", Color.red);
                }

                break;

            case 2:
                foreach (MeshRenderer mesh in playerColor)
                {
                    mesh.material.SetColor("_Color", Color.blue);
                }

                break;

            case 3:
                foreach (MeshRenderer mesh in playerColor)
                {
                    mesh.material.SetColor("_Color", Color.green);
                }

                break;

            case 4:
                foreach (MeshRenderer mesh in playerColor)
                {
                    mesh.material.SetColor("_Color", Color.cyan);
                }

                break;

            case 5:
                foreach (MeshRenderer mesh in playerColor)
                {
                    mesh.material.SetColor("_Color", Color.black);
                }

                break;
        }
    }
}
