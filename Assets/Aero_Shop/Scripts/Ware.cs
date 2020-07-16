using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ware : MonoBehaviour
{
    
	private MASTER myController;
    public int ObjID;
    public float Preis;

    Color basisfarbe;
    Material m_Material;

    void Start()
    {
        myController = MASTER.Instance();
        Renderer rend = GetComponent<Renderer>();
        m_Material = GetComponent<Renderer>().material;
        basisfarbe = m_Material.GetColor("_BaseColor");
    }

    void OnMouseOver()
    {
        m_Material.SetColor("_BaseColor", Color.yellow);
    }


    void OnMouseExit()
    {
        m_Material.SetColor("_BaseColor", basisfarbe);
    }

    void OnMouseDown()
    {
        myController.Kauf(ObjID, Preis);
    }
}
