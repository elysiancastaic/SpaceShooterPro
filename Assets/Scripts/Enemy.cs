using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _EnemySpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //move down at 4 meters per second
        transform.Translate(Vector3.down * _EnemySpeed * Time.deltaTime);

        //if bottom of screen
        //respawn at top with a new random x position
        if (transform.position.y <= -6.0f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 8.0f, 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //if other is player
        //Damage Player (Will incorporate Lives later)
        //Destroy Enemy

        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        //if other is Laser
        //Also Destroy Laser
        //Destroy Enemy

        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
