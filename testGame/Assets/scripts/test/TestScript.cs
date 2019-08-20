using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
    float speed = 5;
    void FixedUpdate() {
        this.transform.Translate(speed / 50, 0, 0);
    }
}
