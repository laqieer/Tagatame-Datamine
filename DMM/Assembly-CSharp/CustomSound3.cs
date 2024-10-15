// Decompiled with JetBrains decompiler
// Type: CustomSound3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000A0")]
[AddComponentMenu("Audio/Custom Sound3")]
public class CustomSound3 : MonoBehaviour
{
  [Token(Token = "0x400030F")]
  [FieldOffset(Offset = "0xC")]
  public string sheetName;
  [Token(Token = "0x4000310")]
  [FieldOffset(Offset = "0x10")]
  public string cueID;
  [Token(Token = "0x4000311")]
  [FieldOffset(Offset = "0x14")]
  public CustomSound3.EPlayFunction PlayFunction;
  [Token(Token = "0x4000312")]
  [FieldOffset(Offset = "0x18")]
  public MySound.EType CueSheetHandlePlayCategory;
  [Token(Token = "0x4000313")]
  [FieldOffset(Offset = "0x1C")]
  public MySound.CueSheetHandle.ELoopFlag CueSheetHandlePlayLoopType;
  [Token(Token = "0x4000314")]
  [FieldOffset(Offset = "0x20")]
  public bool PlayOnEnable;
  [Token(Token = "0x4000315")]
  [FieldOffset(Offset = "0x21")]
  private bool mPlayAutomatic;
  [Token(Token = "0x4000316")]
  [FieldOffset(Offset = "0x22")]
  public bool StopOnPlay;
  [Token(Token = "0x4000317")]
  [FieldOffset(Offset = "0x23")]
  public bool StopOnDisable;
  [Token(Token = "0x4000318")]
  [FieldOffset(Offset = "0x24")]
  public float StopSec;
  [Token(Token = "0x4000319")]
  [FieldOffset(Offset = "0x28")]
  public float DelayPlaySec;
  [Token(Token = "0x400031A")]
  [FieldOffset(Offset = "0x2C")]
  private List<CustomSound3.PlayHandles> mHandles;

  [Token(Token = "0x60003D8")]
  [Address(RVA = "0xB83BF0", Offset = "0xB829F0", VA = "0x10B83BF0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60003D9")]
  [Address(RVA = "0xB83BC0", Offset = "0xB829C0", VA = "0x10B83BC0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60003DA")]
  [Address(RVA = "0xB84190", Offset = "0xB82F90", VA = "0x10B84190")]
  private void Update()
  {
  }

  [Token(Token = "0x60003DB")]
  [Address(RVA = "0xB83C00", Offset = "0xB82A00", VA = "0x10B83C00")]
  public void Play()
  {
  }

  [Token(Token = "0x60003DC")]
  [Address(RVA = "0xB83F40", Offset = "0xB82D40", VA = "0x10B83F40")]
  public void Stop()
  {
  }

  [Token(Token = "0x60003DD")]
  [Address(RVA = "0xB841B0", Offset = "0xB82FB0", VA = "0x10B841B0")]
  public CustomSound3()
  {
  }

  [Token(Token = "0x20000A1")]
  public enum EPlayFunction
  {
    [Token(Token = "0x400031C")] CueSheetHandlePlay,
    [Token(Token = "0x400031D")] CueSheetHandlePlayOneShot,
    [Token(Token = "0x400031E")] CueSheetHandlePlayLoop,
    [Token(Token = "0x400031F")] VoicePlay,
    [Token(Token = "0x4000320")] PlaySEOneShot,
    [Token(Token = "0x4000321")] PlaySELoop,
    [Token(Token = "0x4000322")] PlayJingle,
    [Token(Token = "0x4000323")] PlayBGM,
    [Token(Token = "0x4000324")] PlayBGMDelay,
  }

  [Token(Token = "0x20000A2")]
  private class PlayHandles
  {
    [Token(Token = "0x4000325")]
    [FieldOffset(Offset = "0x8")]
    public MySound.PlayHandle mPlayHandle;
    [Token(Token = "0x4000326")]
    [FieldOffset(Offset = "0xC")]
    public MySound.CueSheetHandle mCueSheetHandle;
    [Token(Token = "0x4000327")]
    [FieldOffset(Offset = "0x10")]
    public MySound.Voice mVoice;

    [Token(Token = "0x170000AA")]
    public bool IsValid
    {
      [Token(Token = "0x60003DE"), Address(RVA = "0xB8D8F0", Offset = "0xB8C6F0", VA = "0x10B8D8F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60003DF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayHandles()
    {
    }
  }
}
