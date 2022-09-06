using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    private GameObject ballReset;
    public bool isGutterBall = false;
    // Start is called before the first frame update
    void Update()
    {
        if (gameObject.transform.position.y < 0f && !isGutterBall)
        {
            ballReset = GameObject.Find("BallReset");
            ballReset.GetComponent<BallReset>().SetGutter();
            isGutterBall = true;
        }
    }

}
