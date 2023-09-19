using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet_prefab;
    public GameObject bigbullet_prefab;
    public GameObject fishbullet_prefab;
    public GameObject shootpoint;
    public float livetime;
    private int count = 1;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (count != 5 && count<10)
            {
                GameObject clone = Instantiate(bullet_prefab);
                clone.transform.position = shootpoint.transform.position;
                clone.transform.rotation = shootpoint.transform.rotation;
                count++;
                Destroy(clone, livetime);
            }
            else if(count == 5)
            {
                GameObject clone = Instantiate(bigbullet_prefab);
                clone.transform.position = shootpoint.transform.position;
                clone.transform.rotation = shootpoint.transform.rotation;
                count++;
                Destroy(clone, livetime);
            }
            else
            {
                GameObject clone = Instantiate(fishbullet_prefab);
                clone.transform.position = shootpoint.transform.position;
                clone.transform.rotation = shootpoint.transform.rotation;
                count = 1;
                Destroy(clone, livetime);
            }
        }
    }

 }
