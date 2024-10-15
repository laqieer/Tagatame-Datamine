// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.CameraShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032D9")]
  public class CameraShake : AnimEvent
  {
    [Token(Token = "0x400EF77")]
    [FieldOffset(Offset = "0x18")]
    public float FrequencyX;
    [Token(Token = "0x400EF78")]
    [FieldOffset(Offset = "0x1C")]
    public float FrequencyY;
    [Token(Token = "0x400EF79")]
    [FieldOffset(Offset = "0x20")]
    public float AmplitudeX;
    [Token(Token = "0x400EF7A")]
    [FieldOffset(Offset = "0x24")]
    public float AmplitudeY;
    [Token(Token = "0x400EF7B")]
    [FieldOffset(Offset = "0x28")]
    [Curve(0.0f, 0.0f, 1f, 1f, true)]
    public AnimationCurve ShakeCurve;

    [Token(Token = "0x600DF82")]
    [Address(RVA = "0xA904B0", Offset = "0xA8F2B0", VA = "0x10A904B0")]
    public Quaternion CalcOffset(float time, float randX, float randY) => new Quaternion();

    [Token(Token = "0x600DF83")]
    [Address(RVA = "0xA90740", Offset = "0xA8F540", VA = "0x10A90740")]
    public CameraShake()
    {
    }
  }
}
