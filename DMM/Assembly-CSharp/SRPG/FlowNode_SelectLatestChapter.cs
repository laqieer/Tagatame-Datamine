// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SelectLatestChapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015FE")]
  [FlowNode.NodeType("SRPG/クエスト選択", 32741)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_SelectLatestChapter : FlowNode
  {
    [Token(Token = "0x4004FC6")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_SelectLatestChapter.SelectModes Selection;
    [Token(Token = "0x4004FC7")]
    private const int DEFSTARTSECTION = 1;

    [Token(Token = "0x6005A80")]
    [Address(RVA = "0x12F3760", Offset = "0x12F2560", VA = "0x112F3760")]
    public static void SelectLatestChapter()
    {
    }

    [Token(Token = "0x6005A81")]
    [Address(RVA = "0x12F3190", Offset = "0x12F1F90", VA = "0x112F3190")]
    public static QuestParam GetLastChapterQuest(int storyPart) => (QuestParam) null;

    [Token(Token = "0x6005A82")]
    [Address(RVA = "0x12F3270", Offset = "0x12F2070", VA = "0x112F3270", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A83")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SelectLatestChapter()
    {
    }

    [Token(Token = "0x20015FF")]
    public enum SelectModes
    {
      [Token(Token = "0x4004FC9")] Latest,
      [Token(Token = "0x4004FCA")] DailyChapter,
      [Token(Token = "0x4004FCB")] DailySection,
      [Token(Token = "0x4004FCC")] CharacterQuestSection,
    }
  }
}
