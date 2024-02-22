/*
 * written by ginocarlo01
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField]
    GameObject leftTeleportation;

    [SerializeField]
    GameObject rightTeleportation;

    [SerializeField]
    InputActionProperty leftActivate;

    [SerializeField]
    InputActionProperty rightActivate;

    void Update()
    {
        leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
