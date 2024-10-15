// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEquipList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002206")]
  [AddComponentMenu("UI/ConceptCardEquipList")]
  public class ConceptCardEquipList : UIBehaviour
  {
    [Token(Token = "0x40095FC")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsInitialized;
    [Token(Token = "0x40095FD")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsChangeRectSize;
    [Token(Token = "0x40095FE")]
    [FieldOffset(Offset = "0xE")]
    private bool mIsKeepCurrentPage;
    [Token(Token = "0x40095FF")]
    [FieldOffset(Offset = "0x10")]
    private RectTransform mRectTransform;
    [Token(Token = "0x4009600")]
    [FieldOffset(Offset = "0x14")]
    private GridLayoutGroup mGrid;
    [Token(Token = "0x4009601")]
    [FieldOffset(Offset = "0x18")]
    private List<ConceptCardData> mCardDatas;
    [Token(Token = "0x4009602")]
    [FieldOffset(Offset = "0x1C")]
    private List<ConceptCardData> mCardDatasDefault;
    [Token(Token = "0x4009603")]
    [FieldOffset(Offset = "0x20")]
    private List<ConceptCardIcon> mCardIcons;
    [Token(Token = "0x4009604")]
    [FieldOffset(Offset = "0x24")]
    private int mFirstCardIndex;
    [Token(Token = "0x4009605")]
    [FieldOffset(Offset = "0x28")]
    private int mCurrentPage;
    [Token(Token = "0x4009606")]
    [FieldOffset(Offset = "0x2C")]
    private int mLastPage;
    [Token(Token = "0x4009607")]
    [FieldOffset(Offset = "0x30")]
    private UnitData mSelectedUnit;
    [Token(Token = "0x4009608")]
    [FieldOffset(Offset = "0x34")]
    private ConceptCardData mSelectedConceptCardData;
    [Token(Token = "0x4009609")]
    [FieldOffset(Offset = "0x38")]
    private ConceptCardData mReservedSelectConceptCardData;
    [Token(Token = "0x400960A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mNoEquipButtonObject;
    [Token(Token = "0x400960B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mCardObjectTemplate;
    [Token(Token = "0x400960C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private RectTransform mCardObjectParent;
    [Token(Token = "0x400960D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mCardEmptyMessageText;

    [Token(Token = "0x17001459")]
    public int CurrentPage
    {
      [Token(Token = "0x6008FF6"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700145A")]
    public int LastPage
    {
      [Token(Token = "0x6008FF7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700145B")]
    private RectTransform RT
    {
      [Token(Token = "0x6008FF8"), Address(RVA = "0x530CB0", Offset = "0x52FAB0", VA = "0x10530CB0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x1700145C")]
    private GridLayoutGroup Grid
    {
      [Token(Token = "0x6008FF9"), Address(RVA = "0x530BD0", Offset = "0x52F9D0", VA = "0x10530BD0")] get
      {
        return (GridLayoutGroup) null;
      }
    }

    [Token(Token = "0x1700145D")]
    public ConceptCardData SelectedConceptCardData
    {
      [Token(Token = "0x6008FFA"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x1700145E")]
    public bool IsIgnoreEquipedConceptCard
    {
      [Token(Token = "0x6008FFB"), Address(RVA = "0x530C50", Offset = "0x52FA50", VA = "0x10530C50")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008FFC"), Address(RVA = "0x530D70", Offset = "0x52FB70", VA = "0x10530D70")] set
      {
      }
    }

    [Token(Token = "0x6008FFD")]
    [Address(RVA = "0x52F5F0", Offset = "0x52E3F0", VA = "0x1052F5F0")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6008FFE")]
    [Address(RVA = "0x52F240", Offset = "0x52E040", VA = "0x1052F240")]
    public void HideTemplateObject()
    {
    }

    [Token(Token = "0x6008FFF")]
    [Address(RVA = "0x52F280", Offset = "0x52E080", VA = "0x1052F280")]
    public void Init(List<ConceptCardData> card_datas, UnitData selected_unit, bool is_keep_page = false)
    {
    }

    [Token(Token = "0x6009000")]
    [Address(RVA = "0x52FA60", Offset = "0x52E860", VA = "0x1052FA60")]
    public void PageNext()
    {
    }

    [Token(Token = "0x6009001")]
    [Address(RVA = "0x52F960", Offset = "0x52E760", VA = "0x1052F960")]
    public void PageBack()
    {
    }

    [Token(Token = "0x6009002")]
    [Address(RVA = "0x52F9E0", Offset = "0x52E7E0", VA = "0x1052F9E0")]
    public void PageDefault()
    {
    }

    [Token(Token = "0x6009003")]
    [Address(RVA = "0x52EA60", Offset = "0x52D860", VA = "0x1052EA60")]
    private void CreateIcon()
    {
    }

    [Token(Token = "0x6009004")]
    [Address(RVA = "0x52FB10", Offset = "0x52E910", VA = "0x1052FB10")]
    private void RefreshIcon()
    {
    }

    [Token(Token = "0x6009005")]
    [Address(RVA = "0x5302B0", Offset = "0x52F0B0", VA = "0x105302B0")]
    public void Sort(
      ConceptCardListSortWindow.Type SortType,
      ConceptCardListSortWindow.Type SortOrderType)
    {
    }

    [Token(Token = "0x6009006")]
    [Address(RVA = "0x52ECC0", Offset = "0x52DAC0", VA = "0x1052ECC0")]
    public void Filter()
    {
    }

    [Token(Token = "0x6009007")]
    [Address(RVA = "0x52E9F0", Offset = "0x52D7F0", VA = "0x1052E9F0")]
    private int CalcLastPage() => new int();

    [Token(Token = "0x6009008")]
    [Address(RVA = "0x52FAE0", Offset = "0x52E8E0", VA = "0x1052FAE0")]
    private void RefreshFirstIconIndex()
    {
    }

    [Token(Token = "0x6009009")]
    [Address(RVA = "0x52FD60", Offset = "0x52EB60", VA = "0x1052FD60")]
    private void RefreshNoEquipButtonObject()
    {
    }

    [Token(Token = "0x600900A")]
    [Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")]
    public void SelectedUnitData(UnitData unit)
    {
    }

    [Token(Token = "0x600900B")]
    [Address(RVA = "0x530000", Offset = "0x52EE00", VA = "0x10530000")]
    public void SelectCardIcon(ConceptCardIcon selected_icon)
    {
    }

    [Token(Token = "0x600900C")]
    [Address(RVA = "0x52FF20", Offset = "0x52ED20", VA = "0x1052FF20")]
    private void ResetSelectCardAnimation()
    {
    }

    [Token(Token = "0x600900D")]
    [Address(RVA = "0x52FD90", Offset = "0x52EB90", VA = "0x1052FD90")]
    private void RefreshSelectedCard()
    {
    }

    [Token(Token = "0x600900E")]
    [Address(RVA = "0x5301E0", Offset = "0x52EFE0", VA = "0x105301E0")]
    private void SelectedCardIconActive()
    {
    }

    [Token(Token = "0x600900F")]
    [Address(RVA = "0x52F0C0", Offset = "0x52DEC0", VA = "0x1052F0C0")]
    private int GetCardPage(ConceptCardData target) => new int();

    [Token(Token = "0x6009010")]
    [Address(RVA = "0x52F940", Offset = "0x52E740", VA = "0x1052F940")]
    public void OpenSelectIconExistPage(ConceptCardData card)
    {
    }

    [Token(Token = "0x6009011")]
    [Address(RVA = "0x52F020", Offset = "0x52DE20", VA = "0x1052F020")]
    private int GetActiveIconCount() => new int();

    [Token(Token = "0x1700145F")]
    private int CellCount
    {
      [Token(Token = "0x6009012"), Address(RVA = "0x530900", Offset = "0x52F700", VA = "0x10530900")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6009013")]
    [Address(RVA = "0x52F920", Offset = "0x52E720", VA = "0x1052F920", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x6009014")]
    [Address(RVA = "0x530820", Offset = "0x52F620", VA = "0x10530820")]
    public ConceptCardEquipList()
    {
    }
  }
}
