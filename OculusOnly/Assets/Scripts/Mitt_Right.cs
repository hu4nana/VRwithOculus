using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitt_Right : MeetObject
{
    public GameObject Righthand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Test();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("RightHand"))
        {
            Debug.Log("Right!!!!!!");
            base.SetCollision(true);
        }
    }
}
