using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform _spoon;
    [SerializeField] private Rigidbody _rigidbody;

    public void ReturnToSpoon()
    {
        if (_spoon == null)
        {
            throw new ArgumentNullException(nameof(_spoon));
        }

        if (_rigidbody == null)
        {
            throw new ArgumentNullException(nameof(_rigidbody));
        }

        _rigidbody.linearVelocity = Vector3.zero;
        transform.position = _spoon.position;
    }
}
