using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateFans : MonoBehaviour
{
    float incr = 1;
    public SerialCommThreaded potentio;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0,0);
    }

    // Update is called once per frame
    void Update()
    {
        incr+=(potentio.recv_angl/10);
        transform.rotation = Quaternion.Euler(0, incr, 0);
        Debug.Log(incr += potentio.recv_angl);
    }
}
