// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidReportSelfShare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016E7")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidReportSelfShare", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGuildRaidReportSelfShare : FlowNode_Network
  {
    [Token(Token = "0x40052C5")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052C6")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D81")]
    [Address(RVA = "0x131F030", Offset = "0x131DE30", VA = "0x1131F030", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D82")]
    [Address(RVA = "0x131F490", Offset = "0x131E290", VA = "0x1131F490")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D83")]
    [Address(RVA = "0x131F1B0", Offset = "0x131DFB0", VA = "0x1131F1B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D84")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidReportSelfShare()
    {
    }
  }
}
