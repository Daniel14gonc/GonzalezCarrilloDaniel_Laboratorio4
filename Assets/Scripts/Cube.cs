using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.gray;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    private void OnMouseDown()
    {
        RaycastHit hitInfo;
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(myRay, out hitInfo);


        rb.AddForce(-hitInfo.normal * 5, ForceMode.Impulse);
    }
}
