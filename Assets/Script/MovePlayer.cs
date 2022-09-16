using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float velocity = 1;
    public float rotation = 1;
    public float jump = 1;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        // ocultar cursor.
        Cursor.visible = false;
        rigidbody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // desplazamiento/velocidad 
        var ejeX = Input.GetAxis("Horizontal");
        var ejeZ = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(ejeX ,0, ejeZ) * (Time.deltaTime * velocity));
        
        // rotación
        var mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,mouseX, 0) * (Time.deltaTime * rotation));
        
        // salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
        }
    }
}
