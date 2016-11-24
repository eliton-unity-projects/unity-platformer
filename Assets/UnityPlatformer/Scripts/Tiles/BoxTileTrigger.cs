using UnityEngine;
using System.Collections;

// TODO review memory allocation

namespace UnityPlatformer {
  /// <summary>
  /// Base class for Square trigger (BoxCollider2D)
  /// </summary>
  [RequireComponent (typeof (BoxCollider2D))]
  public class BoxTileTrigger : MonoBehaviour {
    // cache
    internal BoxCollider2D body;
    internal Character[] characters;
    internal int charCount;

    /// <summary>
    /// force BoxCollider2D to be trigger
    /// </summary>
    virtual public void Start() {
      body = GetComponent<BoxCollider2D>();
      body.isTrigger = true;
      if (characters == null) {
        characters = new Character[5];
        charCount = 0;
      }
    }
    /// <summary>
    /// Get real-world-coordinates center
    /// </summary>
    virtual public Vector3 GetCenter() {
      return body.bounds.center;
    }

    /// <summary>
    /// exit all player
    /// </summary>
    virtual public void OnDestroy() {
      while(charCount != 0) {
        CharacterExit(characters[0]);
      }
    }

    /// <summary>
    /// add character to the list
    /// </summary>
    virtual public void CharacterEnter(Character p) {
      if (p == null) return;
      characters[charCount++] = p;
    }

    /// <summary>
    /// remove character from the list
    /// </summary>
    virtual public void CharacterExit(Character p) {
      if (p == null) return;

      bool overwrite = false;
      for (int i = 0; i < charCount; ++i) {
        if (overwrite || characters[i] == p) {
          overwrite = true;
          characters[i] = characters[i + 1];
        }
      }

      if (overwrite) {
        --charCount;
      }
    }
    /// <summary>
    /// if Hitbox with EnterAreas enter -> CharacterEnter
    /// </summary>
    public virtual void OnTriggerEnter2D(Collider2D o) {
      HitBox h = o.GetComponent<HitBox>();
      if (h && h.type == HitBoxType.EnterAreas) {
        CharacterEnter(h.owner.GetComponent<Character>());
      }
    }
    /// <summary>
    /// if Hitbox with EnterAreas leave -> CharacterExit
    /// </summary>
    public virtual void OnTriggerExit2D(Collider2D o) {
      HitBox h = o.GetComponent<HitBox>();
      if (h && h.type == HitBoxType.EnterAreas) {
        CharacterExit(h.owner.GetComponent<Character>());
      }
    }
  }
}