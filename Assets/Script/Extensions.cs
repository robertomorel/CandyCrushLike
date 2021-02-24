using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    // -- this transform -> este script referencia a classe Transform
    public static IEnumerator Move(this Transform t, Vector3 pos, float duration)
    {
        // -- Vetor de direção. Posição final - inicial
        Vector3 direction = pos - t.position;

        // -- Distância do deslocamento
        float distance = direction.magnitude; //Vector3.Distance(t.position, pos);

        // -- Por ser apenas um valor de direção, os valores não precisam ser maiores que 1
        // -- Exemplo: se o vetor for (4,3,1), mudará para (1,1,0).
        // -- Precisamos apenas de uma flecha
        direction.Normalize();

        float startTime = 0;

        while (startTime < duration)
        {
            float remainingDistance = distance * Time.deltaTime / duration;
            t.position += direction * remainingDistance;
            startTime += Time.deltaTime;
            yield return null;
        }

        t.position = pos;
    }

    public static IEnumerator Scale(this Transform t, Vector3 scale, float duration)
    {

        Vector3 direction = scale - t.localScale;
        float size = direction.magnitude;

        direction.Normalize();

        float startTime = 0;

        while (startTime < duration)
        {
            float remainingDistance = size * Time.deltaTime / duration;
            t.localScale += direction * remainingDistance;
            startTime += Time.deltaTime;
            yield return null;
        }

        t.localScale = scale;
    }

}
