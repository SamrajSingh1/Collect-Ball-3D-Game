using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moveBar : MonoBehaviour
{
	public float speed;
	public Text score;
    // Start is called before the first frame update
    void Start()
    {
       score.text="0";
    }

    // Update is called once per frame
    void Update()
    {
             //("Hello"); 
       // Debug.Log(Input.GetAxis("Horizontal"));			 
       float hori=Input.GetAxis("Horizontal");
	    float ver=Input.GetAxis("Vertical");
	   Vector3 movement=new Vector3(hori,ver);
        transform.position+= speed*movement*Time.deltaTime;	   
	}
	private void OnCollisionEnter(Collision other){
		int k=int.Parse(score.text)+1;
		score.text=k.ToString();
		}
		
}
