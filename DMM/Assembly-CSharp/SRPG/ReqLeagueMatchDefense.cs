// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchDefense
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
  [Token(Token = "0x2002F63")]
  public class ReqLeagueMatchDefense : WebAPI
  {
    [Token(Token = "0x600DBB6")]
    [Address(RVA = "0xA75E30", Offset = "0xA74C30", VA = "0x10A75E30")]
    public ReqLeagueMatchDefense(
      ReqLeagueMatchDefense.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F64")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA28")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EA29")]
      [FieldOffset(Offset = "0xC")]
      public long[] units;
      [Token(Token = "0x400EA2A")]
      [FieldOffset(Offset = "0x10")]
      public string map;
      [Token(Token = "0x400EA2B")]
      [FieldOffset(Offset = "0x14")]
      public JSON_LeagueMatchSet[] placement;

      [Token(Token = "0x600DBB7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F65")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA2C")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchDefenseInfo defense_info;

      [Token(Token = "0x600DBB8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
