// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsExistNewlyHotDeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001311")]
  [FlowNode.NodeType("HotDeal/IsExistNewlyHotDeal", 32741)]
  [FlowNode.Pin(10, "Exist", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "NotExist", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_IsExistNewlyHotDeal : FlowNode
  {
    [Token(Token = "0x40046C9")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40046CA")]
    private const int PIN_OUTPUT_EXIST = 10;
    [Token(Token = "0x40046CB")]
    private const int PIN_OUTPUT_NOT_EXIST = 11;

    [Token(Token = "0x6005075")]
    [Address(RVA = "0x124FBF0", Offset = "0x124E9F0", VA = "0x1124FBF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005076")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsExistNewlyHotDeal()
    {
    }
  }
}
