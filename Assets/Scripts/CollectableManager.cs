using UnityEngine;

public class CollectableManager : MonoBehaviour {
    public int maxCollectable = 1;
    private int currentAmount = 0;
    private PlayerUI playerUI;

    void Start() {
        currentAmount = 0;
        if (maxCollectable <= 0) {
            print("Set the max collectable to the number of collectables needed in the level");
        }
    }

    private bool IsMaxReached() {
        return currentAmount >= maxCollectable;
    }

    public void AddOne() {
        currentAmount++;
        // The player is created on the start of the game, so we need ot find the UI in runtime
        if (playerUI == null) {
            playerUI = GameObject.FindGameObjectWithTag(Constants.PLAYER_TAG).GetComponentInChildren<PlayerUI>();
            playerUI.UpdateCollection(currentAmount, maxCollectable);
        } else {
            playerUI.UpdateCollection(currentAmount, maxCollectable);
        }
        if (IsMaxReached()) {
            // The player is created on the start of the game, so we need ot find the UI in runtime
            if (playerUI == null) {
                playerUI = GameObject.FindGameObjectWithTag(Constants.PLAYER_TAG).GetComponentInChildren<PlayerUI>();
                playerUI.ShowWinScreen();

            } else {
                playerUI.ShowWinScreen();
            }
            print("The game is over");
        }
    }

    public int GetCurrentAmount() {
        return currentAmount;
    }
}
