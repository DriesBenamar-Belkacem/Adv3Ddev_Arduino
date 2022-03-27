using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    public static bool left = false;
    public static bool right = false;
    public static bool forw = false;
    public static bool backw = false;
    float                                                       frontBack;
    int leftRight;
    public static bool Collided = false;
    //float heightOffset = 0.2f;
    public float speed;
    int count = 0;

    public SerialCommThreaded potValue;
    void Start()
    {
        frontBack = 0;
        leftRight = 0;
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }


    void Update()
    {

        float y;
        
        y = Mathf.PingPong(Time.time * speed, 0.2f) * 6 - 3;
        
        count++;
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
        if (forw)
        {
            frontBack += 2.5f;
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
        transform.position = new Vector3(leftRight, (potValue.recv_angl / 2.5f) + (y + 5), frontBack);
        if (Collided)
        {            
            frontBack = 0;
            leftRight = 0;
            potValue.recv_angl = 0;
            
        }
        if(SerialCommThreaded.restart)
        {
            Collided = false;
        }
        //if (potValue.recv_angl >= 5)
        //{
        //    Debug.Log('t');
        //}


    }
}
