using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFallingMeteor : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField]
    float launchForce;
    private Quaternion angle;


    void Start()
    {
        Vector2 launchdirection = gameObject.transform.position + new Vector3(Random.Range(-30, 30), Random.Range(-3,3),0);
        rb.AddForce(-launchdirection * launchForce);
    }


    void Update()
    {
        Vector2 dir = rb.velocity.normalized;
        float magnitude = Mathf.Clamp01(rb.velocity.magnitude);
        dir.Normalize();
        transform.Translate(dir * 1 * magnitude * Time.deltaTime, Space.World);

        if (dir != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, dir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 1000 * Time.deltaTime);
        }

    }
}
