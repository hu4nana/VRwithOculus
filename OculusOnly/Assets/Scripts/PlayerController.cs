using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OVR;
public class PlayerController : MonoBehaviour
{
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
    {// PrimaryIndexTrigger 왼손 트리거 버튼
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            Debug.Log(" 왼쪽 Grip Button Down");
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            Debug.Log(" 오른쪽 Grip Button Up");
        }


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
