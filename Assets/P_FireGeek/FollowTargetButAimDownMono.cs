using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetButAimDownMono : MonoBehaviour
{
    public Transform m_targetToMirror;
    public Transform m_targetToAffect;
    void Update()
    {
        m_targetToAffect.position = m_targetToMirror.position;
        m_targetToAffect.transform.forward = Vector3.down;
    }
}
