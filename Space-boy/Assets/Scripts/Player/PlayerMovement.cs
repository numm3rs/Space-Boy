using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool canMove = true;
    [SerializeField] private float speed = 10;

    void Update()
    {
        float Hor = Input.GetAxis("Horizontal") * Time.deltaTime;
        float Ver = Input.GetAxis("Vertical") * Time.deltaTime;

        if (canMove)
        {
            transform.position += new Vector3(Hor * speed, 0, Ver * speed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position += new Vector3(Hor * speed * 50, 0, Ver * speed * 50);
        }
    }
}
