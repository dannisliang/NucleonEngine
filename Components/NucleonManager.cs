using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleonManager : MonoBehaviour
{
    [HideInInspector] public List<NucleonCollider> Colliders = new List<NucleonCollider>();

    void Awake()
    {
        foreach(NucleonBoxCollider BoxCollider in FindObjectsOfType<NucleonBoxCollider>())
        {
            Colliders.Add(BoxCollider);
        }
    }

    public void RegisterCollider(NucleonCollider Collider)
    {
        if (!Colliders.Contains(Collider))
        {
            Colliders.Add(Collider);
        }
    }

    public void RemoveCollider(NucleonCollider Collider)
    {
        if (Colliders.Contains(Collider))
        {
            Colliders.Remove(Collider);
        }
    }
}