// Decompiled with JetBrains decompiler
// Type: SRPG.UnitCursor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E13")]
  [AddComponentMenu("Battle/UnitCursor")]
  public class UnitCursor : MonoBehaviour
  {
    [Token(Token = "0x4002A5E")]
    [FieldOffset(Offset = "0xC")]
    public float StartScale;
    [Token(Token = "0x4002A5F")]
    [FieldOffset(Offset = "0x10")]
    public float LoopScale;
    [Token(Token = "0x4002A60")]
    [FieldOffset(Offset = "0x14")]
    public float EndScale;
    [Token(Token = "0x4002A61")]
    [FieldOffset(Offset = "0x18")]
    public float Opacity;
    [Token(Token = "0x4002A62")]
    [FieldOffset(Offset = "0x1C")]
    public float FadeTime;
    [Token(Token = "0x4002A63")]
    [FieldOffset(Offset = "0x20")]
    private float mCurrentScale;
    [Token(Token = "0x4002A64")]
    [FieldOffset(Offset = "0x24")]
    private float mTime;
    [Token(Token = "0x4002A65")]
    [FieldOffset(Offset = "0x28")]
    private float mDuration;
    [Token(Token = "0x4002A66")]
    [FieldOffset(Offset = "0x2C")]
    private float mDesiredScale;
    [Token(Token = "0x4002A67")]
    [FieldOffset(Offset = "0x30")]
    private float mStartScale;
    [Token(Token = "0x4002A68")]
    [FieldOffset(Offset = "0x34")]
    private bool mDiscard;
    [Token(Token = "0x4002A69")]
    [FieldOffset(Offset = "0x38")]
    private Color mColor;
    [Token(Token = "0x4002A6A")]
    [FieldOffset(Offset = "0x48")]
    private float mCurrentOpacity;
    [Token(Token = "0x4002A6B")]
    [FieldOffset(Offset = "0x4C")]
    private float mStartOpacity;
    [Token(Token = "0x4002A6C")]
    [FieldOffset(Offset = "0x50")]
    private float mDesiredOpacity;

    [Token(Token = "0x6003A04")]
    [Address(RVA = "0x10C8B50", Offset = "0x10C7950", VA = "0x110C8B50")]
    private void Start()
    {
    }

    [Token(Token = "0x17000424")]
    public Color Color
    {
      [Token(Token = "0x6003A05"), Address(RVA = "0x3057F0", Offset = "0x3045F0", VA = "0x103057F0")] set
      {
      }
    }

    [Token(Token = "0x6003A06")]
    [Address(RVA = "0x10C8BA0", Offset = "0x10C79A0", VA = "0x110C8BA0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003A07")]
    [Address(RVA = "0x10C8B10", Offset = "0x10C7910", VA = "0x110C8B10")]
    public void FadeOut()
    {
    }

    [Token(Token = "0x6003A08")]
    [Address(RVA = "0x10C8AD0", Offset = "0x10C78D0", VA = "0x110C8AD0")]
    private void AnimateScale(float endScale, float opacity, float time, bool destroyLater)
    {
    }

    [Token(Token = "0x6003A09")]
    [Address(RVA = "0x10C8DF0", Offset = "0x10C7BF0", VA = "0x110C8DF0")]
    public UnitCursor()
    {
    }
  }
}
