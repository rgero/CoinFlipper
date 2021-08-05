using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coinObject;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(coinObject.transform, Vector3.up);
    }
}
