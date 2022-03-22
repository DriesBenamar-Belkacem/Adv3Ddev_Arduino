using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerArduino : MonoBehaviour
{
    public Transform controlledObject;
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
        controlledObject.position += controlledObject.right.normalized;
    }
    public void MoveControlledObjectLeft()
    {
        controlledObject.position -= controlledObject.right.normalized;
    }
    public void MoveControlledObjectForward()
    {
        controlledObject.position += controlledObject.forward.normalized;
    }
    public void MoveControlledObjectBackward()
    {
        controlledObject.position -= controlledObject.forward.normalized;
    }
}
