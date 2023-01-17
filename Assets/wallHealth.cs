using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallHealth : MonoBehaviour
{
    public int health = 100;
    public GameObject bullet;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == bullet)
        {
            health -= 10;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
