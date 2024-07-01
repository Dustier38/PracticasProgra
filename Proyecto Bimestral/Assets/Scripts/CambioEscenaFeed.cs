using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaFeed : MonoBehaviour
{
    public void CambiarAEscenaPop()
    {
        SceneManager.LoadScene("AudioPlayer");
    }

    public void CambiarAEscenaHighway()
    {
        SceneManager.LoadScene("AudioPlayer 1");
    }

    public void CambiarAEscenaTheLovers()
    {
        SceneManager.LoadScene("AudioPlayer 2");
    }

    public void CambiarAEscenaRenewedClassics()
    {
        SceneManager.LoadScene("AudioPlayer 3");
    }

    public void CambiarAEscenaALittleLouder()
    {
        SceneManager.LoadScene("AudioPlayer 4");
    }
}
