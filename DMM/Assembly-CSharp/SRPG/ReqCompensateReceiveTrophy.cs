// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCompensateReceiveTrophy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031E0")]
  public class ReqCompensateReceiveTrophy : WebAPI
  {
    [Token(Token = "0x600DE7C")]
    [Address(RVA = "0xA964A0", Offset = "0xA952A0", VA = "0x10A964A0")]
    public ReqCompensateReceiveTrophy(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031E1")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDA0")]
      [FieldOffset(Offset = "0x8")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EDA1")]
      [FieldOffset(Offset = "0xC")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DE7D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
