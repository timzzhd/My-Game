using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public float verticalInput;
    public float speed = 10.0f;
    public float yRange = 10;
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
        if (transform.position.y < yRange)
        {
            transform.position = new Vector3(yRange, transform.position.x, transform.position.z);

        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(yRange, transform.position.x, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

    }
}