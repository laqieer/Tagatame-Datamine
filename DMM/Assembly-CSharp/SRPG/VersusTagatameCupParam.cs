// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTagatameCupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EE6")]
  public class VersusTagatameCupParam
  {
    [Token(Token = "0x40081F6")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40081F7")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mEndAt;
    [Token(Token = "0x40081F8")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEntryEndAt;
    [Token(Token = "0x40081F9")]
    [FieldOffset(Offset = "0x20")]
    private int mChallengeNum;
    [Token(Token = "0x40081FA")]
    [FieldOffset(Offset = "0x24")]
    private int mNeedWinNum;
    [Token(Token = "0x40081FB")]
    [FieldOffset(Offset = "0x28")]
    private string mDetailUrl;
    [Token(Token = "0x40081FC")]
    [FieldOffset(Offset = "0x2C")]
    private string mEntryUrl;

    [Token(Token = "0x170011D3")]
    public string Iname
    {
      [Token(Token = "0x6007E4F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011D4")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007E50"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170011D5")]
    public DateTime EntryEndAt
    {
      [Token(Token = "0x6007E51"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170011D6")]
    public int ChallengeNum
    {
      [Token(Token = "0x6007E52"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011D7")]
    public int NeedWinNum
    {
      [Token(Token = "0x6007E53"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011D8")]
    public string DetailUrl
    {
      [Token(Token = "0x6007E54"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011D9")]
    public string EntryUrl
    {
      [Token(Token = "0x6007E55"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007E56")]
    [Address(RVA = "0x3FC240", Offset = "0x3FB040", VA = "0x103FC240")]
    public bool Deserialize(JSON_VersusTagatameCupParam _json) => new bool();

    [Token(Token = "0x6007E57")]
    [Address(RVA = "0x3FC020", Offset = "0x3FAE20", VA = "0x103FC020")]
    public static void Deserialize(
      ref List<VersusTagatameCupParam> _param,
      JSON_VersusTagatameCupParam[] _json)
    {
    }

    [Token(Token = "0x6007E58")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusTagatameCupParam()
    {
    }
  }
}
