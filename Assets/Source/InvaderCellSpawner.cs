using UnityEngine;

//Thanks to brackeys for his spawner tutorial:
//https://www.youtube.com/watch?v=n2DXF1ifUbU

public class InvaderCellSpawner : MonoBehaviour
{
    public GameObject invaderCellPrefab;

    //time between invader cell spawns
    private float _spawnInterval = 5f;

    //countdown to next spawn
    private float _countTimer = 2f;

    //Max amount of cells in game at a time
    private int _maxSpawnCount = 15;

    //current count of cells in game
    private int _spawnCount;
    
    private int _bloodCellsKilled;

    public int BloodCellsKilled
    {
        get { return _bloodCellsKilled; }
        set { _bloodCellsKilled = value; }
    }

    public int SpawnCount
    {
        get { return _spawnCount; }
        set { _spawnCount = value; }
    }


    private void Update()
    {
        Spawn();
        _countTimer -= Time.deltaTime;
        Conditional();
    }

    private void SpawnInvaderCell()
    {
        float x = Random.Range(-50, 50);
        float y = Random.Range(-20, 20);

        Instantiate(invaderCellPrefab, new Vector2(x, y), Quaternion.identity);
    }
    
    private void Spawn()
    {
        if (_countTimer <= 0f)
        {
            if (_spawnCount >= 10)
                return;


            SpawnInvaderCell();
            _spawnCount++;
            _countTimer = _spawnInterval;
        }
    }
    
    private void Conditional()
    {
        if (_bloodCellsKilled == 3)
        {
            _spawnInterval = 4f;
        }
        else if (_bloodCellsKilled == 6)
        {
            _spawnInterval = 2f;
        }
        else if (_bloodCellsKilled == 12)
        {
            _spawnInterval = 1f;
        }
    }
}

