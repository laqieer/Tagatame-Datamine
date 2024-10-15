// Decompiled with JetBrains decompiler
// Type: GameObjectID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
[Token(Token = "0x20000E7")]
[AddComponentMenu("Common/GameObjectID")]
public class GameObjectID : MonoBehaviour
{
  [Token(Token = "0x400040B")]
  [FieldOffset(Offset = "0x0")]
  private static Dictionary<string, List<GameObject>> mGameObjects;
  [Token(Token = "0x400040C")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  [HideInInspector]
  [FormerlySerializedAs("ID")]
  private string mID;

  [Token(Token = "0x170000DC")]
  public string ID
  {
    [Token(Token = "0x600057A"), Address(RVA = "0xC71AE0", Offset = "0xC708E0", VA = "0x10C71AE0")] set
    {
    }
    [Token(Token = "0x600057B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x600057C")]
  [Address(RVA = "0xC714C0", Offset = "0xC702C0", VA = "0x10C714C0")]
  public static GameObject FindGameObject(string name) => (GameObject) null;

  [Token(Token = "0x600057D")]
  public static T FindGameObject<T>(string name) where T : Component => (T) null;

  [Token(Token = "0x600057E")]
  [Address(RVA = "0xC715D0", Offset = "0xC703D0", VA = "0x10C715D0")]
  public static GameObject[] FindGameObjects(string name) => (GameObject[]) null;

  [Token(Token = "0x600057F")]
  [Address(RVA = "0xC71710", Offset = "0xC70510", VA = "0x10C71710")]
  private void RegisterInstance()
  {
  }

  [Token(Token = "0x6000580")]
  [Address(RVA = "0xC71880", Offset = "0xC70680", VA = "0x10C71880")]
  private void UnregisterInstance()
  {
  }

  [Token(Token = "0x6000581")]
  [Address(RVA = "0xC714B0", Offset = "0xC702B0", VA = "0x10C714B0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000582")]
  [Address(RVA = "0xC71700", Offset = "0xC70500", VA = "0x10C71700")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000583")]
  [Address(RVA = "0xC71A90", Offset = "0xC70890", VA = "0x10C71A90")]
  public GameObjectID()
  {
  }

  [Token(Token = "0x6000584")]
  [Address(RVA = "0xC71A10", Offset = "0xC70810", VA = "0x10C71A10")]
  static GameObjectID()
  {
  }
}
