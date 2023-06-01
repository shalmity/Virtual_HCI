using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 100.0f;
    private GameObject knife;
    void Start()
    {
        knife = GameObject.FindGameObjectWithTag("Sword");
    }
    void Update()
    {
        transform.LookAt(knife.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
