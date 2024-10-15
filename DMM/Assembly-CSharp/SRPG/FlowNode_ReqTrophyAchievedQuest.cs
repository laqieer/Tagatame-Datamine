// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTrophyAchievedQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015C1")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "NoTrophy", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("Trophy/ReqAchievedQuest", 32741)]
  public class FlowNode_ReqTrophyAchievedQuest : FlowNode_Network
  {
    [Token(Token = "0x4004F29")]
    [FieldOffset(Offset = "0x20")]
    public Text Quests;
    [Token(Token = "0x4004F2A")]
    [FieldOffset(Offset = "0x24")]
    public Toggle toggle;

    [Token(Token = "0x6005980")]
    [Address(RVA = "0x12E1D80", Offset = "0x12E0B80", VA = "0x112E1D80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005981")]
    [Address(RVA = "0x12E1EB0", Offset = "0x12E0CB0", VA = "0x112E1EB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005982")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTrophyAchievedQuest()
    {
    }
  }
}
