using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody rb;
    private Vector2 vect;
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    private void Update()
    {
        vect = new Vector2(Input.GetAxis("Horizontal") * _speed,Input.GetAxis("Vertical") * _speed);
    }
    private void FixedUpdate()
    {
        rb.velocity=new Vector3(vect.x,0, vect.y);
    }
}
