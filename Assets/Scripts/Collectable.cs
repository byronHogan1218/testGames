using UnityEngine;

public class Collectable : MonoBehaviour {
    private CollectableManager collectableManager;
    void Start() {
        collectableManager = GameObject.FindGameObjectWithTag(Constants.COLLECTABLE_MANAGER_TAG).GetComponent<CollectableManager>();
        if (collectableManager == null) {
            print("Collectable Manager missing from Scene. Please add from prefabs");
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag(Constants.PLAYER_TAG)) {
            //The player has picked this up
            collectableManager.AddOne();
            Destroy(this.gameObject);
        }
    }
}
