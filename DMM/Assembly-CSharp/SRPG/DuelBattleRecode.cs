// Decompiled with JetBrains decompiler
// Type: SRPG.DuelBattleRecode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002319")]
  [MessagePackObject(true)]
  [Serializable]
  public class DuelBattleRecode
  {
    [Token(Token = "0x4009C9D")]
    [FieldOffset(Offset = "0x8")]
    private int mBattleTotal;
    [Token(Token = "0x4009C9E")]
    [FieldOffset(Offset = "0xC")]
    private int mWinStreak;
    [Token(Token = "0x4009C9F")]
    [FieldOffset(Offset = "0x10")]
    private int mWinTotal;

    [Token(Token = "0x1700151B")]
    public int BattleTotal
    {
      [Token(Token = "0x60096F5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700151C")]
    public int WinStreak
    {
      [Token(Token = "0x60096F6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700151D")]
    public int WinTotal
    {
      [Token(Token = "0x60096F7"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60096F8")]
    [Address(RVA = "0x596EE0", Offset = "0x595CE0", VA = "0x10596EE0")]
    public bool Deserialize(Json_DuelBattleRecode json) => new bool();

    [Token(Token = "0x60096F9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelBattleRecode()
    {
    }
  }
}
