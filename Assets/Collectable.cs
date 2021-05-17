using UnityEngine;

public class Collectable : MonoBehaviour {
    private CollectableManager collectableManager;
    void Start() {
        collectableManager = GameObject.FindGameObjectWithTag("CollectableManager").GetComponent<CollectableManager>();
        if (collectableManager == null) {
            print("Collectable Manager missing from Scene. Please add from prefabs");
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            //The player has picked this up
            collectableManager.addOne();
            Destroy(this.gameObject);
        }
    }
}
