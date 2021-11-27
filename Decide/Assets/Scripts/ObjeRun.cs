using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeRun : MonoBehaviour
{
    float speed=9f;

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.back * speed*Time.deltaTime;
    }
}
