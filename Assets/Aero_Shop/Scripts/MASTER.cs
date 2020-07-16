using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;

public class MASTER : MonoBehaviour
{
    public TMP_Text clockText;
    public GameObject Kauf0;
	public GameObject Kauf1;
	public GameObject Kauf2;
	public GameObject Kauf3;
	public GameObject Kauf4;
    public GameObject Kauf5;

    public GameObject Sprechblase;

    private static MASTER myPf;
    private SophieControll Sofie;

    Vector3 Lage;

	int zaehler = 0;
	float Summe = 0;
    float Bandabstand = -0.33f;

    List<GameObject> BandNeu = new List<GameObject>();

	public static MASTER Instance()
	{
		if (!myPf) {
			myPf = FindObjectOfType(typeof (MASTER)) as MASTER;
		}
		return myPf;
	}

    void Start()
    {
        Lage = transform.position;
        Sofie = SophieControll.Instance();
        Sprechblase.SetActive(false);
       // GameObject[] Sortiment = { Kauf0, Kauf1, Kauf2, Kauf3, Kauf4, Kauf5 };
    }

    public void Kauf(int Counter, float Preis)
	{
        GameObject[] Sortiment = { Kauf0, Kauf1, Kauf2, Kauf3, Kauf4, Kauf5 };
        if (BandNeu.Count < 7)
        {
            BandNeu.Add(Instantiate(Sortiment[Counter], Lage + new Vector3(zaehler * Bandabstand, 0f, 0f), transform.rotation));
            zaehler++;
		    Summe += Preis;
		    Debug.Log("€ "+Summe as string);
         }
    }

    public void Katsching()
    {
        Sofie.Reden();
        Sprechblase.SetActive(true);
        StartCoroutine(Wartezeit());
    }

    public void Loeschen(GameObject Obj, float Preis)
	{
        int i;
        Summe -= Preis;
		Debug.Log("€ " + Summe as string);
        BandNeu.Remove(Obj);
        Destroy(Obj);

        i = 0;
        foreach (var x in BandNeu)
        {
            x.transform.position = Lage + new Vector3(i * Bandabstand, 0f, 0f);
            i++;
        }
        zaehler--;
    }

    IEnumerator Wartezeit()
    {
        yield return new WaitForSecondsRealtime(4);
        Sprechblase.SetActive(false);
    }

    void Update()
    {
        clockText.text = Summe.ToString() + " €";
    }
}
