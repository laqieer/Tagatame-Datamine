// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001766")]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchTop", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqLeagueMatchTop : FlowNode_Network
  {
    [Token(Token = "0x4005412")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005413")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005EFB")]
    [Address(RVA = "0x13424F0", Offset = "0x13412F0", VA = "0x113424F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EFC")]
    [Address(RVA = "0x1342B50", Offset = "0x1341950", VA = "0x11342B50")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005EFD")]
    [Address(RVA = "0x13425D0", Offset = "0x13413D0", VA = "0x113425D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EFE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchTop()
    {
    }
  }
}
