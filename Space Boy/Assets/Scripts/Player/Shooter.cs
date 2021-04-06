using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("Bullet Config")]
    [SerializeField] private GameObject bullet;
    [SerializeField] private float Charge = 1;
    [SerializeField] private float bulletSpeed = 1;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Charge > 0)
            {
                Charge -= Time.deltaTime;
            }
            else
            {
                Charge = 0;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bullet, transform.position + new Vector3(0, 0, 1), Quaternion.identity);

            if (Charge <= 0)
            {
                newBullet.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed - bulletSpeed / 5);
            }
            else
            {
                newBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);
            }

            Charge = 1;
        }

    }
}
