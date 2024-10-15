// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200313F")]
  public class ReqRankMatchHistory : WebAPI
  {
    [Token(Token = "0x600DDD4")]
    [Address(RVA = "0xA8A980", Offset = "0xA89780", VA = "0x10A8A980")]
    public ReqRankMatchHistory(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003140")]
    [Serializable]
    public class ResponceHistoryResult
    {
      [Token(Token = "0x400ECEB")]
      [FieldOffset(Offset = "0x8")]
      public long time;
      [Token(Token = "0x400ECEC")]
      [FieldOffset(Offset = "0x10")]
      public string result;
      [Token(Token = "0x400ECED")]
      [FieldOffset(Offset = "0x14")]
      public int[] beats;
      [Token(Token = "0x400ECEE")]
      [FieldOffset(Offset = "0x18")]
      public string token;
      [Token(Token = "0x400ECEF")]
      [FieldOffset(Offset = "0x1C")]
      public int beatcnt;

      [Token(Token = "0x600DDD5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponceHistoryResult()
      {
      }
    }

    [Token(Token = "0x2003141")]
    [Serializable]
    public class ResponceHistoryList
    {
      [Token(Token = "0x400ECF0")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400ECF1")]
      [FieldOffset(Offset = "0xC")]
      public int score;
      [Token(Token = "0x400ECF2")]
      [FieldOffset(Offset = "0x10")]
      public int enemyscore;
      [Token(Token = "0x400ECF3")]
      [FieldOffset(Offset = "0x14")]
      public int value;
      [Token(Token = "0x400ECF4")]
      [FieldOffset(Offset = "0x18")]
      public long time_start;
      [Token(Token = "0x400ECF5")]
      [FieldOffset(Offset = "0x20")]
      public long time_end;
      [Token(Token = "0x400ECF6")]
      [FieldOffset(Offset = "0x28")]
      public ReqRankMatchHistory.ResponceHistoryResult result;
      [Token(Token = "0x400ECF7")]
      [FieldOffset(Offset = "0x2C")]
      public Json_Friend enemy;
      [Token(Token = "0x400ECF8")]
      [FieldOffset(Offset = "0x30")]
      public int type;

      [Token(Token = "0x600DDD6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponceHistoryList()
      {
      }
    }

    [Token(Token = "0x2003142")]
    [Serializable]
    public class ResponceHistoryOption
    {
      [Token(Token = "0x400ECF9")]
      [FieldOffset(Offset = "0x8")]
      public int totalPage;

      [Token(Token = "0x600DDD7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponceHistoryOption()
      {
      }
    }

    [Token(Token = "0x2003143")]
    [Serializable]
    public class ResponceHistory
    {
      [Token(Token = "0x400ECFA")]
      [FieldOffset(Offset = "0x8")]
      public ReqRankMatchHistory.ResponceHistoryList[] list;
      [Token(Token = "0x400ECFB")]
      [FieldOffset(Offset = "0xC")]
      public ReqRankMatchHistory.ResponceHistoryOption option;

      [Token(Token = "0x600DDD8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponceHistory()
      {
      }
    }

    [Token(Token = "0x2003144")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ECFC")]
      [FieldOffset(Offset = "0x8")]
      public ReqRankMatchHistory.ResponceHistory histories;

      [Token(Token = "0x600DDD9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
