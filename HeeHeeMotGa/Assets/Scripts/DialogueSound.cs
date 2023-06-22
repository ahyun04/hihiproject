using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class DialogueSound : MonoBehaviour
{
    //위치 식별
    public RectTransform character0;
    public RectTransform character1;
    public GameObject characterL0;
    public GameObject characterL1;
    int characterLocationTrigger = 0;
    //텍스트
    public Text Character0;
    public Text Character1;
    int soundTrigger = 0;
    //사운드
    private new AudioSource audio;
    public AudioClip walking;
    public AudioClip scream0;
    public AudioClip batNoise;
    public AudioClip run;
    public AudioClip greenAppear;
    // Start is called before the first frame update
    void Start()
    {
        character0 = characterL0.GetComponent<RectTransform>();
        character1 = characterL1.GetComponent<RectTransform>();
        character0.anchoredPosition = new Vector2(-549, 0);
        character1.anchoredPosition = new Vector2(527, 0);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        character0 = characterL0.GetComponent<RectTransform>();
        character1 = characterL1.GetComponent<RectTransform>();
        //사운드 트리거
        if (Character0.text == "다들 일찍 집에 간건가")
        {
            soundTrigger = 1;
        }
        if (Character0.text == "더 어두워지기 전에 빨리 집에 가자..")
        {
            soundTrigger = 2;
        }
        if (Character0.text == "무슨 소리지???")
        {
            soundTrigger = 1;
        }
        if (Character0.text == "어서 집에 가야겠다")
        {
            soundTrigger = 1;
        }
        if (Character0.text == "왜 문이 잠겼지??")
        {
            soundTrigger = 3;
        }
        if (Character1.text == "......")
        {
            soundTrigger = 4;
        }
        if (Character0.text == "저건 또 뭐야 진짜?!")
        {
            soundTrigger = 3;
        }
        if (Character0.text == "이건 또 무슨 소리지..")
        {
            soundTrigger = 5;
        }
        if(Character0.text == "!!!!")
        {
            soundTrigger = 4;
        }
        if(Character0.text == "이런 미친")
        {
            soundTrigger = 4;
        }
        //사운드 재생
        if (soundTrigger == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                audio.PlayOneShot(walking, 0.3f);
                soundTrigger = 0;
            }
        }
        if (soundTrigger == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Character0.text = "BLANK";
                audio.PlayOneShot(scream0, 0.15f);
                soundTrigger = 0;
            }
        }
        if (soundTrigger == 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Character0.text = "BLANK";
                audio.PlayOneShot(batNoise, 0.3f);
                soundTrigger = 0;
            }
        }
        if (soundTrigger == 4)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Character1.text = "BLANK";
                character0.anchoredPosition = new Vector2(2000, 2000);
                character1.anchoredPosition = new Vector2(2000, 2000);
                audio.PlayOneShot(run, 0.3f);
                soundTrigger = 0;
            }
        }
        if (soundTrigger == 5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Character0.text = "BLANK";
                audio.PlayOneShot(greenAppear, 0.3f);
                soundTrigger = 0;
            }
        }
        //위치
        if (Character0.text == "헉..헉...")
        {
            characterLocationTrigger = 1;
        }
        if (characterLocationTrigger == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                character0.anchoredPosition = new Vector2(-549, 0);
                character1.anchoredPosition = new Vector2(527, 0);
                characterLocationTrigger = 0;
            }
        }
    }
}
