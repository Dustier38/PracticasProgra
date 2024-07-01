using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Arreglos : MonoBehaviour
{
    public GameObject panelAlertas;
    public GameObject panelAcceder;
    public string[] textoAlertas;

    public List<string> usuarios = new List<string>();

    public TMP_InputField nombreUsuario;
    public TMP_InputField nombreNuevoUsuario;
    public TMP_Text alertasDisplay;

    void Start()
    {
        usuarios.Add("Gerry");
        usuarios.Add("Alan");
        usuarios.Add("Pepe");
    }

    public void AccederConUsuario()
    {
        if (usuarios.Contains(nombreUsuario.text))
        {
            // Cambiar a la escena 'Feed'
            SceneManager.LoadScene("Feed");

            // Opcionalmente, podrías mantener este script activo al cambiar de escena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[1];
        }
    }

    public void CrearUsuario()
    {
        if (usuarios.Contains(nombreNuevoUsuario.text))
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[2];
        }
        else
        {
            usuarios.Add(nombreNuevoUsuario.text);
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[3];
        }
    }
}
