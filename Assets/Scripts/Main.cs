using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Cat cat;

    // Update is called once per frame
    void Update()
    {
        // 戻るボタンが押されているかをチェックします
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // アプリを終了します
            Application.Quit();
        }

        if (!cat.enabled && Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            Retry();
        }
        
    }

    // [Retry]ボタンが押されると呼び出されます
    public void Retry()
    {
        // 現在のシーンを初めから実行します
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
