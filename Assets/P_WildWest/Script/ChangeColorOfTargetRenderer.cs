using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfTargetRenderer : MonoBehaviour
{

    public Renderer m_targetRender;


    [ContextMenu("ChangeColorRandomly")]
    public void ChangeColorRandomly() {
        m_targetRender.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
