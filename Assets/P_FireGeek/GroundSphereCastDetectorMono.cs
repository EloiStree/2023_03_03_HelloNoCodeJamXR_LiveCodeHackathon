using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundSphereCastDetectorMono : MonoBehaviour
{
    public Transform m_direction;
    public float m_radius = 0.3f;
    public float m_maxDistance = 4;
    public LayerMask m_whatToLookFor;
    public IsThereGroundEvent m_isThereGroundState;
    public UnityEvent m_onNoGround;
    public UnityEvent m_onRecoverGround;
    public bool m_groundPreviousState;

    [System.Serializable]
    public class IsThereGroundEvent : UnityEvent<bool> { }

    void Start()
    {
        m_groundPreviousState = IsThereGround(); 
    }


    void Update()
    {
        bool thereIsAGround = IsThereGround();

        m_isThereGroundState.Invoke(thereIsAGround);
        if (thereIsAGround != m_groundPreviousState) { 
            if (thereIsAGround)
            {
                m_onRecoverGround.Invoke();
            }
            else
            {
                m_onNoGround.Invoke();
            }
        }

        m_groundPreviousState = thereIsAGround;


    }

    private bool IsThereGround()
    {
        bool isThereGround = Physics.SphereCastAll(m_direction.position, m_radius, m_direction.forward, m_maxDistance, m_whatToLookFor).Length > 0; ;
        Debug.DrawLine(m_direction.position, m_direction.position + (m_direction.forward * m_maxDistance), isThereGround? Color.green:Color.red);
        return isThereGround;
    }
}
