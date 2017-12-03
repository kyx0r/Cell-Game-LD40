using UnityEngine;
using UnityEngine.UI;


public class UIUpdater : MonoBehaviour
{
    public Text bloodCellsKilledText;
    public Text invaderCellsKilledText;
    public GameTracker tracker;


    private void Update()
    {
        bloodCellsKilledText.text = tracker.BloodCellsKilled.ToString();
        invaderCellsKilledText.text = tracker.InvaderCellsKilled.ToString();
    }
}
