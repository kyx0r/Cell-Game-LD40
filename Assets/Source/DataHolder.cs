using UnityEngine;


public class DataHolder : MonoBehaviour
{
    private int _invaderCellsKilled;

    public int InvaderCellsKilled
    {
        get { return _invaderCellsKilled; }
        set { _invaderCellsKilled = value; }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
