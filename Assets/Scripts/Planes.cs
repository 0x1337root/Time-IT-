using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planes : MonoBehaviour
{

    float speed = 2f;

    Vector3 dir = new Vector3(0,0,-1);

    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
