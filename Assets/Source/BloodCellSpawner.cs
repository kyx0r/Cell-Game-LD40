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


    private void Update()
    {
        if (_countTimer <= 0f)
        {
            SpawnBloodCell();
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
