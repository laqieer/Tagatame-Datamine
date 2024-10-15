// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003139")]
  public class ReqRankMatchRanking : WebAPI
  {
    [Token(Token = "0x600DDCE")]
    [Address(RVA = "0xA8AC40", Offset = "0xA89A40", VA = "0x10A8AC40")]
    public ReqRankMatchRanking(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200313A")]
    [Serializable]
    public class ResponceRanking
    {
      [Token(Token = "0x400ECDF")]
      [FieldOffset(Offset = "0x8")]
      public int type;
      [Token(Token = "0x400ECE0")]
      [FieldOffset(Offset = "0xC")]
      public int score;
      [Token(Token = "0x400ECE1")]
      [FieldOffset(Offset = "0x10")]
      public int rank;
      [Token(Token = "0x400ECE2")]
      [FieldOffset(Offset = "0x14")]
      public Json_Friend enemy;

      [Token(Token = "0x600DDCF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponceRanking()
      {
      }
    }

    [Token(Token = "0x200313B")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ECE3")]
      [FieldOffset(Offset = "0x8")]
      public ReqRankMatchRanking.ResponceRanking[] rankings;

      [Token(Token = "0x600DDD0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
