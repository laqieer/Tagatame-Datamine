// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED4")]
  public class VersusRankParam
  {
    [Token(Token = "0x40081A2")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x40081A3")]
    [FieldOffset(Offset = "0xC")]
    private VS_MODE mVSMode;
    [Token(Token = "0x40081A4")]
    [FieldOffset(Offset = "0x10")]
    private string mName;
    [Token(Token = "0x40081A5")]
    [FieldOffset(Offset = "0x14")]
    private int mLimit;
    [Token(Token = "0x40081A6")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mBeginAt;
    [Token(Token = "0x40081A7")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mEndAt;
    [Token(Token = "0x40081A8")]
    [FieldOffset(Offset = "0x28")]
    private List<DateTime> mDisableDateList;
    [Token(Token = "0x40081A9")]
    [FieldOffset(Offset = "0x2C")]
    private string mHUrl;

    [Token(Token = "0x170011C0")]
    public int Id
    {
      [Token(Token = "0x6007E23"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011C1")]
    public VS_MODE VSMode
    {
      [Token(Token = "0x6007E24"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new VS_MODE();
      }
    }

    [Token(Token = "0x170011C2")]
    public string Name
    {
      [Token(Token = "0x6007E25"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011C3")]
    public int Limit
    {
      [Token(Token = "0x6007E26"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011C4")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007E27"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170011C5")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007E28"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170011C6")]
    public IList<DateTime> DisableDateList
    {
      [Token(Token = "0x6007E29"), Address(RVA = "0x3FB4A0", Offset = "0x3FA2A0", VA = "0x103FB4A0")] get
      {
        return (IList<DateTime>) null;
      }
    }

    [Token(Token = "0x170011C7")]
    public string HelpURL
    {
      [Token(Token = "0x6007E2A"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007E2B")]
    [Address(RVA = "0x3FB210", Offset = "0x3FA010", VA = "0x103FB210")]
    public bool Deserialize(JSON_VersusRankParam json) => new bool();

    [Token(Token = "0x6007E2C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankParam()
    {
    }
  }
}
