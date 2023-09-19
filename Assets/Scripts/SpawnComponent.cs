using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    public GameObject enemy;
    public float startTime;
    public float endTime;
    public float spawnRate;
    public float livetime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float spawn_x = Random.RandomRange(-200.0f, 0.0f);
        float spawn_z = Random.RandomRange(-100.0f, 100.0f);
        transform.position = new Vector3(spawn_x, 5, spawn_z);

        GameObject clone = Instantiate(enemy);
        clone.transform.position = transform.position;
        clone.transform.rotation = transform.rotation;

        Destroy(clone, livetime);
    }
}
