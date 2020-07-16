using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancePF : MonoBehaviour
{
	public GameObject myPrefab;
	public Vector3 Lage;
    GameObject[] Sortiment = new GameObject[5];

	// Start is called before the first frame update
    void Start()
    {
		for (int i = 0; i < 5; i++) {
			Sortiment[i] = Instantiate(myPrefab, Lage + new Vector3(i*1.0f,0f,0f),  Quaternion.identity);	
		}
		Destroy(Sortiment[3]);
    }
}
