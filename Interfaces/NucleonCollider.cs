using UnityEngine;

public abstract class NucleonCollider : MonoBehaviour
{
    public bool AllowSleeping = true;

    public bool Sleeping;
    public float SleepTimer = 0f;

    public abstract void FetchCollisions();
    public abstract void NucleonUpdate();
}