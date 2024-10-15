// Decompiled with JetBrains decompiler
// Type: RichBitmapText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002CB")]
public class RichBitmapText : BitmapText
{
  [Token(Token = "0x4000B95")]
  [FieldOffset(Offset = "0xAC")]
  public Color32 TopColor;
  [Token(Token = "0x4000B96")]
  [FieldOffset(Offset = "0xB0")]
  public Color32 BottomColor;
  [Token(Token = "0x4000B97")]
  [FieldOffset(Offset = "0xB4")]
  [Range(-1f, 1f)]
  public float Shear;

  [Token(Token = "0x6000E8E")]
  [Address(RVA = "0x11D2000", Offset = "0x11D0E00", VA = "0x111D2000")]
  private static Color32 Multiply(Color32 x, Color32 y) => new Color32();

  [Token(Token = "0x6000E8F")]
  [Address(RVA = "0x11D6FE0", Offset = "0x11D5DE0", VA = "0x111D6FE0", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper toFill)
  {
  }

  [Token(Token = "0x6000E90")]
  [Address(RVA = "0x11D7490", Offset = "0x11D6290", VA = "0x111D7490")]
  public RichBitmapText()
  {
  }
}
