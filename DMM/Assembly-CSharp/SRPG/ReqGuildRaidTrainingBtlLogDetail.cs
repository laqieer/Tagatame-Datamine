// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidTrainingBtlLogDetail
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
  [Token(Token = "0x2002F5A")]
  public class ReqGuildRaidTrainingBtlLogDetail : WebAPI
  {
    [Token(Token = "0x600DBAD")]
    [Address(RVA = "0xA738A0", Offset = "0xA726A0", VA = "0x10A738A0")]
    public ReqGuildRaidTrainingBtlLogDetail(
      int btl_log_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F5B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA14")]
      [FieldOffset(Offset = "0x8")]
      public int btl_log_id;

      [Token(Token = "0x600DBAE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F5C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA15")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidTrainingBattleLog guildraid_training_history_log;

      [Token(Token = "0x600DBAF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
