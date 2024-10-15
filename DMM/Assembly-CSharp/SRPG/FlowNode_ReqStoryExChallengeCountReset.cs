// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqStoryExChallengeCountReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001814")]
  [FlowNode.NodeType("StoryExChallengeCount/Reset", 32741)]
  [FlowNode.Pin(10, "挑戦回数リセット開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "挑戦回数リセット終了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "幻晶石が不足", FlowNode.PinTypes.Output, 120)]
  [AddComponentMenu("")]
  public class FlowNode_ReqStoryExChallengeCountReset : FlowNode_Network
  {
    [Token(Token = "0x400569F")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x40056A0")]
    private const int PIN_OUTPUT_END = 110;
    [Token(Token = "0x40056A1")]
    private const int PIN_OUTPUT_ERR_NOT_ENOUGH_COIN = 120;
    [Token(Token = "0x40056A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private eResetCostType mCostType;

    [Token(Token = "0x6006142")]
    [Address(RVA = "0x136CCD0", Offset = "0x136BAD0", VA = "0x1136CCD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006143")]
    [Address(RVA = "0x136CDF0", Offset = "0x136BBF0", VA = "0x1136CDF0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006144")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqStoryExChallengeCountReset()
    {
    }
  }
}
