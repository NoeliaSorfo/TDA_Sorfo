using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  private Rigidbody rigidbody;

    [SerializeField]
    private float speed = 3;
    public float rotationSpeed = 5;
    public float gravity = -20f;
    public float playerLife = 100;


    [SerializeField]
    private ForceMode forceMode;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

       /* if(Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCamera();
        }*/
      }   

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(0, 0, v);
        velocity = transform.TransformDirection(velocity);
        velocity *= speed;
        velocity -= GetComponent<Rigidbody>().velocity;

        GetComponent<Rigidbody>().AddForce(velocity, forceMode);
        transform.Rotate(new Vector3(0, h, 0));
    
         if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 8;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
        }
    }

    void PlayerMove(Vector3 dir)
        {
            transform.Translate(dir * Time.deltaTime);
        }

        /*void ToggleCamera()
        {
            if(camOne.activeInHierarchy)
            {
                camOne.SetActive(false);
                camTwo.SetActive(true);
            }else
            {
                camOne.SetActive(true);
                camTwo.SetActive(false);
            }
        }*/
}