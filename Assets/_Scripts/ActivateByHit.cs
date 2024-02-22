using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByHit : MonoBehaviour
{
    public List<GameObject> objectsToDisable;
    public GameObject targetObject;


    private int disabledObjectsCount = 0;

    private void Start()
    {
        targetObject.SetActive(false);
        disabledObjectsCount = 0;

        foreach (GameObject obj in objectsToDisable)
        {
            ColliderDetection hitScript = obj.GetComponent<ColliderDetection>();
            if (hitScript != null)
            {
                hitScript.OnHit += ObjectHitHandler;
            }
            else
            {
                Debug.LogWarning("The objects in the list do not contain the needed script!");
            }
        }


    }

    void ObjectHitHandler()
    {
        disabledObjectsCount++;

        if (disabledObjectsCount == objectsToDisable.Count)
        {
            if (targetObject != null)
            {
                targetObject.SetActive(true);
            }
        }
    }

}