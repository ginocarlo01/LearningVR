/*
 * written by ginocarlo01
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuLookAtPlayer : MonoBehaviour
{
    [SerializeField]
    Transform head;

    [SerializeField]
    float spawnDistance = 2;

    [SerializeField]
    GameObject menu;

    void Update()
    {
        menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));

        menu.transform.forward *= -1;
    }
}
