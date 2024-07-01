using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void CambiarAEscenaCalculadora()
    {
        SceneManager.LoadScene("Calculadora");
    }

    public void CambiarAEscenaAudioPlayer()
    {
        SceneManager.LoadScene("AudioPlayer");
    }

    public void CambiarAEscenaInicioSesion()
    {
        SceneManager.LoadScene("InicioSesión");
    }

    public void CambiarAEscenaPasteles()
    {
        SceneManager.LoadScene("Pasteles");
    }

    public void CambiarAEscenaVideoPlayer()
    {
        SceneManager.LoadScene("Video");
    }

    public void CambiarAEscenaSelectorEscena()
    {
        SceneManager.LoadScene("CambiodeEscena");
    }
}

