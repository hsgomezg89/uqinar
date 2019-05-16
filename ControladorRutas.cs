using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorRutas : MonoBehaviour
{
    /*[SerializeField] private InputField n_userNameInput = null;
    [SerializeField] private InputField n_emailInput = null;
    [SerializeField] private InputField n_claveInput = null;
    [SerializeField] private Text n_existeText = null;

    private NetworkManager n_networkManager = null;

    public void Awake()
    {
        n_networkManager = GameObject.FindObjectOfType<NetworkManager>();
    }

    public void submitLogin()
    {
        if (n_userNameInput.text == ""||n_emailInput==""||n_claveInput=="")
        {
            n_existeText.text = "Por favor llenar todos los campos";
            return;
        }
        else
        {
            n_networkManager.crearAdmin(n_userNameInput, n_emailInput, n_claveInput, delegate (Response response) {
                n_existeText.text = response.message});
        }

        

    }*/

    public void SelecionarRuta(string nameRuta)
    {
        SceneManager.LoadScene(nameRuta);
    }
    

    
}
