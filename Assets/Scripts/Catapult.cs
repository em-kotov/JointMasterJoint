using System;
using Unity.Mathematics;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Rigidbody spoon;
    [SerializeField] private Ball ball;
    [Range(1f, 20f)]
    [SerializeField] private float fireForce = 5f;
    [SerializeField] private Vector3 fireDirection = new Vector3(0f, 1f, 0f);
    [SerializeField] private quaternion restRotation;

    public void Fire()
    {
        if (spoon == null)
        {
            throw new ArgumentNullException(nameof(spoon));
        }

        spoon.AddForce(fireDirection.normalized * fireForce, ForceMode.Impulse);
    }

    public void Reload()
    {
        spoon.linearVelocity = Vector3.zero;
        spoon.transform.rotation = restRotation;

        if (ball == null)
        {
            throw new ArgumentNullException(nameof(ball));
        }

        ball.ReturnToSpoon();
    }
}
