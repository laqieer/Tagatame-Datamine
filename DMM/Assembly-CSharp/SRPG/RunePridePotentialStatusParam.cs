// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePotentialStatusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D0A")]
  [MessagePackObject(true)]
  public class RunePridePotentialStatusParam
  {
    [Token(Token = "0x40071D7")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40071D8")]
    [FieldOffset(Offset = "0xC")]
    private string needItem;
    [Token(Token = "0x40071D9")]
    [FieldOffset(Offset = "0x10")]
    private List<RunePridePotentialStatusLotteryData> lottery;

    [Token(Token = "0x17000FB7")]
    public string Iname
    {
      [Token(Token = "0x6007742"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FB8")]
    public string NeedItem
    {
      [Token(Token = "0x6007743"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FB9")]
    public List<RunePridePotentialStatusLotteryData> Lottery
    {
      [Token(Token = "0x6007744"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<RunePridePotentialStatusLotteryData>) null;
      }
    }

    [Token(Token = "0x6007745")]
    [Address(RVA = "0x39CD40", Offset = "0x39BB40", VA = "0x1039CD40")]
    public bool Deserialize(JSON_RunePridePotentialStatusParam json) => new bool();

    [Token(Token = "0x6007746")]
    [Address(RVA = "0x39CEE0", Offset = "0x39BCE0", VA = "0x1039CEE0")]
    public static bool Deserialize(
      ref List<RunePridePotentialStatusParam> paramList,
      JSON_RunePridePotentialStatusParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007747")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePotentialStatusParam()
    {
    }
  }
}
