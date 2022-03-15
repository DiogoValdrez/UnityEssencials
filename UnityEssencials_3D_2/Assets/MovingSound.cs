using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSound : MonoBehaviour
{
    public Vector3 positionChange;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I started now");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += positionChange;
        Debug.Log(transform.position);
    }
}
