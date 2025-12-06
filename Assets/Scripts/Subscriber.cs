using UnityEngine;

public class Subscriber : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Swing swing;
    [SerializeField] private Catapult catapult;

    private void OnEnable()
    {
        inputReader.SwingPressed += swing.ApplyImpulse;
        inputReader.FirePressed += catapult.Fire;
        inputReader.ReloadPressed += catapult.Reload;
    }

    private void OnDisable()
    {
        inputReader.SwingPressed -= swing.ApplyImpulse;
        inputReader.FirePressed -= catapult.Fire;
        inputReader.ReloadPressed -= catapult.Reload;
    }
}
