using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovePhysics : MonoBehaviour
{
    public float force;
    public Vector3 direction;
    Rigidbody myRigidB;
    // Start is called before the first frame update
    void Start()
    {
        myRigidB = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (myRigidB != null)
        {
            myRigidB.AddForce(force * direction * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            direction = -direction;
        }

    }
}
