using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、カウントを増やして自分を消す
public class OnTrigger_CountAndHide : MonoBehaviour
{

    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    public int addValue = 1;    // 増加量：Inspectorで指定

    void OnTriggerEnter2D(Collider2D other)
    { // 衝突したとき
        Debug.Log("OnTriggerEnter2D: " + other.gameObject.name);
        // もし、衝突したものの名前が目標オブジェクトだったら
        if (other.gameObject.name == targetObjectName)
        {
            // カウンターの値を増やす
            GameCounter.value = GameCounter.value + addValue;
            // 自分自身を消す
            this.gameObject.SetActive(false);
        }
    }
}
