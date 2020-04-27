using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 最初のサイズを50%にします
        transform.localScale = Vector3.one * 0.5f;

        // スタート位置を画面の中央にします
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // 左へ進みます(常にネコのx軸方向へ進みます)
        transform.Translate(-0.1f, 0, 0);

        // スペースキー(またはマウスボタン)が押されているかをチェックします
        if (Input.GetKey(KeyCode.Space) || 
            Input.GetKeyDown(KeyCode.JoystickButton0) ||
            Input.GetMouseButton(0))
        {
            // スペースキーが押されていれば...

            // 15度回転します
            transform.Rotate(0, 0, 15);

            // 現在のサイズを取得してから
            Vector3 scale = transform.localScale;
            // サイズを大きくします
            scale.x += 0.1f;
            scale.y += 0.1f;
            transform.localScale = scale;
        }
    }

    // ネコが壁にあたると呼び出されます
    void OnTriggerEnter2D(Collider2D collider)
    {
        // 泣き声を鳴らします
        GetComponent<AudioSource>().Play();

        // このオブジェクトの動きを止めます
        enabled = false;

        // [Retry]ボタンを表示します
        retry.gameObject.SetActive(true);
    }

    // [Retry]ボタン
    public Button retry;
}
