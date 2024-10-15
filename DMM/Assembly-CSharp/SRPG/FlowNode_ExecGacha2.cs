// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExecGacha2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013DB")]
  [AddComponentMenu("")]
  [FlowNode.Pin(50, "Success(引き直し召喚確定_念装分解済)", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(15, "アイテムの有効期限切れ", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(14, "NoGachaPickup", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(13, "Success(簡易演出使用)", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "Error(引き直し召喚の期間外実行)", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "Success(引き直し召喚確定)", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(8, "有償幻晶石不足", FlowNode.PinTypes.Output, 8)]
  [FlowNode.Pin(9, "有償召喚リセット待ち", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(6, "ゼニー不足", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(5, "Failed", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(4, "Success", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(40, "Comp Gacha", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(30, "Free Gacha", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(20, "Multi Gacha", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "Single Gacha", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("System/Gacha/ExecGacha2", 32741)]
  [FlowNode.Pin(7, "幻晶石不足", FlowNode.PinTypes.Output, 7)]
  public class FlowNode_ExecGacha2 : FlowNode_Network
  {
    [Token(Token = "0x4004991")]
    private const int PIN_OT_SUCCESS_DECISION_REDRAW = 11;
    [Token(Token = "0x4004992")]
    private const int PIN_OT_ERROR_OUT_OF_PERIOD = 12;
    [Token(Token = "0x4004993")]
    private const int PIN_OT_SUCCESS_SIMPLE_ANIM = 13;
    [Token(Token = "0x4004994")]
    private const int PIN_OT_NO_GACHA_PICKUP = 14;
    [Token(Token = "0x4004995")]
    private const int PIN_OT_ITEM_NOTINPERIOD = 15;
    [Token(Token = "0x4004996")]
    private const int PIN_OT_SUCCESS_DECISION_REDRAW_DISASSEMBLY = 50;
    [Token(Token = "0x4004997")]
    [FieldOffset(Offset = "0x20")]
    private GachaTypes mCurrentGachaType;
    [Token(Token = "0x4004998")]
    [FieldOffset(Offset = "0x24")]
    private bool mUseOneMore;
    [Token(Token = "0x4004999")]
    [FieldOffset(Offset = "0x25")]
    private bool mSimpleAnim;
    [Token(Token = "0x400499B")]
    [FieldOffset(Offset = "0x28")]
    private List<string> DownloadUnits;
    [Token(Token = "0x400499C")]
    [FieldOffset(Offset = "0x2C")]
    private List<string> DownloadArtifacts;
    [Token(Token = "0x400499D")]
    [FieldOffset(Offset = "0x30")]
    private List<string> DownloadConceptCards;
    [Token(Token = "0x400499E")]
    [FieldOffset(Offset = "0x34")]
    private List<AssetList.Item> mQueue;

    [Token(Token = "0x1700091A")]
    private FlowNode_ExecGacha2.ExecType API
    {
      [Token(Token = "0x6005321"), Address(RVA = "0xAA6C30", Offset = "0xAA5A30", VA = "0x10AA6C30")] get
      {
        return new FlowNode_ExecGacha2.ExecType();
      }
      [Token(Token = "0x6005322"), Address(RVA = "0x127CF00", Offset = "0x127BD00", VA = "0x1127CF00")] set
      {
      }
    }

    [Token(Token = "0x6005323")]
    [Address(RVA = "0x127C020", Offset = "0x127AE20", VA = "0x1127C020")]
    public void OnExecGacha(GachaRequestParam _rparam)
    {
    }

    [Token(Token = "0x6005324")]
    [Address(RVA = "0x127BFA0", Offset = "0x127ADA0", VA = "0x1127BFA0")]
    public void OnExecGachaDecision(GachaRequestParam _rparam)
    {
    }

    [Token(Token = "0x6005325")]
    [Address(RVA = "0x127CB90", Offset = "0x127B990", VA = "0x1127CB90")]
    public void Request(GachaRequestParam _param)
    {
    }

    [Token(Token = "0x6005326")]
    [Address(RVA = "0x127BDF0", Offset = "0x127ABF0", VA = "0x1127BDF0")]
    private void ExecGacha(
      string iname,
      int is_free = 0,
      int num = 0,
      int is_decision = 0,
      int _cost_type = 0,
      int _execute_num = 0)
    {
    }

    [Token(Token = "0x6005327")]
    [Address(RVA = "0x127CD90", Offset = "0x127BB90", VA = "0x1127CD90")]
    private void Success()
    {
    }

    [Token(Token = "0x6005328")]
    [Address(RVA = "0x127BEA0", Offset = "0x127ACA0", VA = "0x1127BEA0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005329")]
    [Address(RVA = "0x127CB20", Offset = "0x127B920", VA = "0x1127CB20")]
    private void PaidGachaLimitOver()
    {
    }

    [Token(Token = "0x600532A")]
    [Address(RVA = "0x127CAA0", Offset = "0x127B8A0", VA = "0x1127CAA0")]
    private void OutofPeriod()
    {
    }

    [Token(Token = "0x600532B")]
    [Address(RVA = "0x127C110", Offset = "0x127AF10", VA = "0x1127C110", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600532C")]
    [Address(RVA = "0x127BD80", Offset = "0x127AB80", VA = "0x1127BD80")]
    private IEnumerator AsyncGachaResultData(List<GachaDropData> drops) => (IEnumerator) null;

    [Token(Token = "0x600532D")]
    [Address(RVA = "0x127BED0", Offset = "0x127ACD0", VA = "0x1127BED0")]
    private bool IsContainsDropType(List<GachaDropData> drops, GachaDropData.Type type)
    {
      return new bool();
    }

    [Token(Token = "0x600532E")]
    [Address(RVA = "0x127CE30", Offset = "0x127BC30", VA = "0x1127CE30")]
    public FlowNode_ExecGacha2()
    {
    }

    [Token(Token = "0x20013DC")]
    private enum ExecType : byte
    {
      [Token(Token = "0x40049A0")] NONE,
      [Token(Token = "0x40049A1")] DEFAULT,
      [Token(Token = "0x40049A2")] DECISION,
      [Token(Token = "0x40049A3")] SKIP,
    }
  }
}
