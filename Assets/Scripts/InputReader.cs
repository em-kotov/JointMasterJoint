using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private KeyCode _swingButton = KeyCode.E;
    [SerializeField] private KeyCode _fireButton = KeyCode.Q;
    [SerializeField] private KeyCode _reloadButton = KeyCode.R;

    public event Action SwingPressed;
    public event Action FirePressed;
    public event Action ReloadPressed;

    private void Update()
    {
        if (Input.GetKeyDown(_swingButton))
        {
            SwingPressed?.Invoke();
        }

        if (Input.GetKeyDown(_fireButton))
        {
            FirePressed?.Invoke();
        }

        if (Input.GetKeyDown(_reloadButton))
        {
            ReloadPressed?.Invoke();
        }
    }

}