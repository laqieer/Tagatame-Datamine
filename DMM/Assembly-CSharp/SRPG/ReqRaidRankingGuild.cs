// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRankingGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FF0")]
  public class ReqRaidRankingGuild : WebAPI
  {
    [Token(Token = "0x600DC46")]
    [Address(RVA = "0xA78E80", Offset = "0xA77C80", VA = "0x10A78E80")]
    public ReqRaidRankingGuild(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FF1")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB28")]
      [FieldOffset(Offset = "0x8")]
      public Json_RaidRankingGuildList beat;
      [Token(Token = "0x400EB29")]
      [FieldOffset(Offset = "0xC")]
      public Json_RaidRankingGuildList rescue;

      [Token(Token = "0x600DC47")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
