using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowing : MonoBehaviour
{
    public Transform m_target;
    public float m_smoothness = 0.7f;

    private Vector3 m_offset;

    private void Start()
    {
        m_offset = transform.position - m_target.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, m_target.position, m_smoothness) + m_offset;
    }
}
