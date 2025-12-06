using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private KeyCode swingButton = KeyCode.E;
    [SerializeField] private KeyCode fireButton = KeyCode.Q;
    [SerializeField] private KeyCode reloadButton = KeyCode.R;

    public event Action SwingPressed;
    public event Action FirePressed;
    public event Action ReloadPressed;

    private void Update()
    {
        if (Input.GetKeyDown(swingButton))
        {
            SwingPressed?.Invoke();
        }

        if (Input.GetKeyDown(fireButton))
        {
            FirePressed?.Invoke();
        }

        if (Input.GetKeyDown(reloadButton))
        {
            ReloadPressed?.Invoke();
        }
    }

}