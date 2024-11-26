using UnityEngine;

    public class KeyView : MonoBehaviour, IInteractable
    {
        [SerializeField] GameUIView gameUIView;
        public void Interact()
        {
            int currentKeys = GameService.Instance.GetPlayerController().KeysEquipped;
            
            GameService.Instance.GetInstructionView().HideInstruction();
            GameService.Instance.GetSoundView().PlaySoundEffects(SoundType.KeyPickUp);
            currentKeys++;
          // GameService.Instance.GetPlayerController().KeysEquipped++;
           // gameUIView.UpdateKeyText();

           EventService.Instance.OnkeyPickedUp.InvokeEvent(currentKeys);
            gameObject.SetActive(false);
        }
    }


