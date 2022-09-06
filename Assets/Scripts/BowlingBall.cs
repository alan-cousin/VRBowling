using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    private GameObject ballReset;
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "Gutter") 
        {
            ballReset = GameObject.Find("BallReset");
            ballReset.GetComponent<BallReset>().SetGutter();
        }
    }
}
