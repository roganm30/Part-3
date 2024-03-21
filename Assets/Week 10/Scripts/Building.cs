using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Transform stump;
    public Transform rock;
    public Transform scarecrow;
    float timer = 0f;
    public float speed = 0.2f;

    void Start()
    {
        stump.localScale = Vector3.zero;
        rock.localScale = Vector3.zero;
        scarecrow.localScale = Vector3.zero;
        StartCoroutine(Enlarge());
    }

    IEnumerator Enlarge()
    {
        while (timer < 1f)
        {
            stump.localScale = Vector3.Lerp(stump.localScale, Vector3.one, timer * speed);
            timer += Time.deltaTime;
            yield return null;
        }
        timer = 0f;
        while (timer < 1f)
        {
            rock.localScale = Vector3.Lerp(rock.localScale, Vector3.one, timer * speed);
            timer += Time.deltaTime;
            yield return null;
        }
        timer = 0f;
        while (timer < 1f)
        {
            scarecrow.localScale = Vector3.Lerp(scarecrow.localScale, Vector3.one, timer * speed);
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
