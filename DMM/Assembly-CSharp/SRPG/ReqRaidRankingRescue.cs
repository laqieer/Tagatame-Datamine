// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRankingRescue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FED")]
  public class ReqRaidRankingRescue : WebAPI
  {
    [Token(Token = "0x600DC43")]
    [Address(RVA = "0xA78F50", Offset = "0xA77D50", VA = "0x10A78F50")]
    public ReqRaidRankingRescue(
      ReqRaidRankingRescue.RequestParam rp,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FEE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB25")]
      [FieldOffset(Offset = "0x8")]
      public int page;

      [Token(Token = "0x600DC44")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FEF")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB26")]
      [FieldOffset(Offset = "0x8")]
      public Json_RaidRankingList beat;
      [Token(Token = "0x400EB27")]
      [FieldOffset(Offset = "0xC")]
      public Json_RaidRankingList rescue;

      [Token(Token = "0x600DC45")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
