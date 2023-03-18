using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectOnRequestAtTransformMono : MonoBehaviour
{

    public Transform m_where;
    public GameObject m_whatToCreate;


    [ContextMenu("Create An Instance")]
    public void CreateAnInstance() {

        GameObject created = GameObject.Instantiate(m_whatToCreate, m_where);
     

    }

}
