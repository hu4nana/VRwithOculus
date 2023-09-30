using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitt_Left : MeetObject
{ 
    public GameObject Lefthand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Test();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Lefthand.gameObject)
        {
            Debug.Log("Left");
        }
    }
}
