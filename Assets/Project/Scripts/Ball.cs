using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject TrailObject;

    // Start is called before the first frame update
    void Start()
    {
        TrailObject.SetActive(false);
    }

    public void ActivateTrail ()
    {
        TrailObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
