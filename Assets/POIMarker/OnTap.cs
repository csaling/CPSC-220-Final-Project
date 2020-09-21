using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using UnityEngine;

public class OnTap : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        var latLng = GameObject.Find("Map").GetComponent<AbstractMap>().WorldToGeoPosition(transform.position);
        //Debug.Log(transform.position);
        //Debug.Log("Latitude/Longitude: " + latLng);
        
    }
}
