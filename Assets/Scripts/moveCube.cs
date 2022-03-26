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
        //if (rotateFans.isFlying&&rotateFans.isFlyingHigh)
        //{
        y = Mathf.PingPong(Time.time * speed, 0.2f) * 6 - 3;
        //}
        //else
        //{
        //    y = 0;
        //}

        //heightOffset+=0.01f;
        count++;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (right/* && !Collided*/)
        {
            leftRight++;
            Debug.Log("Right");
            transform.rotation = Quaternion.Euler(0, 0, -10);
            right = false;
        }
        if (left /*&& !Collided*/)
        {
            leftRight--;
            Debug.Log("Left");
            transform.rotation = Quaternion.Euler(0, 0, +10);
            left = false;
        }
        if (forw/* && !Collided*/)
        {
            frontBack += 5;
            Debug.Log("Forwards");
            transform.rotation = Quaternion.Euler(+10, 0, 0);
            forw = false;
        }
        if (backw/* && !Collided*/)
        {
            frontBack--;
            Debug.Log("Backwards");
            transform.rotation = Quaternion.Euler(-10, 0, 0);

            backw = false;
        }
        if (!right && !left && !forw && !backw)
        {
            //if (count > 5)
            //{
            //    //heightOffset-=0.01f;
            //    //heightOffset = 0.2f;
            //    count = 0;
            //}

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
