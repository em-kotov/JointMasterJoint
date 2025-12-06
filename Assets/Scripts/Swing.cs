using System;
using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Rigidbody _seat;
    [SerializeField] private float _impulseForce = 5f;

    public void ApplyImpulse()
    {
        if (_seat == null)
        {
            throw new ArgumentNullException(nameof(_seat));
        }

        _seat.AddForce(Vector3.forward * _impulseForce, ForceMode.Impulse);
    }
}
