using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerArduino : MonoBehaviour
{
    //public Transform controlledObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveControlledObjectRight()
    {
        transform.position = new Vector3(0, 0, +1.0f);
    }
    public void MoveControlledObjectLeft()
    {
        transform.position -= transform.right.normalized;
    }
    public void MoveControlledObjectForward()
    {
        transform.position += transform.forward.normalized;
    }
    public void MoveControlledObjectBackward()
    {
        transform.position -= transform.forward.normalized;
    }
}
