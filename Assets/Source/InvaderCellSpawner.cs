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
    private int _maxSpawnCount = 10;

    //current count of cells in game
    private int _spawnCount;

    public int SpawnCount
    {
        get { return _spawnCount; }
        set { _spawnCount = value; }
    }


    private void Update()
    {
        if (_countTimer <= 0f)
        {
            if (_spawnCount >= 10)
                return;
             

            SpawnInvaderCell();
            _spawnCount++;
            _countTimer = _spawnInterval;
        }

        _countTimer -= Time.deltaTime;
    }

    private void SpawnInvaderCell()
    {
        Instantiate(invaderCellPrefab, transform.position, Quaternion.identity);
    }

}
