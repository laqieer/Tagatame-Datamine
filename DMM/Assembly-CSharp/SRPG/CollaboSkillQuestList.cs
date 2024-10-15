// Decompiled with JetBrains decompiler
// Type: SRPG.CollaboSkillQuestList
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
  [Token(Token = "0x20021A1")]
  [FlowNode.Pin(10, "リスト切り替え", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "クエストが選択された", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/CollaboSkillQuestList")]
  public class CollaboSkillQuestList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009320")]
    [FieldOffset(Offset = "0xC")]
    public UnitData CurrentUnit1;
    [Token(Token = "0x4009321")]
    [FieldOffset(Offset = "0x10")]
    public UnitData CurrentUnit2;
    [Token(Token = "0x4009322")]
    [FieldOffset(Offset = "0x14")]
    public Transform QuestList;
    [Token(Token = "0x4009323")]
    [FieldOffset(Offset = "0x18")]
    public GameObject StoryQuestItemTemplate;
    [Token(Token = "0x4009324")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject StoryQuestDisableItemTemplate;
    [Token(Token = "0x4009325")]
    [FieldOffset(Offset = "0x20")]
    public GameObject QuestDetailTemplate;
    [Token(Token = "0x4009326")]
    [FieldOffset(Offset = "0x24")]
    public string DisableFlagName;
    [Token(Token = "0x4009327")]
    [FieldOffset(Offset = "0x28")]
    public GameObject CharacterImage1;
    [Token(Token = "0x4009328")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject CharacterImage2;
    [Token(Token = "0x4009329")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mStoryQuestListItems;
    [Token(Token = "0x400932A")]
    [FieldOffset(Offset = "0x34")]
    private GameObject mQuestDetail;
    [Token(Token = "0x400932B")]
    [FieldOffset(Offset = "0x38")]
    public Image ListToggleButton;
    [Token(Token = "0x400932C")]
    [FieldOffset(Offset = "0x3C")]
    public Sprite StoryListSprite;
    [Token(Token = "0x400932D")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsStoryList;
    [Token(Token = "0x400932E")]
    [FieldOffset(Offset = "0x41")]
    private bool mListRefreshing;
    [Token(Token = "0x400932F")]
    [FieldOffset(Offset = "0x42")]
    private bool mIsRestore;

    [Token(Token = "0x170013FD")]
    public bool IsRestore
    {
      [Token(Token = "0x6008D80"), Address(RVA = "0x512B30", Offset = "0x511930", VA = "0x10512B30")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008D81"), Address(RVA = "0x512B40", Offset = "0x511940", VA = "0x10512B40")] set
      {
      }
    }

    [Token(Token = "0x6008D82")]
    [Address(RVA = "0x512990", Offset = "0x511790", VA = "0x10512990", Slot = "5")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x6008D83")]
    [Address(RVA = "0x511FE0", Offset = "0x510DE0", VA = "0x10511FE0")]
    public static List<QuestParam> GetCollaboSkillQuests(UnitData unitData1, UnitData unitData2)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6008D84")]
    [Address(RVA = "0x511F00", Offset = "0x510D00", VA = "0x10511F00")]
    public static QuestParam GetCollaboSkillQuest(UnitData unitData1, UnitData unitData2)
    {
      return (QuestParam) null;
    }

    [Token(Token = "0x6008D85")]
    [Address(RVA = "0x512240", Offset = "0x511040", VA = "0x10512240")]
    private static QuestParam GetLearnSkillQuest(CollaboSkillParam csp, UnitData partner)
    {
      return (QuestParam) null;
    }

    [Token(Token = "0x6008D86")]
    [Address(RVA = "0x511A50", Offset = "0x510850", VA = "0x10511A50")]
    private void CreateStoryList()
    {
    }

    [Token(Token = "0x6008D87")]
    [Address(RVA = "0x512810", Offset = "0x511610", VA = "0x10512810")]
    private void RefreshQuestList()
    {
    }

    [Token(Token = "0x6008D88")]
    [Address(RVA = "0x512580", Offset = "0x511380", VA = "0x10512580")]
    private void OnQuestSelect(GameObject button)
    {
    }

    [Token(Token = "0x6008D89")]
    [Address(RVA = "0x5123C0", Offset = "0x5111C0", VA = "0x105123C0")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x6008D8A")]
    [Address(RVA = "0x512460", Offset = "0x511260", VA = "0x10512460")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x6008D8B")]
    [Address(RVA = "0x5127E0", Offset = "0x5115E0", VA = "0x105127E0")]
    private void OnToggleButton()
    {
    }

    [Token(Token = "0x6008D8C")]
    [Address(RVA = "0x512A20", Offset = "0x511820", VA = "0x10512A20")]
    private void UpdateToggleButton()
    {
    }

    [Token(Token = "0x6008D8D")]
    [Address(RVA = "0x511A10", Offset = "0x510810", VA = "0x10511A10", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008D8E")]
    [Address(RVA = "0x512A90", Offset = "0x511890", VA = "0x10512A90")]
    public CollaboSkillQuestList()
    {
    }
  }
}
