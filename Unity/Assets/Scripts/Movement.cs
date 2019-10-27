using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{

    public float movementSpeed = 0.3f;
    public float sideSpeed = 0.1f;
    public float rotSpeed = 40.0f;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.D)))
        {
            anim.Play("BeginWalk");
        }
        if (Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.Q)))
        {
            anim.Play("BeginDiag");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().position -= transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().position -= transform.right * Time.deltaTime * sideSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().position += transform.right * Time.deltaTime * sideSpeed;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, Time.deltaTime * rotSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, Time.deltaTime * -rotSpeed, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W) || (Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D)))
        {
            anim.Play("EndWalk");
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKeyUp(KeyCode.Q)))
        {
            anim.Play("EndDiag");
        }
    }
}