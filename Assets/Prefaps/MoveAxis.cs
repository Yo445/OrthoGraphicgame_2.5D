using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAxis : MonoBehaviour
{
    public float v;
    public float h;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        transform.Translate(0f, 0f, v*Time.deltaTime);
        transform.Rotate(0f, h*Time.deltaTime, 0f);
    }
}
