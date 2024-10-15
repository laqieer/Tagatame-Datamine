// Decompiled with JetBrains decompiler
// Type: SRPG.NotifyListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027C1")]
  [AddComponentMenu("UI/NotifyListItem")]
  public class NotifyListItem : MonoBehaviour
  {
    [Token(Token = "0x400BC44")]
    [FieldOffset(Offset = "0xC")]
    public Text Message;
    [Token(Token = "0x400BC45")]
    [FieldOffset(Offset = "0x10")]
    [NonSerialized]
    public float Lifetime;
    [Token(Token = "0x400BC46")]
    [FieldOffset(Offset = "0x14")]
    [NonSerialized]
    public float Height;

    [Token(Token = "0x600B29B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NotifyListItem()
    {
    }
  }
}
