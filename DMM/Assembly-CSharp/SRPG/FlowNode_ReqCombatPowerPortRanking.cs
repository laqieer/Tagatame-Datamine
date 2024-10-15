// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCombatPowerPortRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200131F")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("CombatPower/Req/ReqCombatPowerPortRanking", 32741)]
  public class FlowNode_ReqCombatPowerPortRanking : FlowNode_Network
  {
    [Token(Token = "0x40046F6")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40046F7")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40046F8")]
    public const string KEY_REQ_COMBATPOWERRANKING = "KEY_REQ_COMBATPOWERRANKING";
    [Token(Token = "0x40046F9")]
    public const string KEY_REQUEASTDATA = "KEY_REQUEASTDATA";

    [Token(Token = "0x600509E")]
    [Address(RVA = "0x1259740", Offset = "0x1258540", VA = "0x11259740", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600509F")]
    [Address(RVA = "0x1259B70", Offset = "0x1258970", VA = "0x11259B70")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x60050A0")]
    [Address(RVA = "0x12598A0", Offset = "0x12586A0", VA = "0x112598A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050A1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCombatPowerPortRanking()
    {
    }
  }
}
