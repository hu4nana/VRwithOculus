using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private OVRInput.Button primaryButton = OVRInput.Button.PrimaryIndexTrigger;

    GameObject HasBall;

    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float Speed = 10f;

    public List<GameObject> FoundObjects;
    public GameObject enemy;
    public float Dis = 10;
    public float shortDis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (OVRInput.GetDown(primaryButton))
        {
            
        }

        if (OVRInput.GetUp(primaryButton))
        {
            
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);

            Vector3 playerForward = transform.forward;

            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            ballRigidbody.velocity = playerForward.normalized * Speed;
        }


        if (Input.GetMouseButton(1))
        {
            if(HasBall != null) findball();
        }
        if (Input.GetMouseButtonUp(1))
        {
           if (HasBall != null) FireProjectile();
        }
    }

    void findball()
    {
        HasBall.transform.position = new Vector3(transform.position.x, transform.position.y+3, transform.position.z);
    }

    void FireProjectile()
    {
        Vector3 playerForward = transform.forward;

        Rigidbody ballRigidbody = HasBall.GetComponent<Rigidbody>();
        ballRigidbody.velocity = playerForward.normalized * Speed;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.transform.CompareTag("Ball"))
        {
            HasBall = col.gameObject;
            print("111111111111");
        }   
    }
}
