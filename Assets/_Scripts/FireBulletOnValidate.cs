using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnValidate : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform spawnPoint;

    [SerializeField]
    float bulletSpeed = 20;

    public Type fireType;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet); //function that is going to be called when it is activated
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
        spawnedBullet.GetComponent<BulletType>().type = fireType;
        Destroy(spawnedBullet, 5);
    }

    private void OnEnable()
    {
        ChangeMO.changedMOAction += ChangeFireType;
    }

    private void OnDisable()
    {
        ChangeMO.changedMOAction -= ChangeFireType;
    }

    public void ChangeFireType(Type newType)
    {
        fireType = newType;
    }
}
