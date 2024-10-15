// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B6C")]
  public class GvGLeagueParam : GvGMasterParam<JSON_GvGLeagueParam>
  {
    [Token(Token = "0x17000D8E")]
    public string Id
    {
      [Token(Token = "0x6007129"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600712A"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D8F")]
    public string Name
    {
      [Token(Token = "0x600712B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600712C"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000D90")]
    public int MinRate
    {
      [Token(Token = "0x600712D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600712E"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17000D91")]
    public int MaxRate
    {
      [Token(Token = "0x600712F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x6007130"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000D92")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007131"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6007132"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] private set
      {
      }
    }

    [Token(Token = "0x17000D93")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007133"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6007134"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x17000D94")]
    public string Reward
    {
      [Token(Token = "0x6007135"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007136"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x17000D95")]
    public int SpriteKey
    {
      [Token(Token = "0x6007137"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007138"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] private set
      {
      }
    }

    [Token(Token = "0x17000D96")]
    public string LeagueIconSpriteKey
    {
      [Token(Token = "0x6007139"), Address(RVA = "0x372D70", Offset = "0x371B70", VA = "0x10372D70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D97")]
    public string LeagueNameSpriteKey
    {
      [Token(Token = "0x600713A"), Address(RVA = "0x372DC0", Offset = "0x371BC0", VA = "0x10372DC0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D98")]
    public string LeagueBGSpriteKey
    {
      [Token(Token = "0x600713B"), Address(RVA = "0x372D20", Offset = "0x371B20", VA = "0x10372D20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600713C")]
    [Address(RVA = "0x3728C0", Offset = "0x3716C0", VA = "0x103728C0", Slot = "4")]
    public override bool Deserialize(JSON_GvGLeagueParam json) => new bool();

    [Token(Token = "0x600713D")]
    [Address(RVA = "0x372BC0", Offset = "0x3719C0", VA = "0x10372BC0")]
    public static GvGLeagueParam GetGvGLeagueParam(string id) => (GvGLeagueParam) null;

    [Token(Token = "0x600713E")]
    [Address(RVA = "0x372A40", Offset = "0x371840", VA = "0x10372A40")]
    public static GvGLeagueParam GetGvGLeagueParam(int rate) => (GvGLeagueParam) null;

    [Token(Token = "0x600713F")]
    [Address(RVA = "0x3729B0", Offset = "0x3717B0", VA = "0x103729B0")]
    public static List<GvGLeagueParam> GetGvGLeagueParamAll() => (List<GvGLeagueParam>) null;

    [Token(Token = "0x6007140")]
    [Address(RVA = "0x372920", Offset = "0x371720", VA = "0x10372920")]
    public static string GetGvGLeagueId(int rate) => (string) null;

    [Token(Token = "0x6007141")]
    [Address(RVA = "0x372CE0", Offset = "0x371AE0", VA = "0x10372CE0")]
    public GvGLeagueParam()
    {
    }
  }
}
