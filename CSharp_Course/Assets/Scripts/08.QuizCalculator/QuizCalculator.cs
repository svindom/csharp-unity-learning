using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float[] _quizes = new float[5];

    // Start is called before the first frame update
    void Start()
    {
        float total = 0;

        for (int i = 0; i < _quizes.Length; i++)
        {
            _quizes[i] = RandomValue();
            total += _quizes[i];
        }
        
        // Calculate the average
        float average = total / _quizes.Length;
        average = Mathf.Round(average *100f) / 100f;

        Debug.Log("Average: " + average);
    }

    float RandomValue ()
    {
        float randomQuizValue = Random.Range(0f, 100f);
        return randomQuizValue;
    }
}
