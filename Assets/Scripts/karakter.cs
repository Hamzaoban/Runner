using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    Rigidbody rb;
    
    public float Ilerihiz;
    public float YatayHiz;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        KarakterHareket();
        SagaSolaHareket();
       
    }

    public void SagaSolaHareket()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*YatayHiz * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * YatayHiz * Time.deltaTime);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -0.45f, 0.45f),transform.position.y, transform.position.z);

    }
    
    
    public void KarakterHareket()
    {
        
        rb.AddForce(new Vector3(transform.position.x, transform.position.y, Ilerihiz));

    }
}
