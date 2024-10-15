// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidRanking
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
  [Token(Token = "0x2003071")]
  public class ReqWorldRaidRanking : WebAPI
  {
    [Token(Token = "0x600DCDB")]
    [Address(RVA = "0xA7D8A0", Offset = "0xA7C6A0", VA = "0x10A7D8A0")]
    public ReqWorldRaidRanking(
      string bossIname,
      int page,
      int lap,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003072")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBEE")]
      [FieldOffset(Offset = "0x8")]
      public string boss_iname;
      [Token(Token = "0x400EBEF")]
      [FieldOffset(Offset = "0xC")]
      public int page;
      [Token(Token = "0x400EBF0")]
      [FieldOffset(Offset = "0x10")]
      public int lap;

      [Token(Token = "0x600DCDC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003073")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBF1")]
      [FieldOffset(Offset = "0x8")]
      public JSON_WorldRaidRankingData[] worldraid_ranking;
      [Token(Token = "0x400EBF2")]
      [FieldOffset(Offset = "0xC")]
      public JSON_WorldRaidRankingData my_info;
      [Token(Token = "0x400EBF3")]
      [FieldOffset(Offset = "0x10")]
      public int total_page;

      [Token(Token = "0x600DCDD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
