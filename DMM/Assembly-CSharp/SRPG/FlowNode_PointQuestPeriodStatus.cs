// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PointQuestPeriodStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001800")]
  [FlowNode.Pin(11, "ランキング表示期間", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "開催中", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(13, "エラー", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "期間外", FlowNode.PinTypes.Output, 12)]
  [FlowNode.NodeType("PointQuest/PointQuestPeriodStatus", 32741)]
  public class FlowNode_PointQuestPeriodStatus : FlowNode
  {
    [Token(Token = "0x4005670")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005671")]
    private const int PIN_OPEN = 10;
    [Token(Token = "0x4005672")]
    private const int PIN_RANKING = 11;
    [Token(Token = "0x4005673")]
    private const int PIN_OUT_OF_PERIOD = 12;
    [Token(Token = "0x4005674")]
    private const int PIN_ERROR = 13;

    [Token(Token = "0x6006113")]
    [Address(RVA = "0x135BD50", Offset = "0x135AB50", VA = "0x1135BD50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006114")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PointQuestPeriodStatus()
    {
    }
  }
}
