using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBox : MonoBehaviour
{
    [SerializeField] float rotateRate;
    private Quaternion up;
    private Quaternion down;
    private float ratio;
    // Start is called before the first frame update
    void Start()
    {
        up = transform.rotation;
        down = transform.rotation * Quaternion.Euler(new Vector3(-180,0,0));
        ratio = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            ratio += rotateRate * Time.fixedDeltaTime;
            if (ratio > 1f)
            {
                ratio = 1f;
            }
        }
        else
        {
            ratio -= rotateRate * Time.fixedDeltaTime;
            if(ratio < 0f)
            {
                ratio = 0f;
            }
        }
        transform.rotation = Quaternion.Slerp(up, down, ratio);
    }
}
