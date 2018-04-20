using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour
{
    [SerializeField]
    private GameObject m_prefab;

    private static List<Module> m_placedModules = new List<Module>();

    [SerializeField]
    private bool m_isPlaced = false;

    private bool m_canBePlaced = false;
	
	// Update is called once per frame
	void Update ()
    {
		if (!m_isPlaced)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(Mathf.RoundToInt(mousePos.x), Mathf.RoundToInt(mousePos.y), 0f);
            foreach(var module in m_placedModules)
            {
                if (m_placedModules.Count == 0 || (module.transform.position - transform.position).magnitude < 1f + float.Epsilon)
                {
                    m_canBePlaced = true;
                    break;
                }
            }

        }

        if (Input.GetButtonDown("Fire1") && !m_isPlaced && m_canBePlaced)
        {
            m_isPlaced = true;
            m_placedModules.Add(this);
            Instantiate(m_prefab, transform.position, Quaternion.identity);
        }
	}
}
