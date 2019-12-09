using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class GenerateSphere : MonoBehaviour
{
    public int subdivisions = 0;
    public float radius = 1f;

    private void Start()
    {
        GetComponent<MeshFilter>().mesh = SphereGenerator.Create(subdivisions, radius);
    }
}