using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaAudio : MonoBehaviour
{
    public void CambiarAEscenaFeed()
    {
        SceneManager.LoadScene("Feed");
    }
}