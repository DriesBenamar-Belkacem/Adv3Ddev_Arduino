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
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (right)
        {
            leftRight++;
            Debug.Log("Right");
            transform.rotation = Quaternion.Euler(0, 0, -10);
            right = false;
        }
        if (left)
        {
            leftRight--;
            Debug.Log("Left");
            transform.rotation = Quaternion.Euler(0, 0, +10);
            left = false;
        }
        if(forw)
        {
            frontBack++;
            Debug.Log("Forwards");
            transform.rotation = Quaternion.Euler(+10, 0, 0);
            forw = false;
        }
        if (backw)
        {
            frontBack--;
            Debug.Log("Backwards");
            transform.rotation = Quaternion.Euler(-10, 0, 0);

            backw = false;
        }
        transform.position = new Vector3(leftRight, potValue.recv_angl,frontBack);
    }
}
