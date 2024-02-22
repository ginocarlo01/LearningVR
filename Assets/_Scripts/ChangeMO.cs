using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMO : MonoBehaviour
{
    [SerializeField]
    Type newType;

    public static Action<Type> changedMOAction;

    public void HoverMO()
    {
        changedMOAction?.Invoke(newType);
    }
}
