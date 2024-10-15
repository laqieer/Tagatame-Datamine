// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardListSortWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200222B")]
  [FlowNode.Pin(0, "セーブ", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "キャンセル", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "セーブ完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(20, "キャンセル完了", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("UI/ConceptCardListSortWindow")]
  public class ConceptCardListSortWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009754")]
    public const string SAVE_KEY = "CARD_FILTER";
    [Token(Token = "0x4009755")]
    public const ConceptCardListSortWindow.Type CLEAR_TYPE = (ConceptCardListSortWindow.Type) 251658240;
    [Token(Token = "0x4009756")]
    public const ConceptCardListSortWindow.Type CLEAR_ORDER_TYPE = (ConceptCardListSortWindow.Type) 16777215;
    [Token(Token = "0x4009757")]
    public const ConceptCardListSortWindow.Type MASK_TYPE = (ConceptCardListSortWindow.Type) 16777215;
    [Token(Token = "0x4009758")]
    public const ConceptCardListSortWindow.Type MASK_ORDER_TYPE = (ConceptCardListSortWindow.Type) 251658240;
    [Token(Token = "0x4009759")]
    public const int PIN_SAVE = 0;
    [Token(Token = "0x400975A")]
    public const int PIN_CANCEL = 1;
    [Token(Token = "0x400975B")]
    public const int PIN_SAVE_END = 10;
    [Token(Token = "0x400975C")]
    public const int PIN_CANCEL_END = 20;
    [Token(Token = "0x400975D")]
    public const ConceptCardListSortWindow.Type DefaultType = ConceptCardListSortWindow.Type.TIME | ConceptCardListSortWindow.Type.ASCENDING;
    [Token(Token = "0x400975E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ConceptCardListSortWindow.ParentType parent_type;
    [Token(Token = "0x400975F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardListSortWindow.Item[] SortToggles;
    [Token(Token = "0x4009760")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ConceptCardListSortWindow.Item[] SortOrderToggles;
    [Token(Token = "0x4009761")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ToggleGroup Group;
    [Token(Token = "0x4009762")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ToggleGroup OrderGroup;
    [Token(Token = "0x4009763")]
    [FieldOffset(Offset = "0x20")]
    private ConceptCardListSortWindow.Type CurrentType;
    [Token(Token = "0x4009764")]
    [FieldOffset(Offset = "0x24")]
    private ConceptCardListSortWindow.Type FirstType;

    [Token(Token = "0x6009146")]
    [Address(RVA = "0x549CD0", Offset = "0x548AD0", VA = "0x10549CD0")]
    public void Start()
    {
    }

    [Token(Token = "0x6009147")]
    [Address(RVA = "0x549200", Offset = "0x548000", VA = "0x10549200", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009148")]
    [Address(RVA = "0x549750", Offset = "0x548550", VA = "0x10549750")]
    public void OnSelect(bool is_on)
    {
    }

    [Token(Token = "0x6009149")]
    [Address(RVA = "0x549620", Offset = "0x548420", VA = "0x10549620")]
    public void OnSelectOrder(bool is_on)
    {
    }

    [Token(Token = "0x600914A")]
    [Address(RVA = "0x549A80", Offset = "0x548880", VA = "0x10549A80")]
    public static void Sort(
      ConceptCardListSortWindow.Type sort_type,
      ConceptCardListSortWindow.Type sort_order_type,
      List<ConceptCardData> card_list,
      bool is_rarity = false)
    {
    }

    [Token(Token = "0x600914B")]
    [Address(RVA = "0x549880", Offset = "0x548680", VA = "0x10549880")]
    public void ResetType()
    {
    }

    [Token(Token = "0x600914C")]
    [Address(RVA = "0x549930", Offset = "0x548730", VA = "0x10549930")]
    public void SetType()
    {
    }

    [Token(Token = "0x600914D")]
    [Address(RVA = "0x549380", Offset = "0x548180", VA = "0x10549380")]
    public void ChangeType(ConceptCardListSortWindow.Type type)
    {
    }

    [Token(Token = "0x600914E")]
    [Address(RVA = "0x549360", Offset = "0x548160", VA = "0x10549360")]
    public void ChangeOrderType(ConceptCardListSortWindow.Type type)
    {
    }

    [Token(Token = "0x600914F")]
    [Address(RVA = "0x5498A0", Offset = "0x5486A0", VA = "0x105498A0")]
    public void Save()
    {
    }

    [Token(Token = "0x6009150")]
    [Address(RVA = "0x549600", Offset = "0x548400", VA = "0x10549600")]
    public void Load()
    {
    }

    [Token(Token = "0x6009151")]
    [Address(RVA = "0x549530", Offset = "0x548330", VA = "0x10549530")]
    public static ConceptCardListSortWindow.Type LoadDataType()
    {
      return new ConceptCardListSortWindow.Type();
    }

    [Token(Token = "0x6009152")]
    [Address(RVA = "0x549520", Offset = "0x548320", VA = "0x10549520")]
    public static ConceptCardListSortWindow.Type LoadDataOrderType()
    {
      return new ConceptCardListSortWindow.Type();
    }

    [Token(Token = "0x6009153")]
    [Address(RVA = "0x549540", Offset = "0x548340", VA = "0x10549540")]
    private static ConceptCardListSortWindow.Type LoadData()
    {
      return new ConceptCardListSortWindow.Type();
    }

    [Token(Token = "0x6009154")]
    [Address(RVA = "0x5493A0", Offset = "0x5481A0", VA = "0x105493A0")]
    public static string GetTypeString(ConceptCardListSortWindow.Type type) => (string) null;

    [Token(Token = "0x6009155")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardListSortWindow()
    {
    }

    [Token(Token = "0x200222C")]
    public enum Type
    {
      [Token(Token = "0x4009766")] NONE = 0,
      [Token(Token = "0x4009767")] LEVEL = 1,
      [Token(Token = "0x4009768")] RARITY = 2,
      [Token(Token = "0x4009769")] ATK = 4,
      [Token(Token = "0x400976A")] DEF = 8,
      [Token(Token = "0x400976B")] MAG = 16, // 0x00000010
      [Token(Token = "0x400976C")] MND = 32, // 0x00000020
      [Token(Token = "0x400976D")] SPD = 64, // 0x00000040
      [Token(Token = "0x400976E")] LUCK = 128, // 0x00000080
      [Token(Token = "0x400976F")] HP = 256, // 0x00000100
      [Token(Token = "0x4009770")] TIME = 512, // 0x00000200
      [Token(Token = "0x4009771")] TRUST = 1024, // 0x00000400
      [Token(Token = "0x4009772")] AWAKE = 2048, // 0x00000800
      [Token(Token = "0x4009773")] EXTRA_RARITY = 4096, // 0x00001000
      [Token(Token = "0x4009774")] ASCENDING = 16777216, // 0x01000000
      [Token(Token = "0x4009775")] DESCENDING = 33554432, // 0x02000000
    }

    [Token(Token = "0x200222D")]
    public enum ParentType
    {
      [Token(Token = "0x4009777")] Manager,
      [Token(Token = "0x4009778")] Equip,
    }

    [Token(Token = "0x200222E")]
    [Serializable]
    public class Item
    {
      [Token(Token = "0x4009779")]
      [FieldOffset(Offset = "0x8")]
      public Toggle toggle;
      [Token(Token = "0x400977A")]
      [FieldOffset(Offset = "0xC")]
      public ConceptCardListSortWindow.Type type;

      [Token(Token = "0x6009156")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Item()
      {
      }
    }

    [Token(Token = "0x200222F")]
    public class SortData
    {
      [Token(Token = "0x400977B")]
      [FieldOffset(Offset = "0x8")]
      public ConceptCardData data;
      [Token(Token = "0x400977C")]
      [FieldOffset(Offset = "0x10")]
      public long sort_val;

      [Token(Token = "0x6009157")]
      [Address(RVA = "0x560BE0", Offset = "0x55F9E0", VA = "0x10560BE0")]
      public SortData(ConceptCardData _data, long _sort_val)
      {
      }
    }
  }
}
