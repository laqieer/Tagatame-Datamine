// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CompSelectedQuestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001685")]
  [FlowNode.Pin(111, "Yes", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/CompSelectedQuestType", 32741)]
  [FlowNode.Pin(112, "No", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(1, "Comp", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_CompSelectedQuestType : FlowNode
  {
    [Token(Token = "0x40051E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestTypes[] mCompQuestTypes;
    [Token(Token = "0x40051E3")]
    private const int PIN_IN_COMP = 1;
    [Token(Token = "0x40051E4")]
    private const int PIN_OUT_YES = 111;
    [Token(Token = "0x40051E5")]
    private const int PIN_OUT_NO = 112;

    [Token(Token = "0x6005C65")]
    [Address(RVA = "0x13060E0", Offset = "0x1304EE0", VA = "0x113060E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C66")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CompSelectedQuestType()
    {
    }
  }
}
