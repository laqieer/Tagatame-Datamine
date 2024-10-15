// Decompiled with JetBrains decompiler
// Type: GiftItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B0")]
[AddComponentMenu("UI/GiftItem")]
public class GiftItem : MonoBehaviour
{
  [Token(Token = "0x4000B2E")]
  [FieldOffset(Offset = "0xC")]
  public GameObject ConvertGold;
  [Token(Token = "0x4000B2F")]
  [FieldOffset(Offset = "0x10")]
  public Text GoldText;
  [Token(Token = "0x4000B30")]
  [FieldOffset(Offset = "0x14")]
  public Text AmountText;

  [Token(Token = "0x6000E33")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public GiftItem()
  {
  }
}
