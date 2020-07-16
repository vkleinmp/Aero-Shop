using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
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
		m_Material.SetColor("_BaseColor", Color.red);
	}
   

	void OnMouseExit()
	{
		m_Material.SetColor("_BaseColor", basisfarbe);
	}
 

	void OnMouseDown()
	{
        Destroy(gameObject);
    }

}
