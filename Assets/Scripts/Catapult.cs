using System;
using Unity.Mathematics;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Rigidbody _spoon;
    [SerializeField] private Ball _ball;
    [Range(1f, 20f)]
    [SerializeField] private float _fireForce = 5f;
    [SerializeField] private Vector3 _fireDirection = new(0f, 1f, 0f);
    [SerializeField] private quaternion _restRotation;

    public void Fire()
    {
        if (_spoon == null)
        {
            throw new ArgumentNullException(nameof(_spoon));
        }

        _spoon.AddForce(_fireDirection.normalized * _fireForce, ForceMode.Impulse);
    }

    public void Reload()
    {
        _spoon.linearVelocity = Vector3.zero;
        _spoon.transform.rotation = _restRotation;

        if (_ball == null)
        {
            throw new ArgumentNullException(nameof(_ball));
        }

        _ball.ReturnToSpoon();
    }
}
