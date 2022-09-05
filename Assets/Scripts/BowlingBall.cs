using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public bool isEndPos = false;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 18 && isEndPos == false)
        {
            isEndPos = true;
        }
    }
}
