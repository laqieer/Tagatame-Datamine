// Decompiled with JetBrains decompiler
// Type: Donuts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200029C")]
public class Donuts : Image
{
  [Token(Token = "0x4000AD8")]
  [FieldOffset(Offset = "0xB0")]
  public float MinAngle;
  [Token(Token = "0x4000AD9")]
  [FieldOffset(Offset = "0xB4")]
  public float MaxAngle;
  [Token(Token = "0x4000ADA")]
  [FieldOffset(Offset = "0xB8")]
  public float RadiusMin;
  [Token(Token = "0x4000ADB")]
  [FieldOffset(Offset = "0xBC")]
  public float RadiusMax;
  [Token(Token = "0x4000ADC")]
  [FieldOffset(Offset = "0xC0")]
  public float Step;
  [Token(Token = "0x4000ADD")]
  [FieldOffset(Offset = "0xC4")]
  public float Tiling;

  [Token(Token = "0x6000DE9")]
  [Address(RVA = "0x11CDA10", Offset = "0x11CC810", VA = "0x111CDA10")]
  public void SetRange(float angleMin, float angleMax)
  {
  }

  [Token(Token = "0x6000DEA")]
  [Address(RVA = "0x11CCBC0", Offset = "0x11CB9C0", VA = "0x111CCBC0", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper vh)
  {
  }

  [Token(Token = "0x6000DEB")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "46")]
  public override bool Raycast(Vector2 sp, Camera eventCamera) => new bool();

  [Token(Token = "0x6000DEC")]
  [Address(RVA = "0x11CDA60", Offset = "0x11CC860", VA = "0x111CDA60")]
  public Donuts()
  {
  }
}
