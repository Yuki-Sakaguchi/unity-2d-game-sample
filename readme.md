# Unity 2D Game sample.
Unity2D超入門講座を読んで作ったサンプルゲーム

* testGame
  * お化けから逃げる
  * キャラクターの４方向移動
  * キャラクターを追いかけ回すオブジェクト
* testGame2
  * クリックしたところにオブジェクトを配置
* testGame3
  * 落ちてくるうにをよける
  * ランダムでオブジェクト（プレハブ）を生成し落下させる
  * 条件を満たしたらゲームオーバー
* testGame4
  * クリックしたところにハンバーガーを落とす（物理演算）
  * 動物を重ねるゲームみたいな感じ
  * 跳ね方を床で制御できる
* testGame5
  * 横スクロール（カメラ追従）
  * 桃を投げる（攻撃的な感じ）
* testGame6
  * 横スクロールで寿司を食べるゲーム
  * 敵にぶつかったらゲームオーバー
  * 寿司を３つ集められたらゲームクリア
  * 条件によってシーンの切り替え
  * 状態をカウントする（UIの表示）
  * Collisionの当たり判定で寿司を取得すると上から踏んだ時に一瞬キャラクターの移動が止まってしまったので、他の方法を探した
  * 衝突とは別に「侵入」というものがあるらしい（ぶつかったかじゃなくて重なったかどうか）
    * https://www.subarunari.com/entry/2017/06/30/163120
  * これを使ってキャラクターの移動を阻止せず寿司を取得できるようにした
  * 最適化はわからないが一応やりたいことができた