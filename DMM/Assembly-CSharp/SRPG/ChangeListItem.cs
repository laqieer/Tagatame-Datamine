// Decompiled with JetBrains decompiler
// Type: SRPG.ChangeListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002138")]
  [AddComponentMenu("UI/ChangeListItem")]
  public class ChangeListItem : MonoBehaviour
  {
    [Token(Token = "0x40090A0")]
    [FieldOffset(Offset = "0xC")]
    [FourCC]
    public int ID;
    [Token(Token = "0x40090A1")]
    [FieldOffset(Offset = "0x10")]
    public Text Label;
    [Token(Token = "0x40090A2")]
    [FieldOffset(Offset = "0x14")]
    public Text ValOld;
    [Token(Token = "0x40090A3")]
    [FieldOffset(Offset = "0x18")]
    public Text ValNew;
    [Token(Token = "0x40090A4")]
    [FieldOffset(Offset = "0x1C")]
    public Text Diff;

    [Token(Token = "0x6008B6B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChangeListItem()
    {
    }
  }
}
