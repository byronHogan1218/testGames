using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour {
    public GameObject pauseMenu;
    public GameObject winScreen;
    public TMP_Text collectionText;

    private CollectableManager collectableManager;
    void Start() {
        pauseMenu.SetActive(false);
        winScreen.SetActive(false);
        collectableManager = GameObject.FindGameObjectWithTag(Constants.COLLECTABLE_MANAGER_TAG).GetComponent<CollectableManager>();
        if (collectableManager == null) {
            collectionText.enabled = false;
        } else {
            collectionText.enabled = true;
        }

    }

    void Update() {
        //Potential to win and press the escape button in same frame. Should guard against that but not worried for this test game
        if (Input.GetKeyDown(KeyCode.P) && !winScreen.activeInHierarchy) {
            TogglePause();
            TogglePauseMenu();
        }
    }

    public void UpdateCollection(int currentAmount, int maxCollectable) {
        if (!collectionText.enabled) {
            collectionText.enabled = true;
        }
        collectionText.text = currentAmount + "/" + maxCollectable;
    }

    public void ShowWinScreen() {
        //Should we Pause here?
        winScreen.SetActive(true);
    }

    public void TogglePause() {
        if (Time.timeScale == 0) {
            Time.timeScale = 1;
        } else {
            Time.timeScale = 0;
        }
    }

    public void TogglePauseMenu() {
        pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
    }

    public void ResumeGameClick() {
        TogglePauseMenu();
        TogglePause();
    }

    public void LevelSelectClick() {
        SceneManager.LoadScene(Constants.LEVEL_SELECTOR_SCENE);
    }
}
