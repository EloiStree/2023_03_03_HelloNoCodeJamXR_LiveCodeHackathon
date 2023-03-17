using System.Collections.Generic;
using UnityEngine;

public class ObjectCreationAndDestruction : MonoBehaviour
{
    public GameObject prefab; // The prefab to instantiate


    public KeyCode m_createPrefabKey = KeyCode.Space;
    public KeyCode m_destroyCreatedKey= KeyCode.D;

    public List<GameObject> m_createdObject= new List<GameObject>();

    void Update()
    {
        // Check if the player pressed the spacebar
        if (Input.GetKeyDown(m_createPrefabKey))
        {
            CreateAnPrefab();


        }

        // Check if the player pressed the 'D' key and there is a spawned object
        if (Input.GetKeyDown(m_destroyCreatedKey) )
        {
            DestroyAllPrefab();
        }
    }

    [ContextMenu("Create An Prefab")]
    public void CreateAnPrefab()
    {
        m_createdObject.Add(Instantiate(prefab, transform.position, Quaternion.identity));
    }
    [ContextMenu("Destroy All Prefab")]
    public void DestroyAllPrefab()
    {
       
        foreach (var item in m_createdObject)
        {

            Destroy(item);
        }
        m_createdObject.Clear();
        // Destroy the spawned object
    }
}