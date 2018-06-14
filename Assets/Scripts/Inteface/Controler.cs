using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour {
    public GameObject canvas_login;
    public Studient studient;
   	// Use this for initialization
	void Start () {
      
        canvas_login = GameObject.FindGameObjectWithTag("singUp");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void singUp(){
        
        string name = GameObject.FindGameObjectWithTag("NameSingUP").GetComponent<InputField>().text;
        string email = GameObject.FindGameObjectWithTag("EmailSingUp").GetComponent<InputField>().text;
        string pass = GameObject.FindGameObjectWithTag("PassSingUP").GetComponent<InputField>().text;
        studient = new Studient();
        studient.setName(name);
        studient.setMail(email);
        studient.setPassword(pass);
    }


    public void addSchedule(){
        string title= GameObject.FindGameObjectWithTag("TitleSignatureSingUP").GetComponent<InputField>().text;
        string profesor = GameObject.FindGameObjectWithTag("ProfesorSignatureSingUP").GetComponent<InputField>().text;
        int hourBegin = int.Parse(GameObject.FindGameObjectWithTag("HourBeginSignatureSingUP").GetComponent<InputField>().text);
        int hourEnd = int.Parse(GameObject.FindGameObjectWithTag("HourEndSignatureSingUP").GetComponent<InputField>().text);
        studient.addSignature(new Signature(title,profesor,hourBegin,hourEnd));
    }
}
