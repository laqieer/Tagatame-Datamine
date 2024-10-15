// Decompiled with JetBrains decompiler
// Type: SRPG.ReplayCategoryList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200293F")]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Story", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "Event", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "Chara", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(13, "Movie", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(50, "QuestList(Restore)", FlowNode.PinTypes.Output, 105)]
  [AddComponentMenu("UI/ReplayCategoryList")]
  [FlowNode.Pin(1, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(14, "閲覧可能なストーリーがない", FlowNode.PinTypes.Output, 104)]
  public class ReplayCategoryList : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400C6AD")]
    private const int PIN_ID_INIT = 0;
    [Token(Token = "0x400C6AE")]
    private const int PIN_ID_REFRESH = 1;
    [Token(Token = "0x400C6AF")]
    private const int PIN_ID_STORY = 10;
    [Token(Token = "0x400C6B0")]
    private const int PIN_ID_EVENT = 11;
    [Token(Token = "0x400C6B1")]
    private const int PIN_ID_CHARA = 12;
    [Token(Token = "0x400C6B2")]
    private const int PIN_ID_MOVIE = 13;
    [Token(Token = "0x400C6B3")]
    private const int PIN_ID_NOT_EXIST = 14;
    [Token(Token = "0x400C6B4")]
    private const int PIN_ID_RESTORE = 50;
    [Token(Token = "0x400C6B5")]
    [FieldOffset(Offset = "0x20")]
    public ListItemEvents Item_Story;
    [Token(Token = "0x400C6B6")]
    [FieldOffset(Offset = "0x24")]
    public ListItemEvents Item_Event;
    [Token(Token = "0x400C6B7")]
    [FieldOffset(Offset = "0x28")]
    public ListItemEvents Item_Character;
    [Token(Token = "0x400C6B8")]
    [FieldOffset(Offset = "0x2C")]
    public ListItemEvents Item_Movie;
    [Token(Token = "0x400C6B9")]
    [FieldOffset(Offset = "0x30")]
    public CanvasGroup mCanvasGroup;
    [Token(Token = "0x400C6BA")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<ReplayCategoryList.ReplayCategoryType, int> QuestCount;

    [Token(Token = "0x600BA8D")]
    [Address(RVA = "0x81F760", Offset = "0x81E560", VA = "0x1081F760", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BA8E")]
    [Address(RVA = "0x820280", Offset = "0x81F080", VA = "0x10820280")]
    private bool Resumable(QuestParam quest) => new bool();

    [Token(Token = "0x600BA8F")]
    [Address(RVA = "0x81FCC0", Offset = "0x81EAC0", VA = "0x1081FCC0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BA90")]
    [Address(RVA = "0x81FB60", Offset = "0x81E960", VA = "0x1081FB60")]
    public static ReplayCategoryList.ReplayCategoryType GetReplayCategoryType(
      QuestParam quest,
      long currentTime)
    {
      return new ReplayCategoryList.ReplayCategoryType();
    }

    [Token(Token = "0x600BA91")]
    [Address(RVA = "0x81FC70", Offset = "0x81EA70", VA = "0x1081FC70")]
    public static bool HasEvent(QuestParam quest) => new bool();

    [Token(Token = "0x600BA92")]
    [Address(RVA = "0x81F920", Offset = "0x81E720", VA = "0x1081F920")]
    private void AddQuestCount(ReplayCategoryList.ReplayCategoryType type)
    {
    }

    [Token(Token = "0x600BA93")]
    [Address(RVA = "0x81FAE0", Offset = "0x81E8E0", VA = "0x1081FAE0")]
    private int GetQuestCount(ReplayCategoryList.ReplayCategoryType type) => new int();

    [Token(Token = "0x600BA94")]
    [Address(RVA = "0x81F9D0", Offset = "0x81E7D0", VA = "0x1081F9D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BA95")]
    [Address(RVA = "0x820320", Offset = "0x81F120", VA = "0x10820320")]
    private void Update()
    {
    }

    [Token(Token = "0x600BA96")]
    [Address(RVA = "0x820130", Offset = "0x81EF30", VA = "0x10820130")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BA97")]
    [Address(RVA = "0x81FF20", Offset = "0x81ED20", VA = "0x1081FF20")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600BA98")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public ReplayCategoryList()
    {
    }

    [Token(Token = "0x2002940")]
    public enum ReplayCategoryType
    {
      [Token(Token = "0x400C6BC")] Invalid = -1, // 0xFFFFFFFF
      [Token(Token = "0x400C6BD")] Story = 0,
      [Token(Token = "0x400C6BE")] Event = 1,
      [Token(Token = "0x400C6BF")] Character = 2,
      [Token(Token = "0x400C6C0")] Movie = 3,
    }
  }
}
