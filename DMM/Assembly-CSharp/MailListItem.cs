// Decompiled with JetBrains decompiler
// Type: MailListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002BE")]
[AddComponentMenu("UI/MailListItem")]
public class MailListItem : MonoBehaviour
{
  [Token(Token = "0x4000B64")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private GameObject limit;
  [Token(Token = "0x4000B65")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private GameObject button;
  [Token(Token = "0x4000B66")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private Text timeText;
  [Token(Token = "0x4000B67")]
  [FieldOffset(Offset = "0x18")]
  private ListItemEvents _listItemEvents;

  [Token(Token = "0x170001B9")]
  public ListItemEvents listItemEvents
  {
    [Token(Token = "0x6000E64"), Address(RVA = "0x11D5400", Offset = "0x11D4200", VA = "0x111D5400")] get
    {
      return (ListItemEvents) null;
    }
  }

  [Token(Token = "0x170001BA")]
  public GameObject Button
  {
    [Token(Token = "0x6000E65"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
    {
      return (GameObject) null;
    }
  }

  [Token(Token = "0x6000E66")]
  [Address(RVA = "0x11D5330", Offset = "0x11D4130", VA = "0x111D5330")]
  public void Set(bool isPeriod, bool isRead, long post_at, long read)
  {
  }

  [Token(Token = "0x6000E67")]
  [Address(RVA = "0x11D4F10", Offset = "0x11D3D10", VA = "0x111D4F10")]
  private void SetTime(long time)
  {
  }

  [Token(Token = "0x6000E68")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public MailListItem()
  {
  }
}
