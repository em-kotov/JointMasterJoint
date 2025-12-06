using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform spoon;
    [SerializeField] private Rigidbody rb;

    public void ReturnToSpoon()
    {
        if (spoon == null)
        {
            throw new ArgumentNullException(nameof(spoon));
        }

        if (rb == null)
        {
            throw new ArgumentNullException(nameof(rb));
        }

        rb.linearVelocity = Vector3.zero;
        transform.position = spoon.position;
    }
}
