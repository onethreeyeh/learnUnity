using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howtogetcomponent : MonoBehaviour
{
	private Transform camTransform;
	public GameObject square;
	private Transform squareTransfrom;
    // Start is called before the first frame update
    void Start()
    {
    	square = GameObject.Find("Square");
    	squareTransfrom = square.GetComponent<Transform>();
    	Debug.Log(squareTransfrom.localPosition);
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
