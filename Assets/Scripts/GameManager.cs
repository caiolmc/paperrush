using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public AudioSource audio;

    static int points;
    static float distance;

    public TextMeshProUGUI pointsUI;
    public TextMeshProUGUI distanceUI;

    public GameObject TelaFim;

    public TextMeshProUGUI pointsUIFim;
    public TextMeshProUGUI distanceUIFim;

    private AudioSource[] allAudioSources;

    int count = 0;

    void Awake()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }

    // Update is called once per frame
    void Update()
    {
        pointsUI.text = points + "";
        distanceUI.text = distance.ToString("F2");

        ChecaFim();
    }

    private void FixedUpdate()
    {
        distance += 0.02f * PlaneMovement.speed;
    }

    public static void givePoints(bool doublePoints)
    {
        if (doublePoints)
        {
            points += 10;
        }
        else
        {
            points += 5;
        }
    }

    public void ChecaFim()
    {
        if (Colisoes.fim && count == 0)
        {
            TelaFim.SetActive(true);
            pointsUIFim.text = points+"";
            distanceUIFim.text = distance.ToString("F2");

            StopAllAudio();
            audio.Play();
            count++;
        }
    }


    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }





}
