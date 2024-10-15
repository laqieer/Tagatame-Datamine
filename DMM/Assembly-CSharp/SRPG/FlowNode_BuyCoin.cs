// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BuyCoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200136E")]
  [FlowNode.NodeType("System/Buy/BuyCoin", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Buy", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_BuyCoin : FlowNode_Network
  {
    [Token(Token = "0x600517D")]
    [Address(RVA = "0x12673A0", Offset = "0x12661A0", VA = "0x112673A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600517E")]
    [Address(RVA = "0x107A1E0", Offset = "0x1078FE0", VA = "0x1107A1E0")]
    private void Success()
    {
    }

    [Token(Token = "0x600517F")]
    [Address(RVA = "0x1267360", Offset = "0x1266160", VA = "0x11267360")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005180")]
    [Address(RVA = "0x1267530", Offset = "0x1266330", VA = "0x11267530", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005181")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_BuyCoin()
    {
    }
  }
}
