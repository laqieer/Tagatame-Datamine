// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaid
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
  [Token(Token = "0x2003060")]
  public class ReqWorldRaid : WebAPI
  {
    [Token(Token = "0x600DCC8")]
    [Address(RVA = "0xA7DBA0", Offset = "0xA7C9A0", VA = "0x10A7DBA0")]
    public ReqWorldRaid(
      int lastLogId,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003061")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBCB")]
      [FieldOffset(Offset = "0x8")]
      public int last_log_id;

      [Token(Token = "0x600DCC9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003062")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBCC")]
      [FieldOffset(Offset = "0x8")]
      public JSON_WorldRaidBossChallengedData[] bosses;
      [Token(Token = "0x400EBCD")]
      [FieldOffset(Offset = "0xC")]
      public JSON_WorldRaidLastAccess last_access;
      [Token(Token = "0x400EBCE")]
      [FieldOffset(Offset = "0x10")]
      public JSON_WorldRaidLogData[] logs;
      [Token(Token = "0x400EBCF")]
      [FieldOffset(Offset = "0x14")]
      public int refresh_wait_sec;
      [Token(Token = "0x400EBD0")]
      [FieldOffset(Offset = "0x18")]
      public int auto_refresh_wait_sec;
      [Token(Token = "0x400EBD1")]
      [FieldOffset(Offset = "0x1C")]
      public int lap;
      [Token(Token = "0x400EBD2")]
      [FieldOffset(Offset = "0x20")]
      public JSON_WorldRaidBattlePoint bp;

      [Token(Token = "0x600DCCA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
