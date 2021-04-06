using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    private Renderer renderer;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (renderer.isVisible == false)
        {
            
        }
    }
}
