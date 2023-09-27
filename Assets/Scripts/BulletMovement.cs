using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            GameManager.i.EnemyDeath();
        }
    }
}
