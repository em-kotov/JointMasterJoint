using System;
using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Rigidbody seat;
    [SerializeField] private float impulseForce = 5f;

    public void ApplyImpulse()
    {
        if (seat == null)
        {
            throw new ArgumentNullException(nameof(seat));
        }

        seat.AddForce(Vector3.forward * impulseForce, ForceMode.Impulse);
    }
}
