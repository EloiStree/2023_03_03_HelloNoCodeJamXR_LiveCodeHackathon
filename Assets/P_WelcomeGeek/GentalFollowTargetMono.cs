using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GentalFollowTargetMono : MonoBehaviour
{
    public Transform m_toFollow;
    public Transform m_toMove;
    public float m_rotateLerpForce=1;
    public float m_moveLerpForce = 1;

    void Update()
    {
        m_toMove.position = Vector3.Lerp(m_toMove.position, m_toFollow.position, Time.deltaTime * m_moveLerpForce);
        m_toMove.rotation = Quaternion.Lerp(m_toMove.rotation, m_toFollow.rotation, Time.deltaTime * m_rotateLerpForce);
    }
}
