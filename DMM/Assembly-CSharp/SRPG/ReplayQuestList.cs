// Decompiled with JetBrains decompiler
// Type: SRPG.ReplayQuestList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002946")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/ReplayQuestList")]
  [FlowNode.Pin(10, "クエストが選択された", FlowNode.PinTypes.Output, 101)]
  public class ReplayQuestList : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400C6D4")]
    private const int PIN_ID_REFRESH = 0;
    [Token(Token = "0x400C6D5")]
    private const int PIN_ID_SELECT = 10;
    [Token(Token = "0x400C6D6")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C6D7")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ItemContainer;
    [Token(Token = "0x400C6D8")]
    [FieldOffset(Offset = "0x28")]
    public Dictionary<string, GameObject> mListItemTemplates;
    [Token(Token = "0x400C6D9")]
    [FieldOffset(Offset = "0x2C")]
    public bool Descending;
    [Token(Token = "0x400C6DA")]
    [FieldOffset(Offset = "0x2D")]
    public bool RefreshOnStart;
    [Token(Token = "0x400C6DB")]
    [FieldOffset(Offset = "0x2E")]
    public bool ShowAllQuests;
    [Token(Token = "0x400C6DC")]
    [FieldOffset(Offset = "0x30")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C6DD")]
    [FieldOffset(Offset = "0x34")]
    private List<QuestParam> mQuests;
    [Token(Token = "0x400C6DE")]
    [FieldOffset(Offset = "0x38")]
    private string chapterName;

    [Token(Token = "0x600BAA7")]
    [Address(RVA = "0x821820", Offset = "0x820620", VA = "0x10821820", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAA8")]
    [Address(RVA = "0x822450", Offset = "0x821250", VA = "0x10822450", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600BAA9")]
    [Address(RVA = "0x821BA0", Offset = "0x8209A0", VA = "0x10821BA0")]
    private GameObject LoadQuestListItem(QuestParam param) => (GameObject) null;

    [Token(Token = "0x600BAAA")]
    [Address(RVA = "0x8220F0", Offset = "0x820EF0", VA = "0x108220F0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BAAB")]
    [Address(RVA = "0x821840", Offset = "0x820640", VA = "0x10821840")]
    private static bool CheckQuest(QuestParam quest, bool show_all_quests = false) => new bool();

    [Token(Token = "0x600BAAC")]
    [Address(RVA = "0x822070", Offset = "0x820E70", VA = "0x10822070")]
    private void RefreshQuests()
    {
    }

    [Token(Token = "0x600BAAD")]
    [Address(RVA = "0x821940", Offset = "0x820740", VA = "0x10821940")]
    private static List<QuestParam> GetSelectedChapterReplayQuests(bool show_all_quests = false)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x600BAAE")]
    [Address(RVA = "0x821DB0", Offset = "0x820BB0", VA = "0x10821DB0")]
    private void RefreshItems()
    {
    }

    [Token(Token = "0x600BAAF")]
    [Address(RVA = "0x8222F0", Offset = "0x8210F0", VA = "0x108222F0")]
    private void SetQuestTimerActive(Transform obj, bool value)
    {
    }

    [Token(Token = "0x600BAB0")]
    [Address(RVA = "0x821D00", Offset = "0x820B00", VA = "0x10821D00")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600BAB1")]
    [Address(RVA = "0x822540", Offset = "0x821340", VA = "0x10822540")]
    public ReplayQuestList()
    {
    }
  }
}
