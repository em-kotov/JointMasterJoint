using UnityEngine;

public class Subscriber : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Swing _swing;
    [SerializeField] private Catapult _catapult;

    private void OnEnable()
    {
        _inputReader.SwingPressed += _swing.ApplyImpulse;
        _inputReader.FirePressed += _catapult.Fire;
        _inputReader.ReloadPressed += _catapult.Reload;
    }

    private void OnDisable()
    {
        _inputReader.SwingPressed -= _swing.ApplyImpulse;
        _inputReader.FirePressed -= _catapult.Fire;
        _inputReader.ReloadPressed -= _catapult.Reload;
    }
}
