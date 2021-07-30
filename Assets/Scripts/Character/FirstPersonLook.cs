using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Vector3 newEulerAngles = transform.eulerAngles + new Vector3(-input.y, input.x);
        // Limit the amount you can look up/down
        newEulerAngles.x = Mathf.Clamp(MathUtils.NormalizeAngle(newEulerAngles.x), -75.0f, 75.0f);
        transform.eulerAngles = newEulerAngles;
    }
}
