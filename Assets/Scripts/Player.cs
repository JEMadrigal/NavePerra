using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(Transform))]
public class Player : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] 
    private float _speed = 12;

    [SerializeField] 
    private Projectile _lazer;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // move the player with the arrow keys
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(
            horizontal * _speed * Time.deltaTime, 
            vertical * _speed * Time.deltaTime, 
            0, 
            Space.World
        );

        // player wrap 
        // if the player goes to x = -13 it should appear at x = 13. And viceversa
        if(_transform.position.x >= 13)
        {
            _transform.position = new Vector3(-13, _transform.position.y, _transform.position.z);
        }

        else if(_transform.position.x < -13){
            _transform.position = new Vector3(13, _transform.position.y, _transform.position.z);
        }

        if(_transform.position.y >=5)
        {
            _transform.position = new Vector3(_transform.position.x, -5, _transform.position.z);
        }

        else if(_transform.position.y < -5){
            _transform.position = new Vector3(_transform.position.x, 5, _transform.position.z);
        }

        // fire a lazer 
        // if the player presses down the space bar, a lazer will shoot
        if(Input.GetButtonDown("Jump")){
            print("JUMP");
            
            Instantiate(
                _lazer, 
                transform.position, 
                transform.rotation
            );
        }
        
    }
}
