using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x <= 1.4)
        {
            transform.localScale += scaleChange;
        }
        transform.position += positionChange;
        transform.Rotate(rotateChange);
    }
}
