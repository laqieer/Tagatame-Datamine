// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterQuestList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200213F")]
  [FlowNode.Pin(1, "Refresh(Collabo)", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/CharacterQuestList")]
  [FlowNode.Pin(13, "Sort Change", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(12, "Selected(Collabo)", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(10, "Refreshed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(0, "Refresh(Chara)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "Selected(Chara)", FlowNode.PinTypes.Output, 12)]
  public class CharacterQuestList : SRPG_FixedList, IFlowInterface, ISortableList
  {
    [Token(Token = "0x40090C7")]
    private const int PIN_ID_REFRESH_CHARA = 0;
    [Token(Token = "0x40090C8")]
    private const int PIN_ID_REFRESH_COLLABO = 1;
    [Token(Token = "0x40090C9")]
    private const int PIN_ID_REFRESHED = 10;
    [Token(Token = "0x40090CA")]
    private const int PIN_ID_CHARA_SELECTED = 11;
    [Token(Token = "0x40090CB")]
    private const int PIN_ID_COLLABO_REFRESHED = 12;
    [Token(Token = "0x40090CC")]
    private const int PIN_ID_SORT_CHANGE = 13;
    [Token(Token = "0x40090CD")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x40090CE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject FlowRoot;
    [Token(Token = "0x40090CF")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private SortMenu mSortMenu;
    [Token(Token = "0x40090D0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private SortMenuButton mSortMenuButton;
    [Token(Token = "0x40090D1")]
    [FieldOffset(Offset = "0x74")]
    private CharacterQuestList.FilterMethod mFilterMethod;

    [Token(Token = "0x6008B85")]
    [Address(RVA = "0x4F78A0", Offset = "0x4F66A0", VA = "0x104F78A0")]
    private static string FilterValue(CharacterQuestList.EFilter filter) => (string) null;

    [Token(Token = "0x6008B86")]
    [Address(RVA = "0x4F8D40", Offset = "0x4F7B40", VA = "0x104F8D40", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6008B87")]
    [Address(RVA = "0x4F8400", Offset = "0x4F7200", VA = "0x104F8400", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x6008B88")]
    [Address(RVA = "0x4F8190", Offset = "0x4F6F90", VA = "0x104F8190", Slot = "25")]
    protected override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x6008B89")]
    [Address(RVA = "0x4F7C50", Offset = "0x4F6A50", VA = "0x104F7C50")]
    public static List<KeyValuePair<QuestParam, bool>> GetCharacterQuests(UnitData unitData)
    {
      return (List<KeyValuePair<QuestParam, bool>>) null;
    }

    [Token(Token = "0x6008B8A")]
    [Address(RVA = "0x4F7E10", Offset = "0x4F6C10", VA = "0x104F7E10")]
    public static List<KeyValuePair<QuestParam, bool>> GetCollaboSkillQuests(
      UnitData unitData1,
      UnitData unitData2)
    {
      return (List<KeyValuePair<QuestParam, bool>>) null;
    }

    [Token(Token = "0x6008B8B")]
    [Address(RVA = "0x4F8B30", Offset = "0x4F7930", VA = "0x104F8B30", Slot = "26")]
    protected override void RefreshItems()
    {
    }

    [Token(Token = "0x6008B8C")]
    [Address(RVA = "0x4F77F0", Offset = "0x4F65F0", VA = "0x104F77F0", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x6008B8D")]
    [Address(RVA = "0x4F8D00", Offset = "0x4F7B00", VA = "0x104F8D00", Slot = "33")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x6008B8E")]
    [Address(RVA = "0x4F8B50", Offset = "0x4F7950", VA = "0x104F8B50")]
    public void SetSortMethod(string[] filters)
    {
    }

    [Token(Token = "0x6008B8F")]
    [Address(RVA = "0x4F8160", Offset = "0x4F6F60", VA = "0x104F8160")]
    private bool OnFilter_Unlock(CharacterQuestData questData) => new bool();

    [Token(Token = "0x6008B90")]
    [Address(RVA = "0x4F8140", Offset = "0x4F6F40", VA = "0x104F8140")]
    private bool OnFilter_Lock(CharacterQuestData questData) => new bool();

    [Token(Token = "0x6008B91")]
    [Address(RVA = "0x4F8120", Offset = "0x4F6F20", VA = "0x104F8120")]
    private bool OnFilter_Complete(CharacterQuestData questData) => new bool();

    [Token(Token = "0x6008B92")]
    [Address(RVA = "0x4F8110", Offset = "0x4F6F10", VA = "0x104F8110")]
    private bool OnFilter_ALL(CharacterQuestData questData) => new bool();

    [Token(Token = "0x6008B93")]
    [Address(RVA = "0x4F7790", Offset = "0x4F6590", VA = "0x104F7790", Slot = "32")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008B94")]
    [Address(RVA = "0x4F78C0", Offset = "0x4F66C0", VA = "0x104F78C0")]
    private List<CharacterQuestDataChunk> GetCharacterQuestList()
    {
      return (List<CharacterQuestDataChunk>) null;
    }

    [Token(Token = "0x6008B95")]
    [Address(RVA = "0x4F8AA0", Offset = "0x4F78A0", VA = "0x104F8AA0")]
    private void RefreshFilter()
    {
    }

    [Token(Token = "0x6008B96")]
    [Address(RVA = "0x4F8420", Offset = "0x4F7220", VA = "0x104F8420")]
    public void RefreshCharaData()
    {
    }

    [Token(Token = "0x6008B97")]
    [Address(RVA = "0x4F8730", Offset = "0x4F7530", VA = "0x104F8730")]
    public void RefreshCollaboData()
    {
    }

    [Token(Token = "0x6008B98")]
    [Address(RVA = "0x4F83C0", Offset = "0x4F71C0", VA = "0x104F83C0")]
    public void OnPreviousPage()
    {
    }

    [Token(Token = "0x6008B99")]
    [Address(RVA = "0x4F8380", Offset = "0x4F7180", VA = "0x104F8380")]
    public void OnNextPage()
    {
    }

    [Token(Token = "0x6008B9A")]
    [Address(RVA = "0x4F8E20", Offset = "0x4F7C20", VA = "0x104F8E20")]
    public CharacterQuestList()
    {
    }

    [Token(Token = "0x2002140")]
    public enum EFilter
    {
      [Token(Token = "0x40090D3")] ALL,
      [Token(Token = "0x40090D4")] Unlock,
      [Token(Token = "0x40090D5")] Lock,
      [Token(Token = "0x40090D6")] Complete,
    }

    [Token(Token = "0x2002141")]
    private delegate bool FilterMethod(CharacterQuestData questData);
  }
}
