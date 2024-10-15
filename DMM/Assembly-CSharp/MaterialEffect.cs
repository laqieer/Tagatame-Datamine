// Decompiled with JetBrains decompiler
// Type: MaterialEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000025")]
[ExecuteInEditMode]
[AddComponentMenu("Camera/MaterialEffect")]
public class MaterialEffect : MonoBehaviour
{
  [Token(Token = "0x4000094")]
  [FieldOffset(Offset = "0xC")]
  public Material Material;

  [Token(Token = "0x60000CB")]
  [Address(RVA = "0x2C6670", Offset = "0x2C5470", VA = "0x102C6670")]
  private void OnRenderImage(RenderTexture src, RenderTexture dest)
  {
  }

  [Token(Token = "0x60000CC")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public MaterialEffect()
  {
  }
}
