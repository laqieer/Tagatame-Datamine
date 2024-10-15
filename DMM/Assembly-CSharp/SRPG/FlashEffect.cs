// Decompiled with JetBrains decompiler
// Type: SRPG.FlashEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E2D")]
  [AddComponentMenu("Camera/FlashEffect")]
  public class FlashEffect : MonoBehaviour
  {
    [Token(Token = "0x4002B01")]
    [FieldOffset(Offset = "0xC")]
    private RenderPipeline mTarget;
    [Token(Token = "0x4002B02")]
    [FieldOffset(Offset = "0x10")]
    public float Strength;
    [Token(Token = "0x4002B03")]
    [FieldOffset(Offset = "0x14")]
    public float Duration;
    [Token(Token = "0x4002B04")]
    [FieldOffset(Offset = "0x18")]
    private float mTime;

    [Token(Token = "0x6003A6F")]
    [Address(RVA = "0x10DC240", Offset = "0x10DB040", VA = "0x110DC240")]
    private void Start()
    {
    }

    [Token(Token = "0x6003A70")]
    [Address(RVA = "0x10DC1D0", Offset = "0x10DAFD0", VA = "0x110DC1D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003A71")]
    [Address(RVA = "0x10DC2E0", Offset = "0x10DB0E0", VA = "0x110DC2E0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003A72")]
    [Address(RVA = "0x10DC3A0", Offset = "0x10DB1A0", VA = "0x110DC3A0")]
    public FlashEffect()
    {
    }
  }
}
