using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SophieControll : MonoBehaviour
{
    static Animator anim;

    private static SophieControll mySo;

    public static SophieControll Instance()
    {
        if (!mySo)
        {
            mySo = FindObjectOfType(typeof(SophieControll)) as SophieControll;
        }
        return mySo;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        anim.SetTrigger("Winken");
    }

    public void Reden()
    {
        anim.SetTrigger("Reden");
    }


    // Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetButtonDown("Jump"))
    //    {
    //        anim.SetTrigger("Reden");
    //    }
    //}
}
