using UnityEngine;
using UnityEngine.UI;


public class EndGameUI : MonoBehaviour
{
    public Text invadersKilledText;
    private DataHolder _holder;

    private void Awake()
    {
        _holder = FindObjectOfType<DataHolder>();
        invadersKilledText.text = _holder.InvaderCellsKilled.ToString();
    }


}
