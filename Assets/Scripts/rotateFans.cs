using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateFans : MonoBehaviour
{
    float incr = 1;
    public SerialCommThreaded potentio;
    public static bool isFlying;
    public static bool isFlyingHigh;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, incr, 0);
        //if (potentio.recv_angl > 1 && potentio.recv_angl < 10)
        //{
        //    incr += 1;
        //    isFlying = true;
        //    isFlyingHigh = true;
        //}
        //if (potentio.recv_angl > 10)
        //{
        //    incr += 25;
        //    isFlying = true;
        //    isFlyingHigh = false;
        //}
        //if (potentio.recv_angl <= 0)
        //{
        //    incr += 0.1f;
        //    isFlying = false;
        //}
        incr += 25;
        //Debug.Log(potentio.recv_angl);
    }
}
