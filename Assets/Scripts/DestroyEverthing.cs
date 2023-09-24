using System;

using UnityEngine;

public class DestroyEverthing : MonoBehaviour
{
    public GameObject wheels;
    public bool here;  
   

    public void DestoryWheels()
    {
        here = false; 
        wheels.SetActive(here);
    }

    public void RedeployWheels()
    {
        here = true; 
        wheels.SetActive(here);
    }
}
