// Decompiled with JetBrains decompiler
// Type: SRPG.TriggerCameraShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001176")]
  [AddComponentMenu("Common/TriggerCameraShake")]
  public class TriggerCameraShake : MonoBehaviour
  {
    [Token(Token = "0x4003F41")]
    [FieldOffset(Offset = "0xC")]
    public float Duration;
    [Token(Token = "0x4003F42")]
    [FieldOffset(Offset = "0x10")]
    public float FrequencyX;
    [Token(Token = "0x4003F43")]
    [FieldOffset(Offset = "0x14")]
    public float FrequencyY;
    [Token(Token = "0x4003F44")]
    [FieldOffset(Offset = "0x18")]
    public float AmplitudeX;
    [Token(Token = "0x4003F45")]
    [FieldOffset(Offset = "0x1C")]
    public float AmplitudeY;

    [Token(Token = "0x6004A82")]
    [Address(RVA = "0x1212580", Offset = "0x1211380", VA = "0x11212580")]
    private void Start()
    {
    }

    [Token(Token = "0x6004A83")]
    [Address(RVA = "0x1212650", Offset = "0x1211450", VA = "0x11212650")]
    public TriggerCameraShake()
    {
    }
  }
}
