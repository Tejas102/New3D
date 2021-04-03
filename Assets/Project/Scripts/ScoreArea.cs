using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;

//    Start is called before the first frame update
    void Start()
    {
        effectObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball> () != null)
        {
            effectObject.SetActive(true);
            Debug.Log("Score!");
        }
    }
}
