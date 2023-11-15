using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroInvoke : MonoBehaviour
{
    //se declara una variable float tiempoPasado
    float tiempoPasado;
    //se declara una variable bool corriendo
    bool corriendo;
    
    void Start()
    {
        //se inicia tiempo pasado en 0
        tiempoPasado = 0f;
        //se inicia corriendo en falso
        corriendo = false;
        
    }

    void Update()
    {
        // si se presiona la barra espaciadora y corriendo es falso se entra en la funcion
        if(Input.GetButtonDown("Jump") && corriendo == false)
        {
            //comienza una llamada repetitiva ActualizarCronometro
            InvokeRepeating("ActualizarCronometro",0 ,1);
            //se cambia corriendo a verdadero
            corriendo = true;
        }
        //sino la otra condicion es si se presiona la barra espaciadora y corriendo es verdadero
        else if(Input.GetButtonDown("Jump") && corriendo == true)
        {
            //se cancela la llamada ActualizarCronometro
            CancelInvoke("ActualizarCronometro");
            //se cambia corriendo a falso
            corriendo = false;
        }
    }

    void ActualizarCronometro()
    {
        //a tiempoPasado se le asigna su valor mas 1
        tiempoPasado = tiempoPasado + 1;
        //se declara la variable tiempoPasadoDos y se le asigna el valor de tiempoPasado convertido en cadena de caracteres
        string tiempoPasadoDos = tiempoPasado.ToString("0.00");
        //se manda por consola el valor de tiempoPasadoDos
        Debug.Log("Tiempo transcurrido: " + tiempoPasadoDos);
    }
}
