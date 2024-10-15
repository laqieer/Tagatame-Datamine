// Decompiled with JetBrains decompiler
// Type: GradientImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B4")]
[AddComponentMenu("UI/Gradient Image")]
public class GradientImage : Image
{
  [Token(Token = "0x4000B3B")]
  [FieldOffset(Offset = "0xB0")]
  public Color32 TopLeft;
  [Token(Token = "0x4000B3C")]
  [FieldOffset(Offset = "0xB4")]
  public Color32 TopRight;
  [Token(Token = "0x4000B3D")]
  [FieldOffset(Offset = "0xB8")]
  public Color32 BottomLeft;
  [Token(Token = "0x4000B3E")]
  [FieldOffset(Offset = "0xBC")]
  public Color32 BottomRight;

  [Token(Token = "0x6000E40")]
  [Address(RVA = "0x11D2080", Offset = "0x11D0E80", VA = "0x111D2080", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper vh)
  {
  }

  [Token(Token = "0x6000E41")]
  [Address(RVA = "0x11D2000", Offset = "0x11D0E00", VA = "0x111D2000")]
  private static Color32 MultiplyColor(Color32 a, Color32 b) => new Color32();

  [Token(Token = "0x6000E42")]
  [Address(RVA = "0x11D2610", Offset = "0x11D1410", VA = "0x111D2610")]
  public GradientImage()
  {
  }
}
