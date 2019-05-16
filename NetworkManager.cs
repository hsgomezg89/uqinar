using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    
    //public static NetworkManager Instance;
    //public Web web;
    /*
    public void crearAdmin(string username, string email, string clave, Action<Response> response)
    {
        StartCoroutine(Co_crearAdmin(username, email, clave, response));
    }


    public IEnumerator Co_crearAdmin(string username, string email,  string clave, Action<Response> response)
    {
        WWWForm form = new WWWForm();
        form.AddField("Usuario", username);
        form.AddField("Correo", email);
        form.AddField("Clave", clave);

        WWW w = new WWW("http://localhost/UQINAR/crearAdmin.php",form);

        yield return w;
        response(JsonUtility.FromJson<Response>(w.text));
    }*/
        
    }
/*
[ Serializable]
public class Response
{
    public bool done = false;
    public string message = "";
}*/

