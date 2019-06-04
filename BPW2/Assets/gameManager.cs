using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager manager;
    public Collision collider;
    public static int levelIndex;

    void Start()
    {
        StartCoroutine(WaitToStart());
        StartCoroutine(MoveOverField());
    }

    public static GameManager Manager
    {
        get
        {
            if (manager == null)
                manager = FindObjectOfType<GameManager>();

            return manager;
        }
    }

    IEnumerator WaitToStart()
    {
        print("we wachten");

        yield return new WaitForSeconds(3.0f);

        print("gewacht");
    }

    IEnumerator MoveOverField()
    {
        float timer = .0f;

        while(timer < .5f)
        {
            timer += Time.deltaTime;

            transform.position -= new Vector3(5f * Time.deltaTime, .0f, .0f);

            yield return 0;
        }

        while (timer < 1.5f)
        {
            timer += Time.deltaTime;

            transform.position += new Vector3(5f * Time.deltaTime, .0f, .0f);

            yield return 0;
        }
    }
}
