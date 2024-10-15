// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGenesisBossBtlReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031EC")]
  public class ReqGenesisBossBtlReq : WebAPI
  {
    [Token(Token = "0x600DE88")]
    [Address(RVA = "0xA98660", Offset = "0xA97460", VA = "0x10A98660")]
    public ReqGenesisBossBtlReq(
      string area_id,
      string qid,
      QuestDifficulties difficulty,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031ED")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDAA")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EDAB")]
      [FieldOffset(Offset = "0xC")]
      public string qid;
      [Token(Token = "0x400EDAC")]
      [FieldOffset(Offset = "0x10")]
      public int difficulty;

      [Token(Token = "0x600DE89")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
