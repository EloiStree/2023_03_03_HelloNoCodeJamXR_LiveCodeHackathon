using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCaseMono : MonoBehaviour
{

    public Transform m_toMove;
    public bool m_isAllowToFall;
    public Space m_inWhichWorldSpace;
    public float m_speed = 3;

    public void SetAllowToFall(bool isTrue) {
        m_isAllowToFall = isTrue;
    }


    public void Update()
    {
        if (m_isAllowToFall) {
            float dt = Time.deltaTime;
            //transform.Translate(Vector3.down * dt * m_speed, m_inWhichWorldSpace);
            if (m_inWhichWorldSpace == Space.World)
                transform.position += (Vector3.down * dt * m_speed);
            if (m_inWhichWorldSpace == Space.Self)
                transform.position += (-m_toMove.up * dt * m_speed);


        }
    }

    private void Reset()
    {
        m_toMove = this.transform;
    }
}
