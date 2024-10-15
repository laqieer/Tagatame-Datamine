// Decompiled with JetBrains decompiler
// Type: FaceAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000E0")]
[ExecuteInEditMode]
[AddComponentMenu("Common/FaceAnimation")]
public class FaceAnimation : MonoBehaviour
{
  [Token(Token = "0x40003E2")]
  [FieldOffset(Offset = "0xC")]
  public bool isNewModel;
  [Token(Token = "0x40003E3")]
  [FieldOffset(Offset = "0x10")]
  public int Columns;
  [Token(Token = "0x40003E4")]
  [FieldOffset(Offset = "0x14")]
  public int Rows;
  [Token(Token = "0x40003E5")]
  [FieldOffset(Offset = "0x18")]
  public int NumTiles;
  [Token(Token = "0x40003E6")]
  [FieldOffset(Offset = "0x1C")]
  [HideInInspector]
  public int HeadMaterialIndex;
  [Token(Token = "0x40003E7")]
  [FieldOffset(Offset = "0x20")]
  [NonSerialized]
  public int Face0;
  [Token(Token = "0x40003E8")]
  [FieldOffset(Offset = "0x24")]
  [NonSerialized]
  public int Face1;
  [Token(Token = "0x40003E9")]
  [FieldOffset(Offset = "0x28")]
  private Material mMaterial;
  [Token(Token = "0x40003EA")]
  [FieldOffset(Offset = "0x2C")]
  public bool PlayAnimation;
  [Token(Token = "0x40003EB")]
  [FieldOffset(Offset = "0x30")]
  public FaceAnimation.FaceAnimationStruct Animation0;
  [Token(Token = "0x40003EC")]
  [FieldOffset(Offset = "0x3C")]
  public FaceAnimation.FaceAnimationStruct Animation1;

  [Token(Token = "0x6000549")]
  [Address(RVA = "0xC70430", Offset = "0xC6F230", VA = "0x10C70430")]
  public void SetAnimation(CurveAsset asset)
  {
  }

  [Token(Token = "0x600054A")]
  [Address(RVA = "0xC701B0", Offset = "0xC6EFB0", VA = "0x10C701B0")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x600054B")]
  [Address(RVA = "0xC704D0", Offset = "0xC6F2D0", VA = "0x10C704D0")]
  private void UpdateAnimation(ref FaceAnimation.FaceAnimationStruct slot)
  {
  }

  [Token(Token = "0x600054C")]
  [Address(RVA = "0xC70270", Offset = "0xC6F070", VA = "0x10C70270")]
  private void OnWillRenderObject()
  {
  }

  [Token(Token = "0x600054D")]
  [Address(RVA = "0xC705A0", Offset = "0xC6F3A0", VA = "0x10C705A0")]
  public FaceAnimation()
  {
  }

  [Token(Token = "0x20000E1")]
  public struct FaceAnimationStruct
  {
    [Token(Token = "0x40003ED")]
    [FieldOffset(Offset = "0x0")]
    public AnimationCurve Curve;
    [Token(Token = "0x40003EE")]
    [FieldOffset(Offset = "0x4")]
    public float Time;
    [Token(Token = "0x40003EF")]
    [FieldOffset(Offset = "0x8")]
    public float Speed;
  }
}
