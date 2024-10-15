// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_RoomIsDraft
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001798")]
  [FlowNode.Pin(102, "No", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/Draft/RoomIsDraft", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Yes", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MP_RoomIsDraft : FlowNode
  {
    [Token(Token = "0x4005507")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x4005508")]
    private const int PIN_OUTPUT_YES = 101;
    [Token(Token = "0x4005509")]
    private const int PIN_OUTPUT_NO = 102;

    [Token(Token = "0x6005FC0")]
    [Address(RVA = "0x1352760", Offset = "0x1351560", VA = "0x11352760", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FC1")]
    [Address(RVA = "0x13526D0", Offset = "0x13514D0", VA = "0x113526D0")]
    public static bool IsInDraftRoom() => new bool();

    [Token(Token = "0x6005FC2")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_RoomIsDraft()
    {
    }
  }
}
