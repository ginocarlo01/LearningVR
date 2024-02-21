using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    [SerializeField] InputActionProperty pinchAnimationAction;

    [SerializeField] InputActionProperty gripAnimationAction;

    Animator handAnimator;

    void Start()
    {
        handAnimator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Grip", gripValue);
    }
}
