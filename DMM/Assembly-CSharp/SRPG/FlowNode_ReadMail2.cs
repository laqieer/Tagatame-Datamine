// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReadMail2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001474")]
  [FlowNode.Pin(22, "いくつか受け取れなかった", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(23, "何も受け取れなかった", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(21, "一括受け取り完了", FlowNode.PinTypes.Output, 21)]
  [AddComponentMenu("")]
  [FlowNode.Pin(8, "念装引き換え券", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(7, "武具引き換え券", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(6, "アイテム引き換え券", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(20, "一件受け取り完了", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(5, "ユニット引き換え券", FlowNode.PinTypes.Input, 5)]
  [FlowNode.NodeType("Mail/ReadMail2", 32741)]
  [FlowNode.Pin(0, "開封", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReadMail2 : FlowNode_Network
  {
    [Token(Token = "0x4004B9F")]
    private const int INPUT_OPEN_MAIL = 0;
    [Token(Token = "0x4004BA0")]
    private const int INPUT_OPEN_SELECT_UNIT_SUMMON_TICKET = 5;
    [Token(Token = "0x4004BA1")]
    private const int INPUT_OPEN_SELECT_ITEM_SUMMON_TICKET = 6;
    [Token(Token = "0x4004BA2")]
    private const int INPUT_OPEN_SELECT_ARTIFACT_SUMMON_TICKET = 7;
    [Token(Token = "0x4004BA3")]
    private const int INPUT_OPEN_SELECT_CONCEPT_CARD_SUMMON_TICKET = 8;
    [Token(Token = "0x4004BA4")]
    private const int OUTPUT_RECEIVED_MAIL = 20;
    [Token(Token = "0x4004BA5")]
    private const int OUTPUT_RECEIVED_MAILS = 21;
    [Token(Token = "0x4004BA6")]
    private const int OUTPUT_RECEIVED_SOME = 22;
    [Token(Token = "0x4004BA7")]
    private const int OUTPUT_NOT_RECEIVED_ANYTHING = 23;
    [Token(Token = "0x4004BA8")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReadMail2.ReceiveStatus mReceiveStatus;

    [Token(Token = "0x600557B")]
    [Address(RVA = "0x129C1B0", Offset = "0x129AFB0", VA = "0x1129C1B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600557C")]
    [Address(RVA = "0x129BED0", Offset = "0x129ACD0", VA = "0x1129BED0")]
    private RewardData GiftDataToRewardData(GiftData[] giftDatas) => (RewardData) null;

    [Token(Token = "0x600557D")]
    [Address(RVA = "0x129D7E0", Offset = "0x129C5E0", VA = "0x1129D7E0")]
    private void SetRewordData(MailData[] mail_datas)
    {
    }

    [Token(Token = "0x600557E")]
    [Address(RVA = "0x129DA50", Offset = "0x129C850", VA = "0x1129DA50")]
    private void Success()
    {
    }

    [Token(Token = "0x600557F")]
    [Address(RVA = "0x129CDA0", Offset = "0x129BBA0", VA = "0x1129CDA0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005580")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ReadMail2()
    {
    }

    [Token(Token = "0x2001475")]
    private enum ReceiveStatus
    {
      [Token(Token = "0x4004BAA")] Recieve,
      [Token(Token = "0x4004BAB")] NotReceiveAll,
      [Token(Token = "0x4004BAC")] NotReceiveSome,
    }

    [Token(Token = "0x2001476")]
    public class Json_MailRead
    {
      [Token(Token = "0x4004BAD")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x4004BAE")]
      [FieldOffset(Offset = "0xC")]
      public Json_Unit[] units;
      [Token(Token = "0x4004BAF")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x4004BB0")]
      [FieldOffset(Offset = "0x14")]
      public Json_Friend[] friends;
      [Token(Token = "0x4004BB1")]
      [FieldOffset(Offset = "0x18")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x4004BB2")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Mails mails;
      [Token(Token = "0x4004BB3")]
      [FieldOffset(Offset = "0x20")]
      public Json_Mail[] processed;
      [Token(Token = "0x4004BB4")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x4004BB5")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x4004BB6")]
      [FieldOffset(Offset = "0x2C")]
      public int rune_storage_used;
      [Token(Token = "0x4004BB7")]
      [FieldOffset(Offset = "0x30")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x6005581")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_MailRead()
      {
      }
    }

    [Token(Token = "0x2001477")]
    private class HaveCheckScope : IDisposable
    {
      [Token(Token = "0x4004BB8")]
      [FieldOffset(Offset = "0x8")]
      private Dictionary<GiftTypes, int> currentNums;

      [Token(Token = "0x6005582")]
      [Address(RVA = "0x129FCC0", Offset = "0x129EAC0", VA = "0x1129FCC0")]
      public HaveCheckScope()
      {
      }

      [Token(Token = "0x6005583")]
      [Address(RVA = "0x129F820", Offset = "0x129E620", VA = "0x1129F820")]
      public void AddCurrentNum(MailData mailData)
      {
      }

      [Token(Token = "0x6005584")]
      [Address(RVA = "0x129F9C0", Offset = "0x129E7C0", VA = "0x1129F9C0")]
      public bool CheckReceivable(MailData mailData) => new bool();

      [Token(Token = "0x6005585")]
      [Address(RVA = "0x129FC80", Offset = "0x129EA80", VA = "0x1129FC80", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
