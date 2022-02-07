using UnityEngine;
using System.Collections;
public class CircleScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public int startPos = 3; 
    public int endPos = -3; 
    public bool passedPoint = false;
    void Start() {
        Debug.Log(startPos);
        Debug.Log(endPos);
    }
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);

        if (transform.position.y <= endPos) {
           transform.position = new Vector3(0, startPos, 0);
           passedPoint = true; 
        }
    }
}
