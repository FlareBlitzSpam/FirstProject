using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class SquareScript : MonoBehaviour
{
    void Start()
    {
        
    } 
    void Update()
    { 
        transform.Rotate(0, 0, 50*Time.deltaTime); 
            
    }
}

