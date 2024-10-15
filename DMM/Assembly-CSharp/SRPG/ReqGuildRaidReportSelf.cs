// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidReportSelf
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
  [Token(Token = "0x2002F3C")]
  public class ReqGuildRaidReportSelf : WebAPI
  {
    [Token(Token = "0x600DB8D")]
    [Address(RVA = "0xA73280", Offset = "0xA72080", VA = "0x10A73280")]
    public ReqGuildRaidReportSelf(
      int gid,
      int boss_id,
      GuildRaidBattleType battle_type,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F3D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9E6")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9E7")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400E9E8")]
      [FieldOffset(Offset = "0x10")]
      public int battle_type;
      [Token(Token = "0x400E9E9")]
      [FieldOffset(Offset = "0x14")]
      public int page;

      [Token(Token = "0x600DB8E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F3E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9EA")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidReport[] reports;
      [Token(Token = "0x400E9EB")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;

      [Token(Token = "0x600DB8F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
