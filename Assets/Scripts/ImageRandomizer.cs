using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRandomizer : MonoBehaviour
{
    [SerializeField] SpriteRenderer randomSpriteRenderer;
    [SerializeField] Sprite[] randomSprites; // 画像を設定する配列

    [SerializeField] float timeBetweenChange = 0.2f; // 画像を切り替えるまでの時間
    [SerializeField] float timeUntilStopping = 3.0f; // ランダム表示を終了する時間

    private int RandomImageIndex = 0; // 現在表示している画像のindex
    private float ImageChangeTimer; // 画像が切り替わるまでの残り時間

    // Start is called before the first frame update
    void Start()
    {
        ImageChangeTimer = timeBetweenChange;
    }

    // Update is called once per frame
    void Update()
    {
        ImageChangeTimer -= Time.deltaTime;
        timeUntilStopping -= Time.deltaTime;

        if (timeUntilStopping <= 0.0f)
        {
            // ランダムで画像を選択
            randomSpriteRenderer.sprite = randomSprites[Random.Range(0, randomSprites.Length)];

            // スクリプトを止める
            DestroyImmediate(this);

            return;
        }

        if (ImageChangeTimer <= 0.0f)
        {
            RandomImageIndex++;

            if (RandomImageIndex >= randomSprites.Length)
            {
                RandomImageIndex = 0;
            }

            // 次の画像に変更
            randomSpriteRenderer.sprite = randomSprites[RandomImageIndex];

            // 画像切り替えタイマーをリセット
            ImageChangeTimer = timeBetweenChange;
        }
    }
}
