using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public float speed = 4f; //velocidad
    public float speedJump = 15f; //velocidad de salto
    private Rigidbody playerb; //rigidbody
    private Vector3 moveInput; // el imput en 3D
    // Start is called before the first frame update
    void Start()
    {
        playerb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //movimiento horizontal
        float moveZ = Input.GetAxisRaw("Vertical"); //movimiento vertical
        moveInput = new Vector3(moveX, 0, moveZ); //asignandole donde va cada movimiento
        if(Input.GetKey("space") && playerb.velocity.y == 0){playerb.AddForce(transform.up * speedJump);
        }
        Debug.Log("JA no puedes saltar"); //para la consola hacia arriba es cero, añadimos una fuerza hacia arriba multiplicados por la velocidad de salto, esto nos permite saltar :3q
    }
    private void FixedUpdate(){
        playerb.MovePosition(playerb.position + moveInput.normalized * speed * Time.fixedDeltaTime);
        //movimiento fluido 
    }

}
