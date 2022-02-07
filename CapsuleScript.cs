using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CapsuleScript : MonoBehaviour
{
    
    void Start() 
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (GameObject.Find("Circle").GetComponent<CircleScript>().passedPoint) {
        Vector3 newScale = transform.localScale;
        newScale = newScale * 1.001f;
        transform.localScale = newScale;
        }
    }
}
