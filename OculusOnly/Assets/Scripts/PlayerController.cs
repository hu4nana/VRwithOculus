using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private OVRInput.Button primaryButton = OVRInput.Button.PrimaryIndexTrigger;


    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(primaryButton))
        {
            Debug.Log("1");
        }

        if (OVRInput.GetUp(primaryButton))
        {
            FireProjectile();
        }
    }

    void FireProjectile()
    {
        GameObject ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);

        Vector3 playerForward = transform.forward;

        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.velocity = playerForward.normalized * Speed;
    }
}
