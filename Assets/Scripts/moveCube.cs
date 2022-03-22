using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    public static bool left = false;
    public static bool right = false;
    public static bool forw = false;
    public static bool backw = false;
    int frontBack;
    int leftRight;

    public SerialCommThreaded potValue;
    void Start()
    {
        frontBack = 0;
        leftRight = 0;
        transform.position = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        if(right)
        {
            leftRight++;
            Debug.Log("Right");
            right = false;
        }
        if (left)
        {
            leftRight--;
            Debug.Log("Left");
            left = false;
        }
        if(forw)
        {
            frontBack++;
            Debug.Log("Forwards");
            forw = false;
        }
        if (backw)
        {
            frontBack--;
            Debug.Log("Backwards");
            backw = false;
        }
        transform.position = new Vector3(leftRight, potValue.recv_angl,frontBack);
    }
}
