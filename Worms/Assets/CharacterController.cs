using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float speedHorizontal = 2f;
    [SerializeField] private float speedVertical = 4f;
    [SerializeField] private float flySpeed = 8f;
    

    void Update()
    {
        if (Input.GetAxis("Horizontal") !=0)
        {
            transform.Translate(Vector3.right * speedHorizontal * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") !=0)
        {
            transform.Translate(Vector3.forward * speedVertical * Time.deltaTime * Input.GetAxis("Vertical"));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        
       
    }

    private void Jump()
    {
        //characterBody.velocity = Vector3.up * flySpeed;
        characterBody.AddForce(Vector3.up * flySpeed);
    }
}
