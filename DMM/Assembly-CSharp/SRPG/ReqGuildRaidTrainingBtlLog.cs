// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidTrainingBtlLog
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
  [Token(Token = "0x2002F58")]
  public class ReqGuildRaidTrainingBtlLog : WebAPI
  {
    [Token(Token = "0x600DBAB")]
    [Address(RVA = "0xA739A0", Offset = "0xA727A0", VA = "0x10A739A0")]
    public ReqGuildRaidTrainingBtlLog(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F59")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA13")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidTrainingBattleLog[] guildraid_training_history_logs;

      [Token(Token = "0x600DBAC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
