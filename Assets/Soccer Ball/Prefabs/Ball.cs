using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody m_rb = null;

    // Start is called before the first frame update
    void Start()
    {
        if (!m_rb)
            m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(Vector3 vVelocity)
    {
        if (!m_rb)
            m_rb = GetComponent<Rigidbody>();

        //if (m_rb)
        m_rb.velocity = vVelocity;
    }
}
