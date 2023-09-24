using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material material;

   public void MakeGreen() 
    {
        material.color = Color.green;
    }
   public void MakeRed()
   {
       material.color = Color.red;
   }
   public void MakeBlue() 
   {
       material.color = Color.blue;
   }
   public void MakeYellow() 
   {
       material.color = Color.yellow;
   }
}
