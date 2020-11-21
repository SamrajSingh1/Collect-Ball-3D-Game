using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGen : MonoBehaviour
{
	public  GameObject genThisObject;
	
    // Start is called before the first frame update
    void Start()
    {
        int t=Random.Range(5,15);
		Invoke("EndThis",60);
		Invoke("genObject",t);
    }
	
	void genObject(){
	 Instantiate(genThisObject,transform.position,Quaternion.identity);
	 int t=Random.Range(5,15);
	 Invoke("genObject",t);
	 
	}
	void EndThis(){
	Time.timeScale=0;
	}
}
