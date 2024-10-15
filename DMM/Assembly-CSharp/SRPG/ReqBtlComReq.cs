// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlComReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030A8")]
  public class ReqBtlComReq : WebAPI
  {
    [Token(Token = "0x600DD28")]
    [Address(RVA = "0xA832F0", Offset = "0xA820F0", VA = "0x10A832F0")]
    public ReqBtlComReq(
      string iname,
      string fuid,
      SupportData support,
      Network.ResponseCallback response,
      bool multi,
      int partyIndex,
      bool isHost = false,
      int plid = 0,
      int seat = 0,
      Vector2 location = default (Vector2),
      RankingQuestParam rankingQuestParam = null,
      int auto_repeat_quest = 0)
    {
    }
  }
}
