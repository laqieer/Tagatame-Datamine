// Decompiled with JetBrains decompiler
// Type: SoundSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000249")]
public class SoundSettings : ScriptableObject
{
  [Token(Token = "0x40009BF")]
  [FieldOffset(Offset = "0xC")]
  public string Tap;
  [Token(Token = "0x40009C0")]
  [FieldOffset(Offset = "0x10")]
  public string OK;
  [Token(Token = "0x40009C1")]
  [FieldOffset(Offset = "0x14")]
  public string Cancel;
  [Token(Token = "0x40009C2")]
  [FieldOffset(Offset = "0x18")]
  public string Select;
  [Token(Token = "0x40009C3")]
  [FieldOffset(Offset = "0x1C")]
  public string Buzzer;
  [Token(Token = "0x40009C4")]
  [FieldOffset(Offset = "0x20")]
  public string Swipe;
  [Token(Token = "0x40009C5")]
  [FieldOffset(Offset = "0x24")]
  public string ScrollList;
  [Token(Token = "0x40009C6")]
  [FieldOffset(Offset = "0x28")]
  public string WindowPop;
  [Token(Token = "0x40009C7")]
  [FieldOffset(Offset = "0x2C")]
  public string WindowClose;
  [Token(Token = "0x40009C8")]
  public const float BGMCrossFadeTime = 1f;
  [Token(Token = "0x40009C9")]
  [FieldOffset(Offset = "0x0")]
  private static SoundSettings mInstance;

  [Token(Token = "0x17000171")]
  public static SoundSettings Current
  {
    [Token(Token = "0x6000C2A"), Address(RVA = "0x108A070", Offset = "0x1088E70", VA = "0x1108A070")] get
    {
      return (SoundSettings) null;
    }
  }

  [Token(Token = "0x6000C2B")]
  [Address(RVA = "0x1089F20", Offset = "0x1088D20", VA = "0x11089F20")]
  public SoundSettings()
  {
  }
}
