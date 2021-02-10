using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private bool x, y, z;
    [SerializeField] private float speed;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        float xmove = 0f, ymove = 0f, zmove = 0f;

        if (x)
            xmove = (target.transform.position.x - transform.position.x) + offset.x;
        if (y)
            ymove = (target.transform.position.y - transform.position.y) + offset.y;
        if (z)
            zmove = (target.transform.position.z - transform.position.z) + offset.z;

        transform.position += new Vector3(xmove, ymove, zmove) * speed * Time.deltaTime;
    }
}
