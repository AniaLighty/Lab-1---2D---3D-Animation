using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] private ParticleSystem bubble;
    [SerializeField] private Vector3 start;
    [SerializeField] private float movement = 1.5f;
    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newMove = start;
        newMove.x += movement * Mathf.Sin(Time.time * speed);
        transform.position = newMove;
    }

    public void Bubbles(int count)
    {
        bubble.Emit(5);
    }
}
