using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public static float leftSide = -3.7f;
    public static float rightSide = 0.7f;
    public float internalLeft;
    public float internalRight;


    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
