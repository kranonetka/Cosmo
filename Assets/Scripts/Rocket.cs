using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public float force = 500f;

    private Rigidbody2D m_rb;
    private bool m_isLaunched = false;
    private Vector3 m_initPos;

	// Use this for initialization
	void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_rb.isKinematic = true;
        m_initPos = transform.position;
	}
	
    public void Launch()
    {
        m_isLaunched = true;
        m_rb.isKinematic = false;
    }

    public void Reset()
    {
        m_isLaunched = false;
        m_rb.isKinematic = true;
        transform.position = m_initPos;
        m_rb.velocity = Vector3.zero;
    }

    private void FixedUpdate()
    {
        if (m_isLaunched)
        {
            m_rb.AddForce(transform.up * force * Time.fixedDeltaTime);
        }
    }
}
