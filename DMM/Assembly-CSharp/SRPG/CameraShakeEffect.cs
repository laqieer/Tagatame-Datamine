// Decompiled with JetBrains decompiler
// Type: SRPG.CameraShakeEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E2A")]
  [AddComponentMenu("Camera/CameraShakeEffect")]
  public class CameraShakeEffect : MonoBehaviour
  {
    [Token(Token = "0x4002AF6")]
    [FieldOffset(Offset = "0xC")]
    private float mSeedX;
    [Token(Token = "0x4002AF7")]
    [FieldOffset(Offset = "0x10")]
    private float mSeedY;
    [Token(Token = "0x4002AF8")]
    [FieldOffset(Offset = "0x14")]
    private float mTime;
    [Token(Token = "0x4002AF9")]
    [FieldOffset(Offset = "0x18")]
    public float Duration;
    [Token(Token = "0x4002AFA")]
    [FieldOffset(Offset = "0x1C")]
    public float FrequencyX;
    [Token(Token = "0x4002AFB")]
    [FieldOffset(Offset = "0x20")]
    public float FrequencyY;
    [Token(Token = "0x4002AFC")]
    [FieldOffset(Offset = "0x24")]
    public float AmplitudeX;
    [Token(Token = "0x4002AFD")]
    [FieldOffset(Offset = "0x28")]
    public float AmplitudeY;

    [Token(Token = "0x6003A62")]
    [Address(RVA = "0x10D7F40", Offset = "0x10D6D40", VA = "0x110D7F40")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003A63")]
    [Address(RVA = "0x10D8330", Offset = "0x10D7130", VA = "0x110D8330")]
    private void Update()
    {
    }

    [Token(Token = "0x6003A64")]
    [Address(RVA = "0x10D7F70", Offset = "0x10D6D70", VA = "0x110D7F70")]
    private void OnPreCull()
    {
    }

    [Token(Token = "0x6003A65")]
    [Address(RVA = "0x10D83A0", Offset = "0x10D71A0", VA = "0x110D83A0")]
    public CameraShakeEffect()
    {
    }
  }
}
