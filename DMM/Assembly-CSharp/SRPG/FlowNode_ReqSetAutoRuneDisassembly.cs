// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSetAutoRuneDisassembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001836")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Rune/AutoRuneDisassembly/FlowNode_ReqSetAutoRuneDisassembly", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqSetAutoRuneDisassembly : FlowNode_Network
  {
    [Token(Token = "0x40056D8")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056D9")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x60061B2")]
    [Address(RVA = "0x136C840", Offset = "0x136B640", VA = "0x1136C840", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061B3")]
    [Address(RVA = "0x136CC60", Offset = "0x136BA60", VA = "0x1136CC60")]
    private void Success()
    {
    }

    [Token(Token = "0x60061B4")]
    [Address(RVA = "0x136C980", Offset = "0x136B780", VA = "0x1136C980", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061B5")]
    [Address(RVA = "0x136C560", Offset = "0x136B360", VA = "0x1136C560")]
    private JSON_Rune_Auto_Disassemble CreateRuneAutoOption() => (JSON_Rune_Auto_Disassemble) null;

    [Token(Token = "0x60061B6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSetAutoRuneDisassembly()
    {
    }
  }
}
