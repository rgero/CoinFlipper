using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPos;
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        startPos = this.transform.position;

        //Flick the coin so it doesn't always start one way up.
        float forceAmount = Random.Range(20, 30);
        Vector3 forcePosition = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        rigidBody.AddForceAtPosition(new Vector3(0, forceAmount, 0), forcePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            KickFlip();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }
    }

    void KickFlip()
    {
        
        float forceAmount = Random.Range(20, 100);
        Vector3 forcePosition = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        rigidBody.AddForceAtPosition(new Vector3(0, forceAmount, 0), forcePosition);
    }

    void ResetPosition()
    {
        this.transform.position = startPos;
        this.transform.rotation.eulerAngles.Set(90, 0, 0);
    }
}
