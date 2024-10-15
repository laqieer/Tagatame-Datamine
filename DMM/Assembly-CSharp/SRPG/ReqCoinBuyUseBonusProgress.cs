// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCoinBuyUseBonusProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031E6")]
  public class ReqCoinBuyUseBonusProgress : WebAPI
  {
    [Token(Token = "0x600DE82")]
    [Address(RVA = "0xA96290", Offset = "0xA95090", VA = "0x10A96290")]
    public ReqCoinBuyUseBonusProgress(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031E7")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDA5")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PlayerCoinBuyUseBonusState[] bonus_stats;

      [Token(Token = "0x600DE83")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
