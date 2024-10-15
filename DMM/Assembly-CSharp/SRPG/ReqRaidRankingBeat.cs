// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRankingBeat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FEA")]
  public class ReqRaidRankingBeat : WebAPI
  {
    [Token(Token = "0x600DC40")]
    [Address(RVA = "0xA78DB0", Offset = "0xA77BB0", VA = "0x10A78DB0")]
    public ReqRaidRankingBeat(ReqRaidRankingBeat.RequestParam rp, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FEB")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB22")]
      [FieldOffset(Offset = "0x8")]
      public int page;

      [Token(Token = "0x600DC41")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FEC")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB23")]
      [FieldOffset(Offset = "0x8")]
      public Json_RaidRankingList beat;
      [Token(Token = "0x400EB24")]
      [FieldOffset(Offset = "0xC")]
      public Json_RaidRankingList rescue;

      [Token(Token = "0x600DC42")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
