using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int direction;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.RandomRange(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0) {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }else if(direction == 1) {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        else if (direction == 2)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (direction == 3)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
