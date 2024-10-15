// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterRenderEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E2C")]
  [ExecuteInEditMode]
  [RequireComponent(typeof (UnityEngine.Camera))]
  [AddComponentMenu("Camera/CharacterRenderEffect")]
  public class CharacterRenderEffect : MonoBehaviour
  {
    [Token(Token = "0x4002B00")]
    [FieldOffset(Offset = "0xC")]
    public Material RenderMaterial;

    [Token(Token = "0x6003A6B")]
    [Address(RVA = "0x10D87D0", Offset = "0x10D75D0", VA = "0x110D87D0")]
    private void OnPreRender()
    {
    }

    [Token(Token = "0x6003A6C")]
    [Address(RVA = "0x10D8780", Offset = "0x10D7580", VA = "0x110D8780")]
    private void OnPostRender()
    {
    }

    [Token(Token = "0x6003A6D")]
    [Address(RVA = "0x10D8820", Offset = "0x10D7620", VA = "0x110D8820")]
    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
    }

    [Token(Token = "0x6003A6E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CharacterRenderEffect()
    {
    }
  }
}
