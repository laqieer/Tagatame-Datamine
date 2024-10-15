// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidGuildStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FF2")]
  public class ReqRaidGuildStats : WebAPI
  {
    [Token(Token = "0x600DC48")]
    [Address(RVA = "0xA78AC0", Offset = "0xA778C0", VA = "0x10A78AC0")]
    public ReqRaidGuildStats(int period_id, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FF3")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB2A")]
      [FieldOffset(Offset = "0x8")]
      public int period_id;

      [Token(Token = "0x600DC49")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FF4")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB2B")]
      [FieldOffset(Offset = "0x8")]
      public Json_RaidGuildInfo my_guild_info;
      [Token(Token = "0x400EB2C")]
      [FieldOffset(Offset = "0xC")]
      public JSON_RaidGuildMember[] member;

      [Token(Token = "0x600DC4A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
