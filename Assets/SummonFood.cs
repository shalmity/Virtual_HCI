using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonFood : MonoBehaviour
{
    public GameObject food;
    public Transform[] summonPos;

    void Start()
    {
        InvokeRepeating("FoodInit", 0f, 3.0f);
    }

    void FoodInit()
    {
        Instantiate(food, summonPos[Random.Range(0, 3)].position, Quaternion.identity);
    }
}
