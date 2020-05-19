using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehavior : MonoBehaviour
{
     [SerializeField] private float _speedMin = 8.0f;
     [SerializeField] private float _speedMax = 14.0f;
    // Start is called before the first frame update
    private float _speed;
    void Start()
    {
        _speed = Random.Range(_speedMin, _speedMax);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement(){
        transform.Translate(
            new Vector3(-1,0,0)*
            _speed*Time.deltaTime);

        if(transform.position.x < -90.0f){
            float randomZ = Random.Range(-30.0f, -8.0f);
            //-8,8 //-30, 15
            float randomYRange = Random.Range(0.0f, 1.5f);
            float randomY = randomZ * -0.8f + randomYRange;
            transform.position = new Vector3(24.0f, 11.0f, randomZ);
        }
    }
}
