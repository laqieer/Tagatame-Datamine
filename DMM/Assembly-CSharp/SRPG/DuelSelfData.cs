// Decompiled with JetBrains decompiler
// Type: SRPG.DuelSelfData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002318")]
  [MessagePackObject(true)]
  [Serializable]
  public class DuelSelfData
  {
    [Token(Token = "0x4009C97")]
    [FieldOffset(Offset = "0x8")]
    private int mRank;
    [Token(Token = "0x4009C98")]
    [FieldOffset(Offset = "0xC")]
    private string mPointStr;
    [Token(Token = "0x4009C99")]
    [FieldOffset(Offset = "0x10")]
    private float mPoint;
    [Token(Token = "0x4009C9A")]
    [FieldOffset(Offset = "0x14")]
    private int mBp;
    [Token(Token = "0x4009C9B")]
    [FieldOffset(Offset = "0x18")]
    private DuelBattleRecode mRecode;
    [Token(Token = "0x4009C9C")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mLastBattleAt;

    [Token(Token = "0x17001515")]
    public int Rank
    {
      [Token(Token = "0x60096ED"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001516")]
    public string PointStr
    {
      [Token(Token = "0x60096EE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001517")]
    public int Bp
    {
      [Token(Token = "0x60096EF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001518")]
    public DuelBattleRecode Recode
    {
      [Token(Token = "0x60096F0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (DuelBattleRecode) null;
      }
    }

    [Token(Token = "0x17001519")]
    public DateTime LastBattleAt
    {
      [Token(Token = "0x60096F1"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700151A")]
    public float Point
    {
      [Token(Token = "0x60096F2"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60096F3")]
    [Address(RVA = "0x5A1530", Offset = "0x5A0330", VA = "0x105A1530")]
    public void Deserialize(
      JSON_DuelRankData json_rank,
      int bp,
      Json_DuelBattleRecode recode,
      long btl_at)
    {
    }

    [Token(Token = "0x60096F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelSelfData()
    {
    }
  }
}
