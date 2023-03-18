using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallingManagerMono : MonoBehaviour
{
    public List<FallingCaseMono> m_casesThatCanFall;

    public int m_index = 0;

    // Start is called before the first frame update
    void Start()
    {
       Shuffle(m_casesThatCanFall);
    }



    [ContextMenu("MakeFallRandom")]
    public void MakeFallRandom() {
        
        if (m_index >= m_casesThatCanFall.Count)
            return;

        m_casesThatCanFall[m_index].SetAllowToFall(true);
        m_index++;

    }


    void Shuffle(List<FallingCaseMono> a)
    {
        // Loop array
        for (int i = a.Count - 1; i > 0; i--)
        {
            // Randomize a number between 0 and i (so that the range decreases each time)
            int rnd = UnityEngine.Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overwrite when we swap the values
            FallingCaseMono temp = a[i];

            // Swap the new and old values
            a[i] = a[rnd];
            a[rnd] = temp;
        }

        // Print
        for (int i = 0; i < a.Count; i++)
        {
            Debug.Log(a[i]);
        }
    }
}
