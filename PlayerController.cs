using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horiztonalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;

    void Update()
    {
        horiztonalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horiztonalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
