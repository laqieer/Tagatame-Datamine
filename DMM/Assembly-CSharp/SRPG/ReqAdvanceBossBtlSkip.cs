// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdvanceBossBtlSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003224")]
  public class ReqAdvanceBossBtlSkip : WebAPI
  {
    [Token(Token = "0x600DEC0")]
    [Address(RVA = "0xA92FE0", Offset = "0xA91DE0", VA = "0x10A92FE0")]
    public ReqAdvanceBossBtlSkip(
      string area_id,
      string qid,
      QuestDifficulties difficulty,
      int ticket,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x2003225")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE22")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EE23")]
      [FieldOffset(Offset = "0xC")]
      public string qid;
      [Token(Token = "0x400EE24")]
      [FieldOffset(Offset = "0x10")]
      public int difficulty;
      [Token(Token = "0x400EE25")]
      [FieldOffset(Offset = "0x14")]
      public int ticket;

      [Token(Token = "0x600DEC1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
