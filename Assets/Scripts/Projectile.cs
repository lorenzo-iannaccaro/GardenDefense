using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileRotationSpeed = 90f;
    //Vector3 actualRotation = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //actualRotation += new Vector3(0, 0, projectileRotationSpeed);
        //transform.RotateAround(transform.localPosition,
        //                        Vector3.forward,
        //                        projectileRotationSpeed * Time.deltaTime);
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }
}
