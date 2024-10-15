// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBuffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BB2")]
  [MessagePackObject(true)]
  public class LeagueMatchBuffParam
  {
    [Token(Token = "0x40069FC")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40069FD")]
    [FieldOffset(Offset = "0xC")]
    private LeagueMatchSetBuffParam[] mBuffs;

    [Token(Token = "0x17000DEF")]
    public string Iname
    {
      [Token(Token = "0x6007259"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF0")]
    public LeagueMatchSetBuffParam[] Buffs
    {
      [Token(Token = "0x600725A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (LeagueMatchSetBuffParam[]) null;
      }
    }

    [Token(Token = "0x600725B")]
    [Address(RVA = "0x378700", Offset = "0x377500", VA = "0x10378700")]
    public bool Deserialize(JSON_LeagueMatchBuffParam json) => new bool();

    [Token(Token = "0x600725C")]
    [Address(RVA = "0x378830", Offset = "0x377630", VA = "0x10378830")]
    public static bool Deserialize(
      ref List<LeagueMatchBuffParam> paramList,
      JSON_LeagueMatchBuffParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600725D")]
    [Address(RVA = "0x378AA0", Offset = "0x3778A0", VA = "0x10378AA0")]
    public LeagueMatchSetBuffParam GetBuffParam(string iname) => (LeagueMatchSetBuffParam) null;

    [Token(Token = "0x600725E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchBuffParam()
    {
    }
  }
}
