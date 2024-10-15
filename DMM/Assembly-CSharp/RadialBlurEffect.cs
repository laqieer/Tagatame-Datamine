// Decompiled with JetBrains decompiler
// Type: RadialBlurEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000026")]
[ExecuteInEditMode]
[AddComponentMenu("Camera/RadialBlurEffect")]
public class RadialBlurEffect : MonoBehaviour
{
  [Token(Token = "0x4000095")]
  [FieldOffset(Offset = "0xC")]
  public Material BlurMaterial;
  [Token(Token = "0x4000096")]
  [FieldOffset(Offset = "0x10")]
  [Range(0.0f, 1f)]
  public float Strength;
  [Token(Token = "0x4000097")]
  [FieldOffset(Offset = "0x14")]
  public Vector2 Focus;

  [Token(Token = "0x60000CD")]
  [Address(RVA = "0x2C7640", Offset = "0x2C6440", VA = "0x102C7640")]
  private void OnRenderImage(RenderTexture src, RenderTexture dest)
  {
  }

  [Token(Token = "0x60000CE")]
  [Address(RVA = "0x2C7790", Offset = "0x2C6590", VA = "0x102C7790")]
  public RadialBlurEffect()
  {
  }
}
