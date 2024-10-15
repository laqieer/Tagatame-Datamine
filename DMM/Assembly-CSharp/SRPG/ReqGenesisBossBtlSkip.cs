// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGenesisBossBtlSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031F8")]
  public class ReqGenesisBossBtlSkip : WebAPI
  {
    [Token(Token = "0x600DE94")]
    [Address(RVA = "0xA98830", Offset = "0xA97630", VA = "0x10A98830")]
    public ReqGenesisBossBtlSkip(
      string area_id,
      string qid,
      QuestDifficulties difficulty,
      int ticket,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x20031F9")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDC5")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EDC6")]
      [FieldOffset(Offset = "0xC")]
      public string qid;
      [Token(Token = "0x400EDC7")]
      [FieldOffset(Offset = "0x10")]
      public int difficulty;
      [Token(Token = "0x400EDC8")]
      [FieldOffset(Offset = "0x14")]
      public int ticket;

      [Token(Token = "0x600DE95")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
