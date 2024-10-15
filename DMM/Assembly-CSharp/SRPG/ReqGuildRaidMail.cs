// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidMail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F43")]
  public class ReqGuildRaidMail : WebAPI
  {
    [Token(Token = "0x600DB94")]
    [Address(RVA = "0xA728A0", Offset = "0xA716A0", VA = "0x10A728A0")]
    public ReqGuildRaidMail(
      int page,
      int gid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F44")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9F0")]
      [FieldOffset(Offset = "0x8")]
      public int page;
      [Token(Token = "0x400E9F1")]
      [FieldOffset(Offset = "0xC")]
      public int gid;

      [Token(Token = "0x600DB95")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F45")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9F2")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidMail mails;

      [Token(Token = "0x600DB96")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
