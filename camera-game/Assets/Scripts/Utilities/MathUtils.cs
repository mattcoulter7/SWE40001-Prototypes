using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtils {
    static public float nfmod(float a, float b)
    {
        
        // custom modulus function to ensure a positive number
        return a - b * Mathf.Floor(a / b);
    }

    static public float roundFloatToStep(float value, float step)
    {
        return step * (Mathf.Ceil(value / step));
    }
}