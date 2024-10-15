// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PointQuestEventTopSceneSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017FB")]
  [FlowNode.Pin(21, "Stage", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(101, "OutOfPeriod", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("PointQuest/EventTopSceneSelect", 32741)]
  [FlowNode.Pin(1, "Select", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Top", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_PointQuestEventTopSceneSelect : FlowNode
  {
    [Token(Token = "0x400565F")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005660")]
    private const int PIN_OUT_TOP = 11;
    [Token(Token = "0x4005661")]
    private const int PIN_OUT_STAGE = 21;
    [Token(Token = "0x4005662")]
    private const int PIN_OUT_QUEST_OUT_OF_PERIOD = 101;

    [Token(Token = "0x60060FB")]
    [Address(RVA = "0x135B1C0", Offset = "0x1359FC0", VA = "0x1135B1C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060FC")]
    [Address(RVA = "0x135B5C0", Offset = "0x135A3C0", VA = "0x1135B5C0")]
    private void ToQuest(QuestParam quest, bool is_restore)
    {
    }

    [Token(Token = "0x60060FD")]
    [Address(RVA = "0x135B420", Offset = "0x135A220", VA = "0x1135B420")]
    private void ToChapter(bool is_restore)
    {
    }

    [Token(Token = "0x60060FE")]
    [Address(RVA = "0x1248FA0", Offset = "0x1247DA0", VA = "0x11248FA0")]
    private void ToTop()
    {
    }

    [Token(Token = "0x60060FF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PointQuestEventTopSceneSelect()
    {
    }
  }
}
