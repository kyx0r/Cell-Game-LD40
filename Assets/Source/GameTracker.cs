using UnityEngine;


public class GameTracker : MonoBehaviour
{
    private BloodCellSpawner _bloodCellSpawner;
    private InvaderCellSpawner _invaderCellSpawner;
    private LevelManager _levelManager;
    private int _bloodCellsKilled;
    private int _invaderCellsKilled;
    private DataHolder _holder;

    public GameObject pauseMenu;
    public GameObject gameUI;


    //Amount of blood cells to die in order
    //to end the game
    private int _cellsDeadToEnd = 15;


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
        _levelManager = FindObjectOfType<LevelManager>();
        _holder = FindObjectOfType<DataHolder>();
    }

    private void Update()
    {
        if (_bloodCellsKilled >= _cellsDeadToEnd)
        {
            _holder.InvaderCellsKilled = _invaderCellsKilled;
            _levelManager.LoadLevel("EndGame");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePauseMenu();
        }
    }

    private void TogglePauseMenu()
    {
        gameUI.SetActive(!gameUI.activeSelf);
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        Time.timeScale = (pauseMenu.activeSelf) ? 0 : 1;
    }
}
