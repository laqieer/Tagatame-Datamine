// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DA9")]
  public class TrophyState
  {
    [Token(Token = "0x4007621")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007622")]
    [FieldOffset(Offset = "0xC")]
    public int[] Count;
    [Token(Token = "0x4007623")]
    [FieldOffset(Offset = "0x10")]
    public int StartYMD;
    [Token(Token = "0x4007624")]
    [FieldOffset(Offset = "0x18")]
    public DateTime RewardedAt;
    [Token(Token = "0x4007625")]
    [FieldOffset(Offset = "0x20")]
    public TrophyParam Param;
    [Token(Token = "0x4007626")]
    [FieldOffset(Offset = "0x24")]
    public bool IsEnded;
    [Token(Token = "0x4007627")]
    [FieldOffset(Offset = "0x25")]
    public bool IsDirty;
    [Token(Token = "0x4007628")]
    [FieldOffset(Offset = "0x26")]
    public bool IsSending;

    [Token(Token = "0x17001057")]
    public bool IsCompleted
    {
      [Token(Token = "0x600795C"), Address(RVA = "0x3C0260", Offset = "0x3BF060", VA = "0x103C0260")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600795D")]
    [Address(RVA = "0x3C0060", Offset = "0x3BEE60", VA = "0x103C0060")]
    public void Setup(TrophyParam trophyParam, JSON_TrophyProgress trophyProgress)
    {
    }

    [Token(Token = "0x600795E")]
    [Address(RVA = "0x3C0210", Offset = "0x3BF010", VA = "0x103C0210")]
    public TrophyState()
    {
    }
  }
}
