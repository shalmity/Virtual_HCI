using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText; // UI Text 객체를 가리킬 변수
    private int score; // 현재 점수를 저장할 변수

    public AudioSource audioSource;
    public AudioClip clip;

    public GameObject foodPrefab;
    private void Start()
    {
        score = 0; // 초기 점수를 0으로 설정
        UpdateScoreText(); // UI 텍스트 업데이트
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target")) // 충돌한 오브젝트가 "Target" 태그를 가지고 있는지 확인
        {
            GameObject food = Instantiate(foodPrefab) as GameObject;
            foodPrefab.transform.position = other.gameObject.transform.position;
            Destroy(other.gameObject);

            score++; // 점수 증가
            
            UpdateScoreText(); // UI 텍스트 업데이트

            audioSource.PlayOneShot(clip, 1.0f);
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); // UI 텍스트 업데이트
    }
}