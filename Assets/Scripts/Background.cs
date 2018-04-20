using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private bool m_isPlayMode = false;

    public void PlayMode()
    {
        m_isPlayMode = true;
    }

	void Update ()
    {
        if (!m_isPlayMode)
        {
            transform.position = new Vector3(Mathf.Sin(Time.time * 0.2f) * 5, Mathf.Sin(Time.time * 0.5f) * 0.5f, transform.position.z);
            //transform.position = new Vector3(Mathf.PingPong(Time.time * 0.5f, 10f) - 5f, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(Mathf.SmoothStep(transform.position.x, 0f, 0.2f), transform.position.y, transform.position.z);
        }
	}
}
