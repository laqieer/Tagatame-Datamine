// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200313C")]
  public class ReqRankMatchReward : WebAPI
  {
    [Token(Token = "0x600DDD1")]
    [Address(RVA = "0xA8ACE0", Offset = "0xA89AE0", VA = "0x10A8ACE0")]
    public ReqRankMatchReward(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200313D")]
    [Serializable]
    public class RwardResponse
    {
      [Token(Token = "0x400ECE4")]
      [FieldOffset(Offset = "0x8")]
      public string ranking;
      [Token(Token = "0x400ECE5")]
      [FieldOffset(Offset = "0xC")]
      public string type;

      [Token(Token = "0x600DDD2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RwardResponse()
      {
      }
    }

    [Token(Token = "0x200313E")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ECE6")]
      [FieldOffset(Offset = "0x8")]
      public int schedule_id;
      [Token(Token = "0x400ECE7")]
      [FieldOffset(Offset = "0xC")]
      public int score;
      [Token(Token = "0x400ECE8")]
      [FieldOffset(Offset = "0x10")]
      public int rank;
      [Token(Token = "0x400ECE9")]
      [FieldOffset(Offset = "0x14")]
      public int type;
      [Token(Token = "0x400ECEA")]
      [FieldOffset(Offset = "0x18")]
      public ReqRankMatchReward.RwardResponse reward;

      [Token(Token = "0x600DDD3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
