using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class WildWestGunsToUnityEvent : MonoBehaviour
{
    public WildWestGuns m_myGunsInput;

    public UnityEvent m_onTriggerWasChanged;
    public BooleanUnityEvent m_onButtonUpWasChanged;
    public BooleanUnityEvent m_onButtonDownWasChanged;

    [System.Serializable]
    public class BooleanUnityEvent : UnityEvent<bool> { }


    void Start()
    {
        m_myGunsInput = new WildWestGuns();
        m_myGunsInput.Enable();
        m_myGunsInput.Guns.Enable();
        m_myGunsInput.Guns.TriggerLeft.performed += (k) => m_onTriggerWasChanged.Invoke();
        m_myGunsInput.Guns.TriggerLeft.canceled += (k) => m_onTriggerWasChanged.Invoke();
        m_myGunsInput.Guns.UpButtonLeft.performed += (k) => m_onButtonUpWasChanged.Invoke(true);
        m_myGunsInput.Guns.UpButtonLeft.canceled += (k) => m_onButtonUpWasChanged.Invoke(false);
        m_myGunsInput.Guns.DownButtonLeft.performed += (k) => m_onButtonDownWasChanged.Invoke(true);
        m_myGunsInput.Guns.DownButtonLeft.canceled += (k) => m_onButtonDownWasChanged.Invoke(false);
    }


}
