using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject Ball;
    public GameObject PlayerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    public bool holdingBall = true;

    // Start is called before the first frame update
    void Start()
    {
        Ball.GetComponent<Rigidbody>().useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                Ball.GetComponent<Rigidbody>().useGravity = true;
                Ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * ballThrowingForce);
            }
        }

        }
}
