using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
	Material m_Material;
	Color basisfarbe;
    int i;
    public bool Iplus;

	void Start()
	{
		Renderer rend = GetComponent<Renderer>();
		m_Material = GetComponent<Renderer>().material;
		basisfarbe = m_Material.GetColor("_BaseColor");
	}
    
	void OnMouseOver()
	{
		m_Material.SetColor("_BaseColor", Color.cyan);
	}
    

	void OnMouseExit()
	{
		m_Material.SetColor("_BaseColor", basisfarbe);
	}

	void OnMouseDown()
	{
        m_Material.SetColor("_BaseColor", Color.cyan);
        i = 5;
        Iplus = true;
    }

    void Update()
    {

        if (i > 0)
        {
            i = i - 1;
        }
        else
        {
            m_Material.SetColor("_BaseColor", basisfarbe);
        }
    }
}
