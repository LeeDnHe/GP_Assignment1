using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] clone;
    public float startTime;
    public float endTime;
    public float spawnRate;
    public float livetime;
    private int enemyNum;
    public int maxEnemy;

    // Start is called before the first frame update
    void Start()
    {
        clone = new GameObject[maxEnemy];
        enemyNum = 0;
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void Spawn()
    {
        float spawn_x = Random.RandomRange(-100.0f, 0.0f);
        float spawn_z = Random.RandomRange(-50.0f, 50.0f);
        transform.position = new Vector3(spawn_x, 5, spawn_z);

        clone[enemyNum] = Instantiate(enemy);
        clone[enemyNum].transform.position = transform.position;
        clone[enemyNum].transform.rotation = transform.rotation;
        enemyNum++;
    }
}
