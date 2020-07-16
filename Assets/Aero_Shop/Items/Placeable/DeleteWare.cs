using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWare : MonoBehaviour
{
	Material m_Material;
	Color basisfarbe;
	private MASTER myController;
	public float Preis;

	void Start()
	{
		Renderer rend = GetComponent<Renderer>();
		m_Material = GetComponent<Renderer>().material;
		basisfarbe = m_Material.GetColor("_BaseColor");
		myController = MASTER.Instance();
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
        myController.Loeschen(gameObject,Preis);
    }

}
