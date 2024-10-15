// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchBattleShamEntry
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
  [Token(Token = "0x2002F87")]
  public class ReqLeagueMatchBattleShamEntry : WebAPI
  {
    [Token(Token = "0x600DBDA")]
    [Address(RVA = "0xA75BC0", Offset = "0xA749C0", VA = "0x10A75BC0")]
    public ReqLeagueMatchBattleShamEntry(
      ReqLeagueMatchBattleShamEntry.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F88")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA54")]
      [FieldOffset(Offset = "0x8")]
      public long[] units;
      [Token(Token = "0x400EA55")]
      [FieldOffset(Offset = "0xC")]
      public string map;
      [Token(Token = "0x400EA56")]
      [FieldOffset(Offset = "0x10")]
      public JSON_LeagueMatchSet[] placement;

      [Token(Token = "0x600DBDB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F89")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA57")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchShamInfo defense_sham_info;

      [Token(Token = "0x600DBDC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
