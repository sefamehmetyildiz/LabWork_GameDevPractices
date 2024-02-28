using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("FrameTree",1f);
    }
    void FrameTree()
    {
        Debug.Log("Hello World");
        transform.position = new Vector3(10,10,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
