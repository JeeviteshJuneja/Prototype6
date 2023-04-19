using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideToSide : MonoBehaviour
{
    [SerializeField] private float leftBound;
    [SerializeField] private float rightBound;
    [SerializeField] private float speed; 
    private Vector3 leftPos;
    private Vector3 rightPos;
    private float parameter;
    // Start is called before the first frame update
    void Start()
    {
        leftPos = new Vector3(transform.position.x, transform.position.y, leftBound);
        rightPos = new Vector3(transform.position.x, transform.position.y, rightBound);
        transform.position = leftPos;
        parameter = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        parameter += speed*Time.fixedDeltaTime/(rightBound-leftBound);
        parameter %= 2;
        float t;
        if (parameter < 1)
        {
            t = parameter;
        }
        else
        {
            t = 2 - parameter;
        }
        transform.position = Vector3.Lerp(leftPos, rightPos, t);
    }
}
