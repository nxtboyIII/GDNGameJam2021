using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtils : MonoBehaviour
{
    // Normalize an angle to be between -180 and 180
    public static float NormalizeAngle(float angle)
    {
        if (Mathf.Abs(angle) > 180.0f)
        {
            angle = angle % 360;
            if (angle > 180.0f)
            {
                angle -= 360.0f;
            }
        }
        
        return angle;
    }

}
