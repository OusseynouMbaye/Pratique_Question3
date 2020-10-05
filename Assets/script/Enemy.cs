using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    float EnemySpeed = 4.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector2(-1, 0) * EnemySpeed * Time.deltaTime , Space.World);

        if (transform.position.x <=-20)
        {
            //Destroy(gameObject);
        }
    }
}
