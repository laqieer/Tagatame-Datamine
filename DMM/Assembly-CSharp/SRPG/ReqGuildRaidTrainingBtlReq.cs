// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidTrainingBtlReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F4F")]
  public class ReqGuildRaidTrainingBtlReq : WebAPI
  {
    [Token(Token = "0x600DBA0")]
    [Address(RVA = "0xA73A70", Offset = "0xA72870", VA = "0x10A73A70")]
    public ReqGuildRaidTrainingBtlReq(
      int round,
      int boss_id,
      int period_id,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002F50")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA07")]
      [FieldOffset(Offset = "0x8")]
      public int round;
      [Token(Token = "0x400EA08")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400EA09")]
      [FieldOffset(Offset = "0x10")]
      public int period_id;

      [Token(Token = "0x600DBA1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
