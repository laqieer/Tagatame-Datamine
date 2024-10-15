// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGPGSMigrate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016A2")]
  [FlowNode.NodeType("GPGS/Migrate", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "Failed", FlowNode.PinTypes.Output, 200)]
  public class FlowNode_ReqGPGSMigrate : FlowNode
  {
    [Token(Token = "0x4005237")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005238")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005239")]
    private const int PIN_OUT_FAILED = 200;

    [Token(Token = "0x6005CC0")]
    [Address(RVA = "0x124C660", Offset = "0x124B460", VA = "0x1124C660", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CC1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ReqGPGSMigrate()
    {
    }
  }
}
