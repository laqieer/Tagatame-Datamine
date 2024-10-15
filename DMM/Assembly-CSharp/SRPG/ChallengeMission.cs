// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002120")]
  [AddComponentMenu("UI/ChallengeMission")]
  [FlowNode.Pin(105, "報酬受け取り、かつトロフィー更新", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(104, "コンプリート報酬受け取りとレビュー表示", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "終了", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(101, "報酬受け取り", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "コンプリート報酬受け取り", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(110, "報酬一括受取", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(20, "報酬一括受取", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(11, "前のページ", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "次のページ", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1, "現在表示中のカテゴリを維持しつつ更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "詳細", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(99, "メッセージ非表示", FlowNode.PinTypes.Input, 99)]
  public class ChallengeMission : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008FA5")]
    private const int PIN_REFRESH = 0;
    [Token(Token = "0x4008FA6")]
    private const int PIN_REFRESH_KEEP_CATEGORY = 1;
    [Token(Token = "0x4008FA7")]
    private const int PIN_NEXT_PAGE = 10;
    [Token(Token = "0x4008FA8")]
    private const int PIN_BACK_PAGE = 11;
    [Token(Token = "0x4008FA9")]
    private const int PIN_INPUT_GETALL_REWARD = 20;
    [Token(Token = "0x4008FAA")]
    private const int PIN_MESSAGE_CLOSE = 99;
    [Token(Token = "0x4008FAB")]
    private const int PIN_DETAIL = 100;
    [Token(Token = "0x4008FAC")]
    private const int PIN_REWARD = 101;
    [Token(Token = "0x4008FAD")]
    private const int PIN_COMPLETE = 102;
    [Token(Token = "0x4008FAE")]
    private const int PIN_END = 103;
    [Token(Token = "0x4008FAF")]
    private const int PIN_COMPLETE_REVIEW = 104;
    [Token(Token = "0x4008FB0")]
    private const int PIN_REWARD_WITH_UPDATE = 105;
    [Token(Token = "0x4008FB1")]
    private const int PIN_OUTPUT_GETALL_REWARD = 110;
    [Token(Token = "0x4008FB2")]
    [FieldOffset(Offset = "0xC")]
    public Image ImageReward;
    [Token(Token = "0x4008FB3")]
    [FieldOffset(Offset = "0x10")]
    public List<ChallengeMissionItem> Items;
    [Token(Token = "0x4008FB4")]
    [FieldOffset(Offset = "0x14")]
    public GameObject PageDotsHolder;
    [Token(Token = "0x4008FB5")]
    [FieldOffset(Offset = "0x18")]
    public GameObject PageDotTemplate;
    [Token(Token = "0x4008FB6")]
    [FieldOffset(Offset = "0x1C")]
    public ChallengeMissionDetail DetailWindow;
    [Token(Token = "0x4008FB7")]
    [FieldOffset(Offset = "0x20")]
    public GameObject CharMessageWindow;
    [Token(Token = "0x4008FB8")]
    [FieldOffset(Offset = "0x24")]
    public Text MessageText;
    [Token(Token = "0x4008FB9")]
    [FieldOffset(Offset = "0x28")]
    public Image Shadow;
    [Token(Token = "0x4008FBA")]
    [FieldOffset(Offset = "0x2C")]
    public Text ShadowText;
    [Token(Token = "0x4008FBB")]
    [FieldOffset(Offset = "0x30")]
    public Text PageNumText;
    [Token(Token = "0x4008FBC")]
    [FieldOffset(Offset = "0x34")]
    public Text PageMaxNumText;
    [Token(Token = "0x4008FBD")]
    [FieldOffset(Offset = "0x38")]
    public Button NextPageButton;
    [Token(Token = "0x4008FBE")]
    [FieldOffset(Offset = "0x3C")]
    public Button BackPageButton;
    [Token(Token = "0x4008FBF")]
    [FieldOffset(Offset = "0x40")]
    public Image CompleteBadge;
    [Token(Token = "0x4008FC0")]
    [FieldOffset(Offset = "0x44")]
    public Image ChallengingBadge;
    [Token(Token = "0x4008FC1")]
    [FieldOffset(Offset = "0x48")]
    private int mRootCount;
    [Token(Token = "0x4008FC2")]
    [FieldOffset(Offset = "0x4C")]
    public List<GameObject> mDotsList;
    [Token(Token = "0x4008FC3")]
    [FieldOffset(Offset = "0x50")]
    private int mCurrentCategoryIndex;
    [Token(Token = "0x4008FC4")]
    [FieldOffset(Offset = "0x54")]
    private ChallengeCategoryParam[] mCategories;
    [Token(Token = "0x4008FC5")]
    [FieldOffset(Offset = "0x58")]
    public Transform CategoryButtonContainer;
    [Token(Token = "0x4008FC6")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject CategoryButtonTemplate;
    [Token(Token = "0x4008FC7")]
    [FieldOffset(Offset = "0x60")]
    public Button BtnCollectiveReceipt;
    [Token(Token = "0x4008FC8")]
    [FieldOffset(Offset = "0x64")]
    public bool UseCharMessage;
    [Token(Token = "0x4008FC9")]
    [FieldOffset(Offset = "0x68")]
    public float CharMessageDelay;
    [Token(Token = "0x4008FCA")]
    [FieldOffset(Offset = "0x6C")]
    private List<ChallengeMissionCategoryButton> mCategoryButtons;
    [Token(Token = "0x4008FCB")]
    [FieldOffset(Offset = "0x70")]
    private int mCurrentPage;
    [Token(Token = "0x4008FCC")]
    [FieldOffset(Offset = "0x74")]
    private Coroutine mMessageCloseCoroutine;

    [Token(Token = "0x6008AC9")]
    [Address(RVA = "0x4F1A40", Offset = "0x4F0840", VA = "0x104F1A40")]
    public static TrophyParam[] GetTropies() => (TrophyParam[]) null;

    [Token(Token = "0x6008ACA")]
    [Address(RVA = "0x4F19C0", Offset = "0x4F07C0", VA = "0x104F19C0")]
    public static TrophyParam GetTrophy(string key) => (TrophyParam) null;

    [Token(Token = "0x6008ACB")]
    [Address(RVA = "0x4F1930", Offset = "0x4F0730", VA = "0x104F1930")]
    public static TrophyState GetTrophyCounter(TrophyParam trophy) => (TrophyState) null;

    [Token(Token = "0x6008ACC")]
    [Address(RVA = "0x4F0500", Offset = "0x4EF300", VA = "0x104F0500", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008ACD")]
    [Address(RVA = "0x4F0640", Offset = "0x4EF440", VA = "0x104F0640")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008ACE")]
    [Address(RVA = "0x4F3BC0", Offset = "0x4F29C0", VA = "0x104F3BC0")]
    private void StartMessageCloseCoroutine()
    {
    }

    [Token(Token = "0x6008ACF")]
    [Address(RVA = "0x4F39C0", Offset = "0x4F27C0", VA = "0x104F39C0")]
    private void ResetMessageCloseCoroutine()
    {
    }

    [Token(Token = "0x6008AD0")]
    [Address(RVA = "0x4F0D30", Offset = "0x4EFB30", VA = "0x104F0D30")]
    private static ChallengeCategoryParam[] GetOpeningCategory() => (ChallengeCategoryParam[]) null;

    [Token(Token = "0x6008AD1")]
    [Address(RVA = "0x4F1BB0", Offset = "0x4F09B0", VA = "0x104F1BB0")]
    private static bool IsCategoryOpening(ChallengeCategoryParam category) => new bool();

    [Token(Token = "0x6008AD2")]
    [Address(RVA = "0x4F1CC0", Offset = "0x4F0AC0", VA = "0x104F1CC0")]
    private void OnClickCategoryButton(int index)
    {
    }

    [Token(Token = "0x6008AD3")]
    [Address(RVA = "0x4F31A0", Offset = "0x4F1FA0", VA = "0x104F31A0")]
    private void Refresh(bool doInitialize, bool autoCategorySelection, bool changeCategory = false)
    {
    }

    [Token(Token = "0x6008AD4")]
    [Address(RVA = "0x4F0A00", Offset = "0x4EF800", VA = "0x104F0A00")]
    private void ChangeRewardImage(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008AD5")]
    [Address(RVA = "0x4F21B0", Offset = "0x4F0FB0", VA = "0x104F21B0")]
    private void OpenNewPage(TrophyParam rootTrophy, bool doInitialize)
    {
    }

    [Token(Token = "0x6008AD6")]
    [Address(RVA = "0x4F2DD0", Offset = "0x4F1BD0", VA = "0x104F2DD0")]
    private void OpenNonAchievedPage(int newPage)
    {
    }

    [Token(Token = "0x6008AD7")]
    [Address(RVA = "0x4F1AB0", Offset = "0x4F08B0", VA = "0x104F1AB0")]
    private string HankakuToZenkakuNumber(int num) => (string) null;

    [Token(Token = "0x6008AD8")]
    [Address(RVA = "0x4F0A90", Offset = "0x4EF890", VA = "0x104F0A90")]
    private IEnumerator CloseMessageWindow() => (IEnumerator) null;

    [Token(Token = "0x6008AD9")]
    [Address(RVA = "0x4F1CF0", Offset = "0x4F0AF0", VA = "0x104F1CF0")]
    private void OnSelectItem(TrophyParam selectTrophy, IEnumerable<TrophyParam> siblingTrophies)
    {
    }

    [Token(Token = "0x6008ADA")]
    [Address(RVA = "0x4F1130", Offset = "0x4EFF30", VA = "0x104F1130")]
    public static TrophyParam[] GetRootTropies() => (TrophyParam[]) null;

    [Token(Token = "0x6008ADB")]
    [Address(RVA = "0x4F13D0", Offset = "0x4F01D0", VA = "0x104F13D0")]
    public static TrophyParam[] GetRootTropies(string category) => (TrophyParam[]) null;

    [Token(Token = "0x6008ADC")]
    [Address(RVA = "0x4F0CC0", Offset = "0x4EFAC0", VA = "0x104F0CC0")]
    public static TrophyParam GetCurrentRootTrophy(string category) => (TrophyParam) null;

    [Token(Token = "0x6008ADD")]
    [Address(RVA = "0x4F0B00", Offset = "0x4EF900", VA = "0x104F0B00")]
    public static TrophyParam[] GetChildeTrophies(TrophyParam root) => (TrophyParam[]) null;

    [Token(Token = "0x6008ADE")]
    [Address(RVA = "0x4F14E0", Offset = "0x4F02E0", VA = "0x104F14E0")]
    private static string GetTopMostPriorityCategory(ChallengeCategoryParam[] categories)
    {
      return (string) null;
    }

    [Token(Token = "0x6008ADF")]
    [Address(RVA = "0x4F1500", Offset = "0x4F0300", VA = "0x104F1500")]
    public static TrophyParam GetTopMostPriorityTrophy() => (TrophyParam) null;

    [Token(Token = "0x6008AE0")]
    [Address(RVA = "0x4F1520", Offset = "0x4F0320", VA = "0x104F1520")]
    public static TrophyParam GetTopMostPriorityTrophy(ChallengeCategoryParam[] categories)
    {
      return (TrophyParam) null;
    }

    [Token(Token = "0x6008AE1")]
    [Address(RVA = "0x4F16D0", Offset = "0x4F04D0", VA = "0x104F16D0")]
    public static TrophyParam[] GetTrophiesSortedByPriority(TrophyParam[] trophies)
    {
      return (TrophyParam[]) null;
    }

    [Token(Token = "0x6008AE2")]
    [Address(RVA = "0x4F1110", Offset = "0x4EFF10", VA = "0x104F1110")]
    public static TrophyParam[] GetRootTrophiesSortedByPriority() => (TrophyParam[]) null;

    [Token(Token = "0x6008AE3")]
    [Address(RVA = "0x4F0C40", Offset = "0x4EFA40", VA = "0x104F0C40")]
    private static int GetCurrentActiveTrophyIndex(TrophyParam[] trophies) => new int();

    [Token(Token = "0x6008AE4")]
    [Address(RVA = "0x4F1C10", Offset = "0x4F0A10", VA = "0x104F1C10")]
    private bool IsEnableCollectiveButton(TrophyParam[] trophys) => new bool();

    [Token(Token = "0x6008AE5")]
    [Address(RVA = "0x4F1CA0", Offset = "0x4F0AA0", VA = "0x104F1CA0")]
    private bool IsIgnoreCollectiveReceive(TrophyParam trophyParam) => new bool();

    [Token(Token = "0x6008AE6")]
    [Address(RVA = "0x4F39F0", Offset = "0x4F27F0", VA = "0x104F39F0")]
    private void SetupRewardAllChallengeMission()
    {
    }

    [Token(Token = "0x6008AE7")]
    [Address(RVA = "0x4F0F70", Offset = "0x4EFD70", VA = "0x104F0F70")]
    private void GetRequestCollectiveReceipt(
      ref List<string> sel_trophy_list,
      ref RewardData reward)
    {
    }

    [Token(Token = "0x6008AE8")]
    [Address(RVA = "0x4F3C40", Offset = "0x4F2A40", VA = "0x104F3C40")]
    public ChallengeMission()
    {
    }
  }
}
