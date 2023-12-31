using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    private Slider slider;

    private void Start()
    {
        
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    { 
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual(float cantidadVida)
    { 
        slider.value = cantidadVida;
    }

    public void InicializarBarraDeVida(float cantidadVida)
    {
        slider = GetComponent<Slider>();
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}
