using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    public GameObject m_whatToDestroy;
    public float timeToDestroy = 2f; // The time (in seconds) before the object is destroyed

    void Start()
    {
        // Call the DestroyObject method after the specified time
        Invoke("DestroyObject", timeToDestroy);
    }

    void DestroyObject()
    {
        // Destroy the object
        Destroy(m_whatToDestroy);
    }

    private void Reset()
    {
        m_whatToDestroy = this.gameObject;
    }
}