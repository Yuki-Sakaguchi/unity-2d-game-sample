using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_Move : MonoBehaviour
{
    float angle = 90;
    int count = 0;
    int maxCount = 100;

    void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        count += 1;
        if (count == maxCount)
        {
            this.transform.Rotate(0, 0, angle / 50);
            count = 0;
        }
    }
}
