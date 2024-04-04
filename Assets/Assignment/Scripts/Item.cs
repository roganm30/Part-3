using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum WhichItem { Square, Bow, Shovel, Dagger }

public class Item : MonoBehaviour
{
    public WhichItem correctColour;
    public TextMeshProUGUI scoreTMP;
    public int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Square>(out Square square))
        {
            if (square.Collect() == correctColour || correctColour == WhichItem.Square)
            {
                score++;
            }
        }
    }

    private void Update()
    {
        scoreTMP.text = "Score = " + score.ToString();
    }
}
