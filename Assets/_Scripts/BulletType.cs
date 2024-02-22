/*
 * written by ginocarlo01
 */

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletType : MonoBehaviour
{
    public Type type;

    MeshRenderer mesh;

    [Tooltip("Must be in the specific order")]
    [SerializeField]
    List<Material> materials = new List<Material>();

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material = materials[((int)type)];
    }
}
