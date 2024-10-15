// Decompiled with JetBrains decompiler
// Type: Foliage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000E2")]
[AddComponentMenu("Rendering/Batch/Foliage")]
public class Foliage : BatchChunk
{
  [Token(Token = "0x40003F0")]
  [FieldOffset(Offset = "0x14")]
  public Color32 TopColor;
  [Token(Token = "0x40003F1")]
  [FieldOffset(Offset = "0x18")]
  public Color32 BottomColor;

  [Token(Token = "0x600054E")]
  [Address(RVA = "0xC705E0", Offset = "0xC6F3E0", VA = "0x10C705E0", Slot = "4")]
  public override void FillTriangles(
    int baseVertex,
    Vector3[] vertices,
    Vector3[] normals,
    Vector2[] uv,
    Color32[] colors,
    Vector3[] centers,
    int baseIndex,
    int[] indices)
  {
  }

  [Token(Token = "0x600054F")]
  [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
  public Foliage()
  {
  }
}
