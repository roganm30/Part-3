using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //this is needed to ensure the ui elements are incorporated into the project properly
using TMPro;

public class Countdown : MonoBehaviour
{
    public Slider clock;
    public float time;
    public float speed = 0.5f; //all of these elements are public in case i want to make quick edits in the unity editor, as well as being able to see them potentially change
                               //makes it easier to find errors
                               //i chose to make the speed less than 1 to give the illusion of a clock without adding too much stress to the player
    Coroutine coroutine;
    public TextMeshProUGUI scoreTMP;
    public float score = 0;


    void Update()
    {
        StartCoroutine(Timer());
    }


    IEnumerator Timer()
    {
        time += Time.deltaTime * speed;
        time = time % 100;
        // i want the time to increase until it reaches 10, eventually ending the game <--- edit: this changed
        clock.value = time;

        yield return null;
    }
}
