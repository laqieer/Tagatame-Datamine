// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdvanceRaidboss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D3")]
  [FlowNode.Pin(103, "ArchiveNotOpen", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Advance/Req/Raidboss", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "NotOpen", FlowNode.PinTypes.Output, 102)]
  public class FlowNode_ReqAdvanceRaidboss : FlowNode_Network
  {
    [Token(Token = "0x4004625")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004626")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004627")]
    protected const int PIN_OUT_NOT_OPEN = 102;
    [Token(Token = "0x4004628")]
    protected const int PIN_OUT_ARCHIVE_NOT_OPEN = 103;

    [Token(Token = "0x6004FBF")]
    [Address(RVA = "0x1249F70", Offset = "0x1248D70", VA = "0x11249F70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FC0")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FC1")]
    [Address(RVA = "0x124A060", Offset = "0x1248E60", VA = "0x1124A060", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FC2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdvanceRaidboss()
    {
    }
  }
}
