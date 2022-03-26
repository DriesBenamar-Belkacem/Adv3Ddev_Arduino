using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DontHitObstacles : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI WatchOut;

    // Start is called before the first frame update
    void Start()
    {
        WatchOut.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moveCube.Collided)
        {
            WatchOut.enabled = true;            
        }
        else if(moveCube.right|| moveCube.left || moveCube.forw || moveCube.backw)
        {
            WatchOut.enabled = true;
        }
    }
    
}
