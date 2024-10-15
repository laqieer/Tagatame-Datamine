// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsNeedRuneCheckByPartyType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001411")]
  [FlowNode.Pin(101, "Need Check", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "None Check", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("Party/CheckRuneHaveState", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_IsNeedRuneCheckByPartyType : FlowNode
  {
    [Token(Token = "0x4004A4D")]
    private const int PIN_INPUT_CHECK = 1;
    [Token(Token = "0x4004A4E")]
    private const int PIN_OUTPUT_YES = 101;
    [Token(Token = "0x4004A4F")]
    private const int PIN_OUTPUT_NO = 102;

    [Token(Token = "0x60053DF")]
    [Address(RVA = "0x1285DC0", Offset = "0x1284BC0", VA = "0x11285DC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053E0")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsNeedRuneCheckByPartyType()
    {
    }
  }
}
