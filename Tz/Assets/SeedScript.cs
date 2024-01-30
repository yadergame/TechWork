using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedScript : MonoBehaviour
{
    [SerializeField] private GameObject plant;


    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            Instantiate(plant, new Vector3(transform.position.x, 0.5f, transform.position.z),new Quaternion(0,0,0,0));
        }
    }
}
