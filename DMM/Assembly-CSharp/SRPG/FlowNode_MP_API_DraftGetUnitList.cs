// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_DraftGetUnitList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200177F")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Failure", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/DraftMath/GetUnitList", 32741)]
  public class FlowNode_MP_API_DraftGetUnitList : FlowNode_Network
  {
    [Token(Token = "0x4005476")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005477")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005478")]
    private const int PIN_OUT_FAILURE = 101;

    [Token(Token = "0x6005F4C")]
    [Address(RVA = "0x1333DE0", Offset = "0x1332BE0", VA = "0x11333DE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F4D")]
    [Address(RVA = "0x13343E0", Offset = "0x13331E0", VA = "0x113343E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F4E")]
    [Address(RVA = "0x1333D70", Offset = "0x1332B70", VA = "0x11333D70")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005F4F")]
    [Address(RVA = "0x1333ED0", Offset = "0x1332CD0", VA = "0x11333ED0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F50")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_DraftGetUnitList()
    {
    }
  }
}
