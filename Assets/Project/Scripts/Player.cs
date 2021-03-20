using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject Ball;
    public GameObject PlayerCamera;

    // Start is called before the first frame update
    void Start()
    {
        Ball.GetComponent<Rigidbody>().useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
