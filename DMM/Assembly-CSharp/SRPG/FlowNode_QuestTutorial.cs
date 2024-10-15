// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_QuestTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200146B")]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "Confirm", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Tutorial/Quest Tutorial", 32741)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_QuestTutorial : FlowNode
  {
    [Token(Token = "0x4004B85")]
    [FieldOffset(Offset = "0x18")]
    public string QuestID;
    [Token(Token = "0x4004B86")]
    [FieldOffset(Offset = "0x1C")]
    public FlowNode_QuestTutorial.TriggerConditions Condition;
    [Token(Token = "0x4004B87")]
    [FieldOffset(Offset = "0x20")]
    public string ConfirmText;
    [Token(Token = "0x4004B88")]
    [FieldOffset(Offset = "0x24")]
    public string LocalFlag;
    [Token(Token = "0x4004B89")]
    [FieldOffset(Offset = "0x28")]
    public bool CheckLastPlayed;

    [Token(Token = "0x6005561")]
    [Address(RVA = "0x129BA10", Offset = "0x129A810", VA = "0x1129BA10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005562")]
    [Address(RVA = "0x129B870", Offset = "0x129A670", VA = "0x1129B870")]
    private bool CheckCondition() => new bool();

    [Token(Token = "0x6005563")]
    [Address(RVA = "0xF49830", Offset = "0xF48630", VA = "0x10F49830")]
    private void OnYes(GameObject go)
    {
    }

    [Token(Token = "0x6005564")]
    [Address(RVA = "0x1272E30", Offset = "0x1271C30", VA = "0x11272E30")]
    private void OnNo(GameObject go)
    {
    }

    [Token(Token = "0x6005565")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_QuestTutorial()
    {
    }

    [Token(Token = "0x200146C")]
    public enum TriggerConditions
    {
      [Token(Token = "0x4004B8B")] None,
      [Token(Token = "0x4004B8C")] FirstTry,
      [Token(Token = "0x4004B8D")] FirstWin,
      [Token(Token = "0x4004B8E")] FirstLose,
      [Token(Token = "0x4004B8F")] Win,
      [Token(Token = "0x4004B90")] Lose,
    }
  }
}
