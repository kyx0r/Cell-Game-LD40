using UnityEngine;
using UnityEngine.UI;


public class UIUpdater : MonoBehaviour
{
    public Text bloodCellsKilledText;
    public Text invaderCellsKilledText;
    private GameTracker _tracker;

    private void Awake()
    {
        _tracker = GetComponent<GameTracker>();
    }

    private void Update()
    {
        bloodCellsKilledText.text = _tracker.BloodCellsKilled.ToString();
        invaderCellsKilledText.text = _tracker.InvaderCellsKilled.ToString();
    }
}
