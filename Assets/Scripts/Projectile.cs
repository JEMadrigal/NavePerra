using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform _transform;

    [SerializeField]
    private float _speed = 10;

    [SerializeField]
    private float _timeDestruction = 5;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;

        Destroy(gameObject, _timeDestruction);
    }

    // Update is called once per frame
    void Update()
    {
        // make the lazer shoot and go up
        transform.Translate(
            0,
            _speed * Time.deltaTime,
            0
        );
    }
}
