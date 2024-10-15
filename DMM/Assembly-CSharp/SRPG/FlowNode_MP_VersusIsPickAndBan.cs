// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusIsPickAndBan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F2")]
  [FlowNode.NodeType("MultiPlay/Versus/IsPickAndBan", 32741)]
  [FlowNode.Pin(1, "Is PickAndBan", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(200, "No", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "Yes", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_MP_VersusIsPickAndBan : FlowNode
  {
    [Token(Token = "0x4005639")]
    private const int PIN_IN_IS_PICKANDBAN = 1;
    [Token(Token = "0x400563A")]
    private const int PIN_OUT_YES = 100;
    [Token(Token = "0x400563B")]
    private const int PIN_OUT_NO = 200;

    [Token(Token = "0x60060E2")]
    [Address(RVA = "0x135AB80", Offset = "0x1359980", VA = "0x1135AB80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060E3")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusIsPickAndBan()
    {
    }

    [Token(Token = "0x20017F3")]
    public enum CheckType
    {
      [Token(Token = "0x400563D")] Single,
      [Token(Token = "0x400563E")] Friend,
    }
  }
}
