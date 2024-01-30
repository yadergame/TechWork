using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    [SerializeField] private Material green;
    [SerializeField] private Renderer rend;
    private bool WithPlayer;
    private Transform tf;
    [SerializeField] private bool IsGrowth=false;
    private void Start()
    {
        tf = transform;
        StartCoroutine(Growth());
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Player")
        {
            WithPlayer = true;
            print("Вошёл");
        }
    }
    void OnTriggerExit(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Player")
        {
            WithPlayer= false;
            print("Вышел");
        }
    }
    private void Update()
    {
        if(WithPlayer&IsGrowth)
        {
            if(Input.GetKey(KeyCode.R)) 
            { 
                Destroy(tf.gameObject);
            }
        }
    }
    private IEnumerator Growth()
    {
        yield return new WaitForSecondsRealtime (10);
        IsGrowth = true;
        rend.material = green;
        tf.localScale = new Vector3 (2,2,2);
    }
        
}
