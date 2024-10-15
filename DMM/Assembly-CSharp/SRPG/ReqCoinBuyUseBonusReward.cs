// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCoinBuyUseBonusReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031E3")]
  public class ReqCoinBuyUseBonusReward : WebAPI
  {
    [Token(Token = "0x600DE7F")]
    [Address(RVA = "0xA96330", Offset = "0xA95130", VA = "0x10A96330")]
    public ReqCoinBuyUseBonusReward(
      string reward_iname,
      int count,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031E4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDA2")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400EDA3")]
      [FieldOffset(Offset = "0xC")]
      public int num;

      [Token(Token = "0x600DE80")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031E5")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDA4")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PlayerCoinBuyUseBonusRewardState[] bonus_rewards;

      [Token(Token = "0x600DE81")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
