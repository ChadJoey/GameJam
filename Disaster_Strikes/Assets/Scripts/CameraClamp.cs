using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{

    [SerializeField]
    Vector2 size;
    [SerializeField]
    Vector2 position;



    // Update is called once per frame
    void Update()
    {
        float clampX = Mathf.Clamp(transform.position.x, position.x, size.x);
        float clampY = Mathf.Clamp(transform.position.y, position.y, size.y);
        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }
}
