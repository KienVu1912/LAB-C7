using UnityEngine;
using UnityEngine.SceneManagement; // Cần thiết để chuyển cảnh

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Game Started!");
        // SceneManager.LoadScene("GameScene"); // Sau này dùng để vào game
    }

    public void OpenOptions()
    {
        Debug.Log("Options Menu Opened!");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit(); // Chỉ hoạt động khi đã build ra file .exe/.apk
    }
}