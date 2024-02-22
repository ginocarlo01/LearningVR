/*
 * written by ginocarlo01
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    [SerializeField] Type type;

    [SerializeField] Material finishedMaterial;

    MeshRenderer mesh;

    public event Action OnHit;


    bool alreadyHit;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            BulletType type = other.GetComponent<BulletType>();

            if(type != null)
            {
                if(type.type == this.type && !alreadyHit)
                {
                    alreadyHit = true;
                    OnHit?.Invoke();
                    mesh.material = finishedMaterial;
                }
            }

            other.gameObject.SetActive(false);

        }
    }

}
