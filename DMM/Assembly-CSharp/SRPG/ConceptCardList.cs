// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardList
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
  [Token(Token = "0x2002228")]
  [FlowNode.Pin(4, "複数選択を戻す", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(1, "選択クリア", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(5, "バックアップ作成", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(10, "フィルタ適用", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/ConceptCardList")]
  [FlowNode.Pin(3, "複数選択の登録", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "アイコン更新", FlowNode.PinTypes.Input, 2)]
  public class ConceptCardList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009725")]
    private const string SAVE_TOGGLE_SELECT_SAME_CARD_KEY = "TOGGLE_SAME_CARD";
    [Token(Token = "0x4009726")]
    public const int PIN_CLEAR = 1;
    [Token(Token = "0x4009727")]
    public const int PIN_REFRESH = 2;
    [Token(Token = "0x4009728")]
    public const int PIN_REGIST_MAT = 3;
    [Token(Token = "0x4009729")]
    public const int PIN_REVERT_MAT = 4;
    [Token(Token = "0x400972A")]
    public const int PIN_BACKUP_MAT = 5;
    [Token(Token = "0x400972B")]
    public const int PIN_FILTER = 10;
    [Token(Token = "0x400972C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int MAX_MULTI_SELECT;
    [Token(Token = "0x400972D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardList.ListType mListType;
    [Token(Token = "0x400972E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ConceptCardList.ListIconCalc mListIconCalc;
    [Token(Token = "0x400972F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCardObjectTemplate;
    [Token(Token = "0x4009730")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RectTransform mCardObjectParent;
    [Token(Token = "0x4009731")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject EmptyMessage;
    [Token(Token = "0x4009732")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text PageIndex;
    [Token(Token = "0x4009733")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text PageIndexMax;
    [Token(Token = "0x4009734")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button ForwardButton;
    [Token(Token = "0x4009735")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button PrevButton;
    [Token(Token = "0x4009736")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text SortTypeText;
    [Token(Token = "0x4009737")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ImageArray FilterBgImages;
    [Token(Token = "0x4009738")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text CurrSelectedNum;
    [Token(Token = "0x4009739")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text MaxSelectedNum;
    [Token(Token = "0x400973A")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text TextSellZeny;
    [Token(Token = "0x400973B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text TextSellCoin;
    [Token(Token = "0x400973C")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text TextMixCost;
    [Token(Token = "0x400973D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text TextExp;
    [Token(Token = "0x400973E")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text TextTrust;
    [Token(Token = "0x400973F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject TextWarningObject;
    [Token(Token = "0x4009740")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Button[] SelectedInteractableButton;
    [Token(Token = "0x4009741")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text CurrentConceptCardNum;
    [Token(Token = "0x4009742")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text MaxConceptCardNum;
    [Token(Token = "0x4009743")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Toggle mIgnoreSelectSameConceptCardToggle;
    [Token(Token = "0x4009744")]
    [FieldOffset(Offset = "0x6C")]
    private ConceptCardManager mCCManager;
    [Token(Token = "0x4009745")]
    [FieldOffset(Offset = "0x70")]
    private List<GameObject> mCardIcons;
    [Token(Token = "0x4009746")]
    [FieldOffset(Offset = "0x74")]
    private MultiConceptCard mSortDataList;
    [Token(Token = "0x4009747")]
    [FieldOffset(Offset = "0x78")]
    private MultiConceptCard mSelectedMaterials;
    [Token(Token = "0x4009748")]
    [FieldOffset(Offset = "0x7C")]
    private MultiConceptCard mBackupSelectedMaterials;
    [Token(Token = "0x4009749")]
    [FieldOffset(Offset = "0x80")]
    private int mPage;
    [Token(Token = "0x400974A")]
    [FieldOffset(Offset = "0x84")]
    private int mMaxPages;
    [Token(Token = "0x400974B")]
    [FieldOffset(Offset = "0x88")]
    private int mPageSize;

    [Token(Token = "0x1700146F")]
    private ConceptCardManager CCManager
    {
      [Token(Token = "0x6009121"), Address(RVA = "0x54D030", Offset = "0x54BE30", VA = "0x1054D030")] get
      {
        return (ConceptCardManager) null;
      }
    }

    [Token(Token = "0x17001470")]
    private List<ConceptCardData> PlayerConceptCards
    {
      [Token(Token = "0x6009122"), Address(RVA = "0x54D390", Offset = "0x54C190", VA = "0x1054D390")] get
      {
        return (List<ConceptCardData>) null;
      }
    }

    [Token(Token = "0x6009123")]
    [Address(RVA = "0x549FD0", Offset = "0x548DD0", VA = "0x10549FD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009124")]
    [Address(RVA = "0x54A8C0", Offset = "0x5496C0", VA = "0x1054A8C0")]
    public void Init()
    {
    }

    [Token(Token = "0x17001471")]
    public int CellCount
    {
      [Token(Token = "0x6009125"), Address(RVA = "0x54D0F0", Offset = "0x54BEF0", VA = "0x1054D0F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6009126")]
    [Address(RVA = "0x54A270", Offset = "0x549070", VA = "0x1054A270")]
    private void ClearSelected()
    {
    }

    [Token(Token = "0x6009127")]
    [Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x1054CD70")]
    private void RegistMultiSelect()
    {
    }

    [Token(Token = "0x6009128")]
    [Address(RVA = "0x54A840", Offset = "0x549640", VA = "0x1054A840")]
    private void IncorporateMultiSelect()
    {
    }

    [Token(Token = "0x6009129")]
    [Address(RVA = "0x54A1E0", Offset = "0x548FE0", VA = "0x1054A1E0")]
    private void BackupMultiSelect()
    {
    }

    [Token(Token = "0x600912A")]
    [Address(RVA = "0x54B330", Offset = "0x54A130", VA = "0x1054B330")]
    private void RefreshIconList(bool filter = false)
    {
    }

    [Token(Token = "0x600912B")]
    [Address(RVA = "0x54AAB0", Offset = "0x5498B0", VA = "0x1054AAB0")]
    private void InstantiateIcons()
    {
    }

    [Token(Token = "0x600912C")]
    [Address(RVA = "0x54AF70", Offset = "0x549D70", VA = "0x1054AF70")]
    private void RefreshConceptCardNum()
    {
    }

    [Token(Token = "0x600912D")]
    [Address(RVA = "0x54A2D0", Offset = "0x5490D0", VA = "0x1054A2D0")]
    private MultiConceptCard CurrMaterials() => (MultiConceptCard) null;

    [Token(Token = "0x600912E")]
    [Address(RVA = "0x54A540", Offset = "0x549340", VA = "0x1054A540")]
    public void Filter(List<ConceptCardData> card_list)
    {
    }

    [Token(Token = "0x600912F")]
    [Address(RVA = "0x54A6D0", Offset = "0x5494D0", VA = "0x1054A6D0")]
    private MultiConceptCard GetIconList() => (MultiConceptCard) null;

    [Token(Token = "0x6009130")]
    [Address(RVA = "0x54BA90", Offset = "0x54A890", VA = "0x1054BA90")]
    private void RefreshIcons(MultiConceptCard drawicons, MultiConceptCard materials)
    {
    }

    [Token(Token = "0x6009131")]
    [Address(RVA = "0x54BE50", Offset = "0x54AC50", VA = "0x1054BE50")]
    private void RefreshPage()
    {
    }

    [Token(Token = "0x6009132")]
    [Address(RVA = "0x54A810", Offset = "0x549610", VA = "0x1054A810")]
    public void GotoPreviousPage()
    {
    }

    [Token(Token = "0x6009133")]
    [Address(RVA = "0x54A7E0", Offset = "0x5495E0", VA = "0x1054A7E0")]
    public void GotoNextPage()
    {
    }

    [Token(Token = "0x6009134")]
    [Address(RVA = "0x54BFF0", Offset = "0x54ADF0", VA = "0x1054BFF0")]
    private void RefreshParameter()
    {
    }

    [Token(Token = "0x6009135")]
    [Address(RVA = "0x54C580", Offset = "0x54B380", VA = "0x1054C580")]
    private void RefreshSelected()
    {
    }

    [Token(Token = "0x6009136")]
    [Address(RVA = "0x54CBA0", Offset = "0x54B9A0", VA = "0x1054CBA0")]
    private void RefreshTextSellZeny()
    {
    }

    [Token(Token = "0x6009137")]
    [Address(RVA = "0x54CB00", Offset = "0x54B900", VA = "0x1054CB00")]
    private void RefreshTextSellCoin()
    {
    }

    [Token(Token = "0x6009138")]
    [Address(RVA = "0x54C980", Offset = "0x54B780", VA = "0x1054C980")]
    private void RefreshTextMixCost()
    {
    }

    [Token(Token = "0x6009139")]
    [Address(RVA = "0x54C830", Offset = "0x54B630", VA = "0x1054C830")]
    private void RefreshTextExpAndTrust()
    {
    }

    [Token(Token = "0x600913A")]
    [Address(RVA = "0x54CC40", Offset = "0x54BA40", VA = "0x1054CC40")]
    private void RefreshTextWarning()
    {
    }

    [Token(Token = "0x600913B")]
    [Address(RVA = "0x54B0B0", Offset = "0x549EB0", VA = "0x1054B0B0")]
    private void RefreshEnableParam(
      ConceptCardIconMultiSelect drawicons,
      MultiConceptCard materials,
      bool AcceptableExp,
      bool AcceptableTrust,
      bool CanAwake)
    {
    }

    [Token(Token = "0x600913C")]
    [Address(RVA = "0x54C480", Offset = "0x54B280", VA = "0x1054C480")]
    private void RefreshSelectParam(
      ConceptCardIconMultiSelect drawicons,
      MultiConceptCard materials)
    {
    }

    [Token(Token = "0x600913D")]
    [Address(RVA = "0x54C6A0", Offset = "0x54B4A0", VA = "0x1054C6A0")]
    private void RefreshSortFilterObjects()
    {
    }

    [Token(Token = "0x600913E")]
    [Address(RVA = "0x54AD00", Offset = "0x549B00", VA = "0x1054AD00")]
    private void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600913F")]
    [Address(RVA = "0x54ADB0", Offset = "0x549BB0", VA = "0x1054ADB0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x6009140")]
    [Address(RVA = "0x54A700", Offset = "0x549500", VA = "0x1054A700")]
    private bool GetToggleSameSelect() => new bool();

    [Token(Token = "0x6009141")]
    [Address(RVA = "0x54AC70", Offset = "0x549A70", VA = "0x1054AC70")]
    public void OnChangeIgnoreSameCardToggle(bool isOn)
    {
    }

    [Token(Token = "0x6009142")]
    [Address(RVA = "0x54CDB0", Offset = "0x54BBB0", VA = "0x1054CDB0")]
    private void SaveSameConceptCardToggle()
    {
    }

    [Token(Token = "0x6009143")]
    [Address(RVA = "0x54CF30", Offset = "0x54BD30", VA = "0x1054CF30")]
    public ConceptCardList()
    {
    }

    [Token(Token = "0x2002229")]
    public enum ListType
    {
      [Token(Token = "0x400974D")] NORMAL,
      [Token(Token = "0x400974E")] ENHANCE,
      [Token(Token = "0x400974F")] SELL,
      [Token(Token = "0x4009750")] MANAGER,
    }

    [Token(Token = "0x200222A")]
    public enum ListIconCalc
    {
      [Token(Token = "0x4009752")] AUTO,
      [Token(Token = "0x4009753")] SEPCIFY,
    }
  }
}
