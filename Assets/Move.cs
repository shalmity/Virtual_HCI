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
        transform.LookAt(knife.transform);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
