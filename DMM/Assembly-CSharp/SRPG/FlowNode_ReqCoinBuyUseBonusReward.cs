// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCoinBuyUseBonusReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014BE")]
  [FlowNode.NodeType("System/CoinBuyUse/ReqCoinBuyUseReward")]
  [FlowNode.Pin(100, "報酬受取開始", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(1000, "報酬受取完了", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1010, "データ不足エラー", FlowNode.PinTypes.Output, 1010)]
  [AddComponentMenu("")]
  public class FlowNode_ReqCoinBuyUseBonusReward : FlowNode_Network
  {
    [Token(Token = "0x4004C20")]
    private const int PIN_INPUT_START = 100;
    [Token(Token = "0x4004C21")]
    private const int PIN_OUTPUT_END = 1000;
    [Token(Token = "0x4004C22")]
    private const int PIN_OUTPUT_NODATA = 1010;

    [Token(Token = "0x6005680")]
    [Address(RVA = "0x12BF870", Offset = "0x12BE670", VA = "0x112BF870", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005681")]
    [Address(RVA = "0x12BFAD0", Offset = "0x12BE8D0", VA = "0x112BFAD0")]
    private bool SendRequest() => new bool();

    [Token(Token = "0x6005682")]
    [Address(RVA = "0x12BF8B0", Offset = "0x12BE6B0", VA = "0x112BF8B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005683")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCoinBuyUseBonusReward()
    {
    }
  }
}
