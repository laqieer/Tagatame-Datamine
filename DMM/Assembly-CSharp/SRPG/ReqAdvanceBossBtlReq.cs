// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdvanceBossBtlReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003218")]
  public class ReqAdvanceBossBtlReq : WebAPI
  {
    [Token(Token = "0x600DEB4")]
    [Address(RVA = "0xA92E10", Offset = "0xA91C10", VA = "0x10A92E10")]
    public ReqAdvanceBossBtlReq(
      string area_id,
      string qid,
      QuestDifficulties difficulty,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003219")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE07")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EE08")]
      [FieldOffset(Offset = "0xC")]
      public string qid;
      [Token(Token = "0x400EE09")]
      [FieldOffset(Offset = "0x10")]
      public int difficulty;

      [Token(Token = "0x600DEB5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
