using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materialise : MonoBehaviour
{
    Material material;
    float time = 0.0f;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        time = Mathf.Repeat(time + Time.deltaTime, 2.0f);
        Color color = Color.white;
        color.a = Mathf.PingPong(time, 1.0f);
        material.color = color;
    }
}
