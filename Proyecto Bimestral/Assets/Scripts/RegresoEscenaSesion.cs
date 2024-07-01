using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegresoEscenaSesion : MonoBehaviour
{
    public void CambiarAEscenaInicioSesion()
    {
        SceneManager.LoadScene("InicioSesión");
    }
}