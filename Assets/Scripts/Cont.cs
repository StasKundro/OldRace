using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cont : MonoBehaviour
{
    public static Cont instance;

    public bool[,] grid = new bool[3, 8];
    public GameObject[] obj;
    public float delaySpawn = 2f;
    public int pos = 1;
    private int y = 0;
    private int z = 0;
    public GameObject[] car;
    public AudioClip dead;
    public AudioClip tick;
    public AudioSource sr;

    private int score;
    private int max;
    public TMP_Text scoreText;
    public TMP_Text maxText;

    public void GoStart()
    {
        if (y == 0)
        {
            y++;
            StartCoroutine(loop1(delaySpawn));
        }
    }

    public void GoLeft()
    {
        if(pos > 0)
        {
            pos--;
        }
    }
    public void GoRight()
    {
        if (pos < 2)
        {
            pos++;
        }
    }

    public void Start()
    {
        y = 0;
        score = 0;
        max = PlayerPrefs.GetInt("Max", max);
        maxText.text = max.ToString();
    }

    public void Update()
    {
        if (pos == 0 && grid[0, 0] == true)
        {
            SceneManager.LoadScene("Restart");
        }
        if (pos == 1 && grid[1, 0] == true)
        {
            SceneManager.LoadScene("Restart");
        }
        if (pos == 2 && grid[2, 0] == true)
        {
            SceneManager.LoadScene("Restart");
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (pos > 0)
            {
                pos--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (pos < 2)
            {
                pos++;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (y == 0)
            {
                y++;
                StartCoroutine(loop1(delaySpawn));
            }
        }

        if (pos == 1)
        {
            car[1].SetActive(true);
            car[0].SetActive(false);
            car[2].SetActive(false);
        }
        if (pos == 2)
        {
            car[2].SetActive(true);
            car[0].SetActive(false);
            car[1].SetActive(false);
        }
        if (pos == 0)
        {
            car[0].SetActive(true);
            car[1].SetActive(false);
            car[2].SetActive(false);
        }


        if (grid[0, 7])
        {
            obj[0].SetActive(true);
        }
        else
        {
            obj[0].SetActive(false);
        }
        if (grid[1, 7])
        {
            obj[1].SetActive(true);
        }
        else
        {
            obj[1].SetActive(false);
        }
        if (grid[2, 7])
        {
            obj[2].SetActive(true);
        }
        else
        {
            obj[2].SetActive(false);
        }
        if (grid[0, 6])
        {
            obj[3].SetActive(true);
        }
        else
        {
            obj[3].SetActive(false);
        }
        if (grid[1, 6])
        {
            obj[4].SetActive(true);
        }
        else
        {
            obj[4].SetActive(false);
        }
        if (grid[2, 6])
        {
            obj[5].SetActive(true);
        }
        else
        {
            obj[5].SetActive(false);
        }
        if (grid[0, 5])
        {
            obj[6].SetActive(true);
        }
        else
        {
            obj[6].SetActive(false);
        }
        if (grid[1, 5])
        {
            obj[7].SetActive(true);
        }
        else
        {
            obj[7].SetActive(false);
        }
        if (grid[2, 5])
        {
            obj[8].SetActive(true);
        }
        else
        {
            obj[8].SetActive(false);
        }
        if (grid[0, 4])
        {
            obj[9].SetActive(true);
        }
        else
        {
            obj[9].SetActive(false);
        }
        if (grid[1, 4])
        {
            obj[10].SetActive(true);
        }
        else
        {
            obj[10].SetActive(false);
        }
        if (grid[2, 4])
        {
            obj[11].SetActive(true);
        }
        else
        {
            obj[11].SetActive(false);
        }
        if (grid[0, 3])
        {
            obj[12].SetActive(true);
        }
        else
        {
            obj[12].SetActive(false);
        }
        if (grid[1, 3])
        {
            obj[13].SetActive(true);
        }
        else
        {
            obj[13].SetActive(false);
        }
        if (grid[2, 3])
        {
            obj[14].SetActive(true);
        }
        else
        {
            obj[14].SetActive(false);
        }
        if (grid[0, 2])
        {
            obj[15].SetActive(true);
        }
        else
        {
            obj[15].SetActive(false);
        }
        if (grid[1, 2])
        {
            obj[16].SetActive(true);
        }
        else
        {
            obj[16].SetActive(false);
        }
        if (grid[2, 2])
        {
            obj[17].SetActive(true);
        }
        else
        {
            obj[17].SetActive(false);
        }
        if (grid[0, 1])
        {
            obj[18].SetActive(true);
        }
        else
        {
            obj[18].SetActive(false);
        }
        if (grid[1, 1])
        {
            obj[19].SetActive(true);
        }
        else
        {
            obj[19].SetActive(false);
        }
        if (grid[2, 1])
        {
            obj[20].SetActive(true);
        }
        else
        {
            obj[20].SetActive(false);
        }
        if (grid[0, 0])
        {
            obj[21].SetActive(true);
        }
        else
        {
            obj[21].SetActive(false);
        }
        if (grid[1, 0])
        {
            obj[22].SetActive(true);
        }
        else
        {
            obj[22].SetActive(false);
        }
        if (grid[2, 0])
        {
            obj[23].SetActive(true);
        }
        else
        {
            obj[23].SetActive(false);
        }
    }

    IEnumerator loop1(float Secs)
    {
        yield return new WaitForSeconds(Secs);

        //------------------------------------------
        if (grid[0, 1] == true)
        {
            grid[0, 0] = true;
        }
        else
        {
            grid[0, 0] = false;
        }

        if (grid[1, 1] == true)
        {
            grid[1, 0] = true;
        }
        else
        {
            grid[1, 0] = false;
        }

        if (grid[2, 1] == true)
        {
            grid[2, 0] = true;
        }
        else
        {
            grid[2, 0] = false;
        }
        //------------------------------------------
        if (grid[0, 2] == true)
        {
            grid[0, 1] = true;
        }
        else
        {
            grid[0, 1] = false;
        }

        if (grid[1, 2] == true)
        {
            grid[1, 1] = true;
        }
        else
        {
            grid[1, 1] = false;
        }

        if (grid[2, 2] == true)
        {
            grid[2, 1] = true;
        }
        else
        {
            grid[2, 1] = false;
        }
        //------------------------------------------
        if (grid[0, 3] == true)
        {
            grid[0, 2] = true;
        }
        else
        {
            grid[0, 2] = false;
        }

        if (grid[1, 3] == true)
        {
            grid[1, 2] = true;
        }
        else
        {
            grid[1, 2] = false;
        }

        if (grid[2, 3] == true)
        {
            grid[2, 2] = true;
        }
        else
        {
            grid[2, 2] = false;
        }
        //------------------------------------------
        if (grid[0, 4] == true)
        {
            grid[0, 3] = true;
        }
        else
        {
            grid[0, 3] = false;
        }

        if (grid[1, 4] == true)
        {
            grid[1, 3] = true;
        }
        else
        {
            grid[1, 3] = false;
        }

        if (grid[2, 4] == true)
        {
            grid[2, 3] = true;
        }
        else
        {
            grid[2, 3] = false;
        }
        //------------------------------------------
        if (grid[0, 5] == true)
        {
            grid[0, 4] = true;
        }
        else
        {
            grid[0, 4] = false;
        }

        if (grid[1, 5] == true)
        {
            grid[1, 4] = true;
        }
        else
        {
            grid[1, 4] = false;
        }

        if (grid[2, 5] == true)
        {
            grid[2, 4] = true;
        }
        else
        {
            grid[2, 4] = false;
        }
        //------------------------------------------
        if (grid[0, 6] == true)
        {
            grid[0, 5] = true;
        }
        else
        {
            grid[0, 5] = false;
        }

        if (grid[1, 6] == true)
        {
            grid[1, 5] = true;
        }
        else
        {
            grid[1, 5] = false;
        }

        if (grid[2, 6] == true)
        {
            grid[2, 5] = true;
        }
        else
        {
            grid[2, 5] = false;
        }
        //------------------------------------------
        if (grid[0, 7] == true)
        {
            grid[0, 6] = true;
        }
        else
        {
            grid[0, 6] = false;
        }

        if (grid[1, 7] == true)
        {
            grid[1, 6] = true;
        }
        else
        {
            grid[1, 6] = false;
        }

        if (grid[2, 7] == true)
        {
            grid[2, 6] = true;
        }
        else
        {
            grid[2, 6] = false;
        }
        //------------------------------------------

        StartCoroutine(loop2(0.01f));
    }
    IEnumerator loop2(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        grid[0, 7] = false;
        grid[1, 7] = false;
        grid[2, 7] = false;
        int x = Random.Range(1, 4);
        if (z == 0)
        {
            sr.PlayOneShot(tick);
            z++;
            if (x == 1)
            {
                grid[0, 7] = true;
            }
            else
            if (x == 2)
            {
                grid[1, 7] = true;
            }
            else
            {
                grid[2, 7] = true;
            }
            score++;
            scoreText.text = score.ToString();
            PlayerPrefs.SetInt("Score", score);
            max = PlayerPrefs.GetInt("Max", max);
            if (max <= score)
            {
                max = score;
                maxText.text = max.ToString();
                PlayerPrefs.SetInt("Max", max);
            }
            if (delaySpawn > 0.1f)
            {
                delaySpawn -= 0.005f;
            }
        }
        else
        {
            z--;
            grid[0, 7] = false;
            grid[1, 7] = false;
            grid[2, 7] = false;
        }

        StartCoroutine(loop1(delaySpawn));
    }
}
