using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Kasse : MonoBehaviour
{

    AudioSource m_MyAudioSource;
    private MASTER myController;
    Color basisfarbe;
    Material m_Material;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        myController = MASTER.Instance();
        m_Material = GetComponent<Renderer>().material;
        basisfarbe = m_Material.GetColor("_BaseColor");
    }

    void OnMouseOver()
    {
        m_Material.SetColor("_BaseColor", Color.green);
    }

    void OnMouseExit()
    {
        m_Material.SetColor("_BaseColor", basisfarbe);
    }

    void OnMouseDown()
    {
        m_MyAudioSource.Play();
        myController.Katsching();
    }

}
