using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerSpawnEventRandomMono : MonoBehaviour
{

    public UnityEvent m_triggerAction;
    public float m_minTime = 3;
    public float m_maxTime = 5;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        while (true) { 
        
            float waitTime = Random.Range(m_minTime, m_maxTime);
            yield return new WaitForSeconds(waitTime);
            yield return new WaitForEndOfFrame();
            m_triggerAction.Invoke();
        }
    }
}
