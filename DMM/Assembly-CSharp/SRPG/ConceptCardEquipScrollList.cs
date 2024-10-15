// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEquipScrollList
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
  [Token(Token = "0x2002209")]
  [AddComponentMenu("UI/ConceptCardEquipScrollList")]
  public class ConceptCardEquipScrollList : MonoBehaviour
  {
    [Token(Token = "0x4009612")]
    [FieldOffset(Offset = "0xC")]
    private List<ConceptCardData> mCardDatas;
    [Token(Token = "0x4009613")]
    [FieldOffset(Offset = "0x10")]
    private List<ConceptCardData> mCardDatasDefault;
    [Token(Token = "0x4009614")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mSelectedUnit;
    [Token(Token = "0x4009615")]
    [FieldOffset(Offset = "0x18")]
    private ConceptCardData mSelectedConceptCardData;
    [Token(Token = "0x4009616")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mCardEmptyMessageText;
    [Token(Token = "0x4009617")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4009618")]
    [FieldOffset(Offset = "0x24")]
    private List<ConceptCardIconParam> mIconParams;
    [Token(Token = "0x4009619")]
    [FieldOffset(Offset = "0x28")]
    private List<ConceptCardData> mExcludeEquipCards;
    [Token(Token = "0x400961A")]
    [FieldOffset(Offset = "0x2C")]
    private int mSelectedCardSlotIndex;
    [Token(Token = "0x400961B")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsEnableDecreaseEffect;
    [Token(Token = "0x400961C")]
    [FieldOffset(Offset = "0x34")]
    private string mNameSearchInput;
    [Token(Token = "0x400961D")]
    [FieldOffset(Offset = "0x38")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x600901B")]
    [Address(RVA = "0x535020", Offset = "0x533E20", VA = "0x10535020")]
    public void Init(
      List<ConceptCardData> card_datas,
      UnitData selected_unit,
      int selectedCardIndex,
      bool is_keep_select = false,
      List<ConceptCardData> exclude_cards = null)
    {
    }

    [Token(Token = "0x600901C")]
    [Address(RVA = "0x5353B0", Offset = "0x5341B0", VA = "0x105353B0")]
    public void Refresh(List<ConceptCardData> card_datas)
    {
    }

    [Token(Token = "0x600901D")]
    [Address(RVA = "0x535390", Offset = "0x534190", VA = "0x10535390")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600901E")]
    [Address(RVA = "0x535AB0", Offset = "0x5348B0", VA = "0x10535AB0")]
    public void Sort(
      ConceptCardListSortWindow.Type SortType,
      ConceptCardListSortWindow.Type SortOrderType)
    {
    }

    [Token(Token = "0x600901F")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SelectedUnitData(UnitData unit)
    {
    }

    [Token(Token = "0x6009020")]
    [Address(RVA = "0x534ED0", Offset = "0x533CD0", VA = "0x10534ED0")]
    public void Filter()
    {
    }

    [Token(Token = "0x6009021")]
    [Address(RVA = "0x535310", Offset = "0x534110", VA = "0x10535310")]
    public void NameSearch(string NameSearchInput, SearchUtility.CONDITIONS NameSearchType = SearchUtility.CONDITIONS.AND)
    {
    }

    [Token(Token = "0x17001460")]
    public bool IsIgnoreEquipedConceptCard
    {
      [Token(Token = "0x6009022"), Address(RVA = "0x535FF0", Offset = "0x534DF0", VA = "0x10535FF0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009023"), Address(RVA = "0x536050", Offset = "0x534E50", VA = "0x10536050")] set
      {
      }
    }

    [Token(Token = "0x6009024")]
    [Address(RVA = "0x5358E0", Offset = "0x5346E0", VA = "0x105358E0")]
    private void SelectedCardIconActive()
    {
    }

    [Token(Token = "0x6009025")]
    [Address(RVA = "0x535860", Offset = "0x534660", VA = "0x10535860")]
    private void ResetSelectCardAnimation()
    {
    }

    [Token(Token = "0x6009026")]
    [Address(RVA = "0x535970", Offset = "0x534770", VA = "0x10535970")]
    public void SetSelectedCardData(ConceptCardData card_data)
    {
    }

    [Token(Token = "0x6009027")]
    [Address(RVA = "0x535EF0", Offset = "0x534CF0", VA = "0x10535EF0")]
    public ConceptCardEquipScrollList()
    {
    }
  }
}
