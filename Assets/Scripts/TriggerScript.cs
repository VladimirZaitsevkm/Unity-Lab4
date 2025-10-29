using UnityEngine;

public class TriggerScript : MonoBehaviour
{
  private void OnTriggerExit(Collider other)
  {
    if (other.gameObject.layer == LayerMask.NameToLayer("Ghost Ball"))
    {
      Debug.Log($"ћ€ч '{other.gameObject.name}' упал в триггер зону");
    }
  }
}