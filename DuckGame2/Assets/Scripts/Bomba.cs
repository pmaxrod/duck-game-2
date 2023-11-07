using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    [Header("Atributos")]
    [SerializeField] private float temporizador;
    [SerializeField] private bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        Countdown();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(hasExploded);
        if (hasExploded)
        {
            Explode();
        }
    }

    /// <summary>
    /// Corutina que usa el temporizador de la bomba como los segundos que tarda en explotar
    /// </summary>
    /// <returns></returns>
    IEnumerator CountdownRoutine()
    {
        yield return new WaitForSeconds(temporizador);
        hasExploded = true;
    }

    /// <summary>
    /// Inicia la corutina de explosión
    /// </summary>
    private void Countdown()
    {
        StartCoroutine(CountdownRoutine());
    }

    /// <summary>
    /// Explota la bomba
    /// </summary>
    private void Explode()
    {
        Destroy(gameObject);
        // Aquí irían partículas de explosión y efectos de sonido
    }

}
