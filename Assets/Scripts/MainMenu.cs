using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void LoadLevelSelector() {
        SceneManager.LoadScene(Constants.LEVEL_SELECTOR_SCENE);
    }

    public void LoadMainMenu() {
        SceneManager.LoadScene(Constants.MAIN_MENU_SCENE);
    }

    public void QuitGame() {
        print("Quitting");
        Application.Quit();
    }
}
