// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckMasterDataLoadError
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001381")]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("System/Master/CheckMasterDataLoadError", 32741)]
  [FlowNode.Pin(0, "Check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_CheckMasterDataLoadError : FlowNode
  {
    [Token(Token = "0x60051CB")]
    [Address(RVA = "0x126BD50", Offset = "0x126AB50", VA = "0x1126BD50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051CC")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60051CD")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x60051CE")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckMasterDataLoadError()
    {
    }
  }
}
