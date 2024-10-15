// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetPointQuestSelectArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200180F")]
  [FlowNode.Pin(10, "完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Set 竜神編", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Set イベント", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("PointQuest/SetPointQuestSelectArea", 32741)]
  [FlowNode.Pin(2, "Set 未設定", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_SetPointQuestSelectArea : FlowNode
  {
    [Token(Token = "0x400568E")]
    private const int PIN_INPUT_DRAGONGOD = 0;
    [Token(Token = "0x400568F")]
    private const int PIN_INPUT_POINTEVENT = 1;
    [Token(Token = "0x4005690")]
    private const int PIN_INPUT_NONE = 2;
    [Token(Token = "0x4005691")]
    private const int PIN_OUTPUT_FINISH = 10;

    [Token(Token = "0x6006138")]
    [Address(RVA = "0x136D8C0", Offset = "0x136C6C0", VA = "0x1136D8C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006139")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetPointQuestSelectArea()
    {
    }
  }
}
