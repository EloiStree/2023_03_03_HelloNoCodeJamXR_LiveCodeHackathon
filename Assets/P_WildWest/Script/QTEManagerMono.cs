using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QTEManagerMono : MonoBehaviour
{


    public bool m_currentButtonPressUp;
    public bool m_currentButtonPressDown;

    public bool m_objectiveButtonPressUp;
    public bool m_objectiveButtonPressDown;


    public UnityEvent m_attemptFail;
    public UnityEvent m_attemptSucceed;

    [ContextMenu("Attempt qte")]
    public void AttemptToQTEWithCurrentValue() {

        if (IsQTEIdentical())
            m_attemptSucceed.Invoke();
        else
            m_attemptFail.Invoke();

    }


    public bool IsQTEIdentical () {
        return (m_currentButtonPressUp == m_objectiveButtonPressUp && m_currentButtonPressDown == m_objectiveButtonPressDown);
    }


    public void SetUserButtonUp(bool valueIsTrue)
    {
        m_currentButtonPressUp = valueIsTrue;
    }
    public void SetUserButtonDown(bool valueIsTrue)
    {

        m_currentButtonPressDown = valueIsTrue;
    }
    public void SetGameButtonUp(bool valueIsTrue)
    {

        m_objectiveButtonPressUp = valueIsTrue;
    }
    public void SetGameButtonDown(bool valueIsTrue)
    {

        m_objectiveButtonPressDown = valueIsTrue;
    }
}
