// Decompiled with JetBrains decompiler
// Type: EventCoinListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200029F")]
[AddComponentMenu("UI/EventCoinListItem")]
public class EventCoinListItem : MonoBehaviour
{
  [Token(Token = "0x4000AE1")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private GameObject button;

  [Token(Token = "0x170001AE")]
  public ListItemEvents listItemEvents
  {
    [Token(Token = "0x6000DF6"), Address(RVA = "0x11CE120", Offset = "0x11CCF20", VA = "0x111CE120")] get
    {
      return (ListItemEvents) null;
    }
  }

  [Token(Token = "0x170001AF")]
  public GameObject Button
  {
    [Token(Token = "0x6000DF7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (GameObject) null;
    }
  }

  [Token(Token = "0x6000DF8")]
  [Address(RVA = "0x11CE0C0", Offset = "0x11CCEC0", VA = "0x111CE0C0")]
  public void Set(bool isPeriod, bool isRead, long post_at, long read)
  {
  }

  [Token(Token = "0x6000DF9")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public EventCoinListItem()
  {
  }
}
