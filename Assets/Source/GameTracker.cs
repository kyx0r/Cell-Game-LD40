using UnityEngine;


public class GameTracker : MonoBehaviour
{
    private BloodCellSpawner _bloodCellSpawner;
    private InvaderCellSpawner _invaderCellSpawner;
    private int _bloodCellsKilled;
    private int _invaderCellsKilled;

    //Amount of blood cells to die in order
    //to end the game
    private int _cellsDeadToEnd = 5;


    public int BloodCellsKilled
    {
        get { return _bloodCellsKilled; }
        set { _bloodCellsKilled = value; }
    }

    public int InvaderCellsKilled
    {
        get { return _invaderCellsKilled; }
        set { _invaderCellsKilled = value; }
    }

    private void Awake()
    {
        _bloodCellsKilled = 0;
        _invaderCellsKilled = 0;
    }
}
