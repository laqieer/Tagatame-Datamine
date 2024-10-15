// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingCampaign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B39")]
  public class GuildTrainingCampaign
  {
    [Token(Token = "0x40067AC")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x40067AD")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x40067AE")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;
    [Token(Token = "0x40067AF")]
    [FieldOffset(Offset = "0x20")]
    private int mTimeRate;
    [Token(Token = "0x40067B0")]
    [FieldOffset(Offset = "0x24")]
    private int mDropRate;
    [Token(Token = "0x40067B1")]
    [FieldOffset(Offset = "0x28")]
    private string[] mUnitGroupItems;
    [Token(Token = "0x40067B2")]
    [FieldOffset(Offset = "0x2C")]
    private string[] mUnitInames;
    [Token(Token = "0x40067B3")]
    [FieldOffset(Offset = "0x30")]
    private List<string> mTargeUnitInames;

    [Token(Token = "0x17000D2E")]
    public int Id
    {
      [Token(Token = "0x600702A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D2F")]
    public DateTime BeginAt
    {
      [Token(Token = "0x600702B"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000D30")]
    public DateTime EndAt
    {
      [Token(Token = "0x600702C"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000D31")]
    public int TimeRate
    {
      [Token(Token = "0x600702D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D32")]
    public int DropRate
    {
      [Token(Token = "0x600702E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D33")]
    public string[] UnitGroupItems
    {
      [Token(Token = "0x600702F"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17000D34")]
    public string[] UnitInames
    {
      [Token(Token = "0x6007030"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x6007031")]
    [Address(RVA = "0x3719B0", Offset = "0x3707B0", VA = "0x103719B0")]
    public bool Deserialize(JSON_GuildTrainingCampaign json) => new bool();

    [Token(Token = "0x6007032")]
    [Address(RVA = "0x371EE0", Offset = "0x370CE0", VA = "0x10371EE0")]
    public bool IsEnableCampaign() => new bool();

    [Token(Token = "0x6007033")]
    [Address(RVA = "0x371D10", Offset = "0x370B10", VA = "0x10371D10")]
    public bool IsCheckCampaignUnit(string unit_iname) => new bool();

    [Token(Token = "0x6007034")]
    [Address(RVA = "0x371AE0", Offset = "0x3708E0", VA = "0x10371AE0")]
    public static void Deserialize(
      ref List<GuildTrainingCampaign> param,
      JSON_GuildTrainingCampaign[] json)
    {
    }

    [Token(Token = "0x6007035")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingCampaign()
    {
    }
  }
}
