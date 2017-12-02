using UnityEngine;


//Thanks to brackeys for his spawner tutorial:
//https://www.youtube.com/watch?v=n2DXF1ifUbU

public class BloodCellSpawner : MonoBehaviour
{
    public GameObject bloodCellPrefab;

    //Time between blood cell spawns
    private float _spawnInterval = 5f;

    //Countdown to next spawn
    private float _countTimer = 2f;

    //max amount of cells in the game at a time
    private int _maxSpawnCount = 15;

    //current amount of cells in the game
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
            if (_spawnCount >= _maxSpawnCount)
                return;

            SpawnBloodCell();
            _spawnCount++;
            _countTimer = _spawnInterval;
        }

        _countTimer -= Time.deltaTime;
    }

    private void SpawnBloodCell()
    {
        //Debug.Log("Spawn blood cell now");
        Instantiate(bloodCellPrefab, transform.position, Quaternion.identity);
    }

}
