using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPos;

    void Start()
    {
        startPos = this.transform.position;
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
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
        float forceAmount = Random.Range(20, 100);
        Vector3 forcePosition = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        rigidbody.AddForceAtPosition(new Vector3(0, forceAmount, 0), forcePosition);
    }

    void ResetPosition()
    {
        this.transform.position = startPos;
        this.transform.rotation.eulerAngles.Set(90, 0, 0);
    }
}
