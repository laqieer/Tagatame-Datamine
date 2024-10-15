// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchDefenseBuff
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
  [Token(Token = "0x2002F69")]
  public class ReqLeagueMatchDefenseBuff : WebAPI
  {
    [Token(Token = "0x600DBBC")]
    [Address(RVA = "0xA75C90", Offset = "0xA74A90", VA = "0x10A75C90")]
    public ReqLeagueMatchDefenseBuff(
      ReqLeagueMatchDefenseBuff.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F6A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA2F")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EA30")]
      [FieldOffset(Offset = "0xC")]
      public string[] buffs;

      [Token(Token = "0x600DBBD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F6B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA31")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchDefenseInfo defense_info;

      [Token(Token = "0x600DBBE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
