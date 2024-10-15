// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCoinBuyUseBonusProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014BD")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/CoinBuyUse/ReqCoinBuyUseProgress")]
  [FlowNode.Pin(100, "進捗取得開始", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(1000, "進捗取得完了", FlowNode.PinTypes.Output, 1000)]
  public class FlowNode_ReqCoinBuyUseBonusProgress : FlowNode_Network
  {
    [Token(Token = "0x4004C1E")]
    private const int PIN_INPUT_START = 100;
    [Token(Token = "0x4004C1F")]
    private const int PIN_OUTPUT_END = 1000;

    [Token(Token = "0x600567D")]
    [Address(RVA = "0x12BF4D0", Offset = "0x12BE2D0", VA = "0x112BF4D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600567E")]
    [Address(RVA = "0x12BF5D0", Offset = "0x12BE3D0", VA = "0x112BF5D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600567F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCoinBuyUseBonusProgress()
    {
    }
  }
}
