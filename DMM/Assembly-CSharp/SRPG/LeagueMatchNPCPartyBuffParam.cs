// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchNPCPartyBuffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BBF")]
  [MessagePackObject(true)]
  public class LeagueMatchNPCPartyBuffParam
  {
    [Token(Token = "0x4006A35")]
    [FieldOffset(Offset = "0x8")]
    private string mBuffIname;

    [Token(Token = "0x17000E0B")]
    public string BuffIname
    {
      [Token(Token = "0x6007292"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007293")]
    [Address(RVA = "0x378CC0", Offset = "0x377AC0", VA = "0x10378CC0")]
    public bool Deserialize(JSON_LeagueMatchNPCPartyBuffParam json) => new bool();

    [Token(Token = "0x6007294")]
    [Address(RVA = "0x378F00", Offset = "0x377D00", VA = "0x10378F00")]
    public static bool Deserialize(
      ref List<LeagueMatchNPCPartyBuffParam> paramList,
      JSON_LeagueMatchNPCPartyBuffParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007295")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchNPCPartyBuffParam()
    {
    }
  }
}
