using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    public Transform cubeMove;
    public SerialCommThreaded potValue;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        transform.position = new Vector3(0, potValue.recv_angl,0);
    }
}
