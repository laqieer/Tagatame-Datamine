// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusIsDraftType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F0")]
  [FlowNode.NodeType("MultiPlay/Versus/IsDraftType", 32741)]
  [FlowNode.Pin(1, "Is Draft", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Is Draft Friend", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "Is Draft Friend only", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "Is Draft TagatameCup", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(201, "Yes", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "No", FlowNode.PinTypes.Output, 202)]
  [AddComponentMenu("")]
  public class FlowNode_MP_VersusIsDraftType : FlowNode
  {
    [Token(Token = "0x4005630")]
    private const int PIN_IN_IS_DRAFT = 1;
    [Token(Token = "0x4005631")]
    private const int PIN_IN_IS_DRAFT_FRIEND = 2;
    [Token(Token = "0x4005632")]
    private const int PIN_IN_IS_DRAFT_FRIEND_ONLY = 3;
    [Token(Token = "0x4005633")]
    private const int PIN_IN_IS_DRAFT_TAGATAMECUP = 4;
    [Token(Token = "0x4005634")]
    private const int PIN_OUT_YES = 201;
    [Token(Token = "0x4005635")]
    private const int PIN_OUT_NO = 202;

    [Token(Token = "0x60060DE")]
    [Address(RVA = "0x135A980", Offset = "0x1359780", VA = "0x1135A980", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060DF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusIsDraftType()
    {
    }
  }
}
