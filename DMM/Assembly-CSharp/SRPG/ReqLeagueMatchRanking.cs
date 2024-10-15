// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchRanking
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
  [Token(Token = "0x2002F7E")]
  public class ReqLeagueMatchRanking : WebAPI
  {
    [Token(Token = "0x600DBD1")]
    [Address(RVA = "0xA76690", Offset = "0xA75490", VA = "0x10A76690")]
    public ReqLeagueMatchRanking(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F7F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA49")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchRanking[] rankings;
      [Token(Token = "0x400EA4A")]
      [FieldOffset(Offset = "0xC")]
      public JSON_LeagueMatchRanking my_ranking;

      [Token(Token = "0x600DBD2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
