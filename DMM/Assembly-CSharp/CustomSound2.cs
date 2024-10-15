// Decompiled with JetBrains decompiler
// Type: CustomSound2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200009F")]
[AddComponentMenu("Audio/Custom Sound2")]
public class CustomSound2 : MonoBehaviour
{
  [Token(Token = "0x4000308")]
  [FieldOffset(Offset = "0xC")]
  public string CueSheet;
  [Token(Token = "0x4000309")]
  [FieldOffset(Offset = "0x10")]
  public string CueName;
  [Token(Token = "0x400030A")]
  [FieldOffset(Offset = "0x14")]
  public bool PlayOnAwake;
  [Token(Token = "0x400030B")]
  [FieldOffset(Offset = "0x15")]
  public bool LoopFlag;
  [Token(Token = "0x400030C")]
  [FieldOffset(Offset = "0x18")]
  public float StopSec;
  [Token(Token = "0x400030D")]
  [FieldOffset(Offset = "0x1C")]
  private bool mPlayAutomatic;
  [Token(Token = "0x400030E")]
  [FieldOffset(Offset = "0x20")]
  private MySound.PlayHandle mPlayHandle;

  [Token(Token = "0x60003D2")]
  [Address(RVA = "0xB83990", Offset = "0xB82790", VA = "0x10B83990")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60003D3")]
  [Address(RVA = "0xB83950", Offset = "0xB82750", VA = "0x10B83950")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60003D4")]
  [Address(RVA = "0xB83B50", Offset = "0xB82950", VA = "0x10B83B50")]
  private void Update()
  {
  }

  [Token(Token = "0x60003D5")]
  [Address(RVA = "0xB839A0", Offset = "0xB827A0", VA = "0x10B839A0")]
  public void Play()
  {
  }

  [Token(Token = "0x60003D6")]
  [Address(RVA = "0xB83B10", Offset = "0xB82910", VA = "0x10B83B10")]
  public void Stop()
  {
  }

  [Token(Token = "0x60003D7")]
  [Address(RVA = "0xB83B70", Offset = "0xB82970", VA = "0x10B83B70")]
  public CustomSound2()
  {
  }
}
