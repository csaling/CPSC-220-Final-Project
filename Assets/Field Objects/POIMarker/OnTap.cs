using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using UnityEngine;

public class OnTap : MonoBehaviour
{
    [SerializeField] AbstractMap _map;
    
    public void OnMouseDown()
    {
        var latLng = _map.WorldToGeoPosition(transform.position);
        Debug.Log(transform.position);
        Debug.Log("Latitude/Longitude: " + latLng);
        
    }
}
