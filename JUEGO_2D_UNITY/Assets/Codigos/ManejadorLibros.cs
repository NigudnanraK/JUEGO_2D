using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class ManejadorLibros : MonoBehaviour
{
    public List<Image> listaImgLibros = new List<Image>();
    public int contadorLibros = 0;

    public UnityEvent jugadorLibros;

    void Start()
    {
        contadorLibros = listaImgLibros.Count;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            contadorLibros++;
            listaImgLibros[contadorLibros].gameObject.SetActive(true);
        }
    }
}
