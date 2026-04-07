using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float tiempoRestante = 180f;
    public TextMeshProUGUI textoContador;
    private bool juegoTerminado = false;

    void Update()
    {
        if (juegoTerminado) return;

        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            ActualizarUI();
        }
        else
        {
            CargarEscena("Victoria");
        }
    }

    void ActualizarUI()
    {
        float minutos = Mathf.FloorToInt(tiempoRestante / 60);
        float segundos = Mathf.FloorToInt(tiempoRestante % 60);
        textoContador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void Morir()
    {
        CargarEscena("Derrota");
    }

    void CargarEscena(string nombre)
    {
        juegoTerminado = true;
        SceneManager.LoadScene(nombre);
    }
}
