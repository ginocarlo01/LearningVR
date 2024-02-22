/*
 * written by ginocarlo01
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField]
    Transform[] path;

    [SerializeField]
    int currentPoint;

    [SerializeField]
    Transform currentGoal;

    [SerializeField]
    float moveSpeed = 10f;

    [SerializeField]
    float roundingDistance =.2f;

    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentGoal = path[currentPoint];

        
    }

    void FixedUpdate()
    {
        Vector3 temp = Vector3.MoveTowards(transform.position, currentGoal.position, moveSpeed * Time.deltaTime);
        rb.MovePosition(temp);

        if (Vector3.Distance(transform.position, currentGoal.position) < roundingDistance)
        {
            ChangeGoal();
        }
    }

    private void ChangeGoal()
    {
        if (currentPoint == path.Length - 1)
        {
            currentPoint = 0;
            currentGoal = path[currentPoint];
        }
        else
        {
            currentPoint++;
            currentGoal = path[currentPoint];
        }
    }


}
