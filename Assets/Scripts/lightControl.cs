using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour
{
    public SerialCommThreaded potValue;
    public Light myLight;
    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime=Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeIntensity)
        {
            myLight.intensity = potValue.recv_angl;
        }   
    }
}
