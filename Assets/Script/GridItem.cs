using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridItem : MonoBehaviour
{

    // -- Informação protegida. A classe atual pode alterar, mas outras classes não.
    // -- Outras classes vão apenas ver
    public int x { get; private set; }
    public int y { get; private set; }

    public int id;

    // -- Método call back
    // -- Chamado em um evento
    public void OnItemPositionChanged(int newX, int newY)
    {
        x = newX;
        y = newY;
        gameObject.name = string.Format("Sprite [{0}] [{1}]", x, y);
    }

    private void OnMouseDown()
    {
        if (OnMouseOverItemEventHandler != null)
        {
            OnMouseOverItemEventHandler(this);
        }
    }

    /*
     Então um delegate em C#, é semelhante a um ponteiro de função (a vantagem é que é um ponteiro seguro). 
     Usando um delegate você pode encapsular a referência a um método dentro de um objeto de delegação.

    O objeto de delegação pode ser passado para o código o qual pode chamar o método referenciado sem ter 
    que saber em tempo de compilação qual método será chamado.
         */
    public delegate void OnMouseOverItem(GridItem item);
    // -- Event: pode receber informações de outros métodos.
    // -- EventHandler é uma assinatura de evento.
    public static event OnMouseOverItem OnMouseOverItemEventHandler;

}
