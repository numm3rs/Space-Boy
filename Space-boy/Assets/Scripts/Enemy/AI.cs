using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private float shootTime = 3;

    [Header("Bullet")]
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpeed = 10;


    void Update()
    {
        if (shootTime > 0)
        {
            shootTime -= Time.deltaTime;
        }
        else
        {
            shootTime = Random.Range(0, 4);

            GameObject newBullet = Instantiate(bullet, transform.position + new Vector3(0, 0, -1), Quaternion.identity);

            newBullet.tag = "EnemyBullet";
            newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -(bulletSpeed - bulletSpeed / 5));
        }
    }
}
