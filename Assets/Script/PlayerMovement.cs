using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbody = new Rigidbody();
    private int point;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        point = 0;
        
    }

    void OnTriggerEnter(Collider other)
    { 
        
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            point++;
            Destroy(other.gameObject);
            Debug.Log(point);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back * speed, ForceMode.VelocityChange);
        }


    }
}
