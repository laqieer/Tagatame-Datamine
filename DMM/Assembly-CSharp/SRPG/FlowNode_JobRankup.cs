// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_JobRankup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001413")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Unit/JobRankup", 32741)]
  [FlowNode.Pin(2, "Unlock", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "ClassChange", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  public class FlowNode_JobRankup : FlowNode_Network
  {
    [Token(Token = "0x4004A53")]
    [FieldOffset(Offset = "0x20")]
    private int mSuccessPinID;

    [Token(Token = "0x60053E3")]
    [Address(RVA = "0x1285F60", Offset = "0x1284D60", VA = "0x11285F60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053E4")]
    [Address(RVA = "0x1286680", Offset = "0x1285480", VA = "0x11286680")]
    private void Success()
    {
    }

    [Token(Token = "0x60053E5")]
    [Address(RVA = "0x12861D0", Offset = "0x1284FD0", VA = "0x112861D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60053E6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_JobRankup()
    {
    }
  }
}
