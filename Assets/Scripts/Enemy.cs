using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    [SerializeField]
    private float _timeDestruction = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _timeDestruction);
    }

    private void OnTriggerEnter2D(Collider2D other){
        Destroy(gameObject);
        Debug.Log("dd");
    }
}