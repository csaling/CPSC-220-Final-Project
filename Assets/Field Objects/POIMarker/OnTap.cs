using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTap : MonoBehaviour
{
    
    //unity coordinates to latitude longitude mapbox
    public void OnMouseDown()
    {
        Debug.Log("Latitude/Longitude:" + Lat + ", " + Long);
        //public static Vector2 LatitudeLongitudeToUnityTilePosition(Vector2d coordinate, int tileZoom, float tileScale, ulong layerExtent = 4096UL)
    }
}
