using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class DialogueSound : MonoBehaviour
{
    //��ġ �ĺ�
    public RectTransform character0;
    public RectTransform character1;
    public GameObject characterL0;
    public GameObject characterL1;
    int characterLocationTrigger = 0;
    //�ؽ�Ʈ
    public Text Character0;
    public Text Character1;
    int soundTrigger = 0;
    //����
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
        //���� Ʈ����
        if (Character0.text == "�ٵ� ���� ���� ���ǰ�")
        {
            soundTrigger = 1;
        }
        if (Character0.text == "�� ��ο����� ���� ���� ���� ����..")
        {
            soundTrigger = 2;
        }
        if (Character0.text == "���� �Ҹ���???")
        {
            soundTrigger = 1;
        }
        if (Character0.text == "� ���� ���߰ڴ�")
        {
            soundTrigger = 1;
        }
        if (Character0.text == "�� ���� �����??")
        {
            soundTrigger = 3;
        }
        if (Character1.text == "......")
        {
            soundTrigger = 4;
        }
        if (Character0.text == "���� �� ���� ��¥?!")
        {
            soundTrigger = 3;
        }
        if (Character0.text == "�̰� �� ���� �Ҹ���..")
        {
            soundTrigger = 5;
        }
        if(Character0.text == "!!!!")
        {
            soundTrigger = 4;
        }
        if(Character0.text == "�̷� ��ģ")
        {
            soundTrigger = 4;
        }
        //���� ���
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
        //��ġ
        if (Character0.text == "��..��...")
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
