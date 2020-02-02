using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayControl : MonoBehaviour
{

    public Camera camera_obj;//Cameraを取得
    private RaycastHit hit;//レイが当たったモノを取得
    public Text Timetext;//タイム
    private float TimeCount;//
    private int HitCount;//当たったカウント
    public Text highScoreText;//ハイスコアテキスト
    private int highScore;//ハイスコア
    private string highScoreKey = "highScore";// PlayerPrefsで保存するためのキー
    //public AudioClip Gunshot;//銃声
    //public AudioClip TargetBreak;//的破壊音
    public AudioClip[] clips;
    public int DeathCount;//的を消した数
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Initialize();
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;
        //// スコアがハイスコアより大きければ
        //if (highScore < HitCount)
        //{
        //    highScore = HitCount;
        //}

        // スコア・ハイスコアを表示する
        //Hittext.text = HitCount.ToString();
        //highScoreText.text = highScore.ToString();
        if (Input.GetMouseButtonDown(0))
        {

            audioSource.PlayOneShot(clips[0]);
            //Ray ray = new Ray(camera_obj.transform.position, transform.forward);

            if (Physics.Raycast(camera_obj.transform.position,transform.forward,out hit,10))
            {
                if (hit.collider.tag == "Target")
                {
                    Destroy(hit.collider.gameObject);
                    audioSource.PlayOneShot(clips[1]);
                    HitCount += 1;//消したカウント
                    Debug.Log(HitCount);
                }

                //Debug.DrawRay(camera_obj.transform.position, transform.forward, Color.blue);
            }
        }

        //Hittext.text = HitCount.ToString();

        //if (HitCount >= DeathCount)
        //{
        //    Timetext.text = TimeCount.ToString("f1");
        //    Debug.Log(TimeCount);
        //    HitCount = 0;
        //}

    }
    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        HitCount = 0;

        // ハイスコアを取得する。保存されてなければ0を取得する。
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }
    // ハイスコアの保存
    public void Save()
    {
        // ハイスコアを保存する
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        // ゲーム開始前の状態に戻す
        Initialize();
    }
}
