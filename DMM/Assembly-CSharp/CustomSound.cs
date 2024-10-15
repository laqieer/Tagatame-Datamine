// Decompiled with JetBrains decompiler
// Type: CustomSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200009D")]
[AddComponentMenu("Audio/Custom Sound")]
public class CustomSound : MonoBehaviour
{
  [Token(Token = "0x40002FE")]
  [FieldOffset(Offset = "0xC")]
  public CustomSound.EType type;
  [Token(Token = "0x40002FF")]
  [FieldOffset(Offset = "0x10")]
  public string cueID;
  [Token(Token = "0x4000300")]
  [FieldOffset(Offset = "0x14")]
  public bool PlayOnAwake;
  [Token(Token = "0x4000301")]
  [FieldOffset(Offset = "0x15")]
  public bool LoopFlag;
  [Token(Token = "0x4000302")]
  [FieldOffset(Offset = "0x18")]
  public float StopSec;
  [Token(Token = "0x4000303")]
  [FieldOffset(Offset = "0x1C")]
  private bool mPlayAutomatic;
  [Token(Token = "0x4000304")]
  [FieldOffset(Offset = "0x20")]
  private MySound.PlayHandle mPlayHandle;

  [Token(Token = "0x60003CA")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Awake()
  {
  }

  [Token(Token = "0x60003CB")]
  [Address(RVA = "0xB83990", Offset = "0xB82790", VA = "0x10B83990")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60003CC")]
  [Address(RVA = "0xB83950", Offset = "0xB82750", VA = "0x10B83950")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60003CD")]
  [Address(RVA = "0xB84450", Offset = "0xB83250", VA = "0x10B84450")]
  private void Update()
  {
  }

  [Token(Token = "0x60003CE")]
  [Address(RVA = "0xB84350", Offset = "0xB83150", VA = "0x10B84350")]
  public void Play()
  {
  }

  [Token(Token = "0x60003CF")]
  [Address(RVA = "0xB83B10", Offset = "0xB82910", VA = "0x10B83B10")]
  public void Stop()
  {
  }

  [Token(Token = "0x60003D0")]
  [Address(RVA = "0xB84240", Offset = "0xB83040", VA = "0x10B84240")]
  public void Play(float delaySec)
  {
  }

  [Token(Token = "0x60003D1")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public CustomSound()
  {
  }

  [Token(Token = "0x200009E")]
  public enum EType
  {
    [Token(Token = "0x4000306")] SE,
    [Token(Token = "0x4000307")] JINGLE,
  }
}
