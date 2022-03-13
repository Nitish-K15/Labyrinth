using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinky : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public LayerMask avoid;
    private Vector3 direction = Vector3.forward;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.velocity = transform.forward * speed;
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(direction), out hit, 1f) && !hit.collider.CompareTag("Player"))
        {
            direction *= -1f; 
            speed *= - 1;
            transform.localScale = new Vector3(1, 1, -transform.localScale.z);
        }
    }
}
