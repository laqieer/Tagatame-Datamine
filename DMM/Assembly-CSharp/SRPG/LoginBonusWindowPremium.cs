// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusWindowPremium
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
  [Token(Token = "0x20026F6")]
  [AddComponentMenu("UI/LoginBonusWindowPremium")]
  [FlowNode.Pin(4, "次のページへ切り替え", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "次のページボタン", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "前のページボタン", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "アイテムアイコンの選択", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ログインボーナス取得演出後", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(108, "ページ最後のログインボーナスを受け取り次のページへ", FlowNode.PinTypes.Output, 108)]
  [FlowNode.Pin(107, "コンフィグ対応から来たときの出口", FlowNode.PinTypes.Output, 107)]
  [FlowNode.Pin(102, "読み込み完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(109, "次のページへ切り替えが終わった後", FlowNode.PinTypes.Output, 109)]
  [FlowNode.Pin(1, "ログインボーナス取得演出", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(106, "ページ切り替えボタンを押した後", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(105, "ログインカウントが0か指定回数以上の場合", FlowNode.PinTypes.Output, 105)]
  public class LoginBonusWindowPremium : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B75B")]
    private const int PIN_TAKE_BONUS = 1;
    [Token(Token = "0x400B75C")]
    private const int PIN_PREV_BUTTON = 2;
    [Token(Token = "0x400B75D")]
    private const int PIN_NEXT_BUTTON = 3;
    [Token(Token = "0x400B75E")]
    private const int PIN_AUTO_NEXT_PAGE = 4;
    [Token(Token = "0x400B75F")]
    private const int PIN_SELECT_ITEM_ICON = 100;
    [Token(Token = "0x400B760")]
    private const int PIN_TAKED_BONUS = 101;
    [Token(Token = "0x400B761")]
    private const int PIN_READ_COMPLETE = 102;
    [Token(Token = "0x400B762")]
    private const int PIN_NOT_TAKED_BONUS = 105;
    [Token(Token = "0x400B763")]
    private const int PIN_PUSH_PAGE_BUTTON = 106;
    [Token(Token = "0x400B764")]
    private const int PIN_CONFIG_BUTTON = 107;
    [Token(Token = "0x400B765")]
    private const int PIN_TAKED_BONUS_NEXTPAGE = 108;
    [Token(Token = "0x400B766")]
    private const int PIN_AFTER_NEXT_PAGE = 109;
    [Token(Token = "0x400B767")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼ViewList関連")]
    private Transform ParentViewList;
    [Token(Token = "0x400B768")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject BaseList;
    [Token(Token = "0x400B769")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int PateItemNum;
    [Token(Token = "0x400B76A")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼アイコン表示用オブジェクト")]
    [SerializeField]
    private string ParentItemGridPath;
    [Token(Token = "0x400B76B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string TemplateItemGridPath;
    [Token(Token = "0x400B76C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ListItemEvents Item_Normal;
    [Token(Token = "0x400B76D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ListItemEvents Item_Taken;
    [Token(Token = "0x400B76E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [HeaderBar("▼演出時のアイコン表示用オブジェクト")]
    private RectTransform TodayBadge;
    [Token(Token = "0x400B76F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RectTransform TommorowBadge;
    [Token(Token = "0x400B770")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HeaderBar("▼残り日数")]
    private Text RemainingCount;
    [Token(Token = "0x400B771")]
    [FieldOffset(Offset = "0x34")]
    [HeaderBar("▼今フィル画面の表示かどうか")]
    [SerializeField]
    private bool IsConfigWindow;
    [Token(Token = "0x400B772")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [HeaderBar("▼ゲームオブジェクト名")]
    private string CheckName;
    [Token(Token = "0x400B773")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("▼初日のみ非表示にするゲームオブジェクト")]
    [SerializeField]
    private string[] DisabledFirstDayNames;
    [Token(Token = "0x400B774")]
    [FieldOffset(Offset = "0x40")]
    [HeaderBar("▼今日ゲットするアイテムに付けるエフェクト")]
    [SerializeField]
    private GameObject BonusParticleEffect;
    [Token(Token = "0x400B775")]
    [FieldOffset(Offset = "0x44")]
    [HeaderBar("▼ウィンドウにあるメッセージテキスト")]
    [SerializeField]
    private Text WindowMessageText;
    [Token(Token = "0x400B776")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼アイテムアイコンにあるカウント")]
    [SerializeField]
    private string ItemIconCountPath;
    [Token(Token = "0x400B777")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [HeaderBar("▼アイテム数表示")]
    private string ItemNumPath;
    [Token(Token = "0x400B778")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼ページ数表示")]
    [SerializeField]
    private Text PageCountText;
    [Token(Token = "0x400B779")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text PageCountTextMax;
    [Token(Token = "0x400B77A")]
    [FieldOffset(Offset = "0x58")]
    [HeaderBar("▼ページ切り替えボタン")]
    [SerializeField]
    private Button PrevPageButton;
    [Token(Token = "0x400B77B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Button NextPageButton;
    [Token(Token = "0x400B77C")]
    [FieldOffset(Offset = "0x60")]
    private int mLoginBonusCount;
    [Token(Token = "0x400B77D")]
    [FieldOffset(Offset = "0x64")]
    private bool mIsBuyPremium;
    [Token(Token = "0x400B77E")]
    [FieldOffset(Offset = "0x68")]
    private UnitPreview mCurrentPreview;
    [Token(Token = "0x400B77F")]
    [FieldOffset(Offset = "0x6C")]
    private RenderTexture mPreviewUnitRT;
    [Token(Token = "0x400B780")]
    [FieldOffset(Offset = "0x70")]
    private LoginBonusWindow mMessageWindow;
    [Token(Token = "0x400B781")]
    [FieldOffset(Offset = "0x74")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x400B782")]
    [FieldOffset(Offset = "0x78")]
    private List<GameObject> mViewLists;
    [Token(Token = "0x400B783")]
    [FieldOffset(Offset = "0x7C")]
    private int mPageNum;
    [Token(Token = "0x400B784")]
    [FieldOffset(Offset = "0x80")]
    private int mPageNumMax;

    [Token(Token = "0x17001829")]
    public bool ConfigWindow
    {
      [Token(Token = "0x600AE84"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] set
      {
      }
    }

    [Token(Token = "0x600AE85")]
    [Address(RVA = "0x726690", Offset = "0x725490", VA = "0x10726690")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE86")]
    [Address(RVA = "0x727040", Offset = "0x725E40", VA = "0x10727040")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AE87")]
    [Address(RVA = "0x727460", Offset = "0x726260", VA = "0x10727460")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE88")]
    [Address(RVA = "0x727160", Offset = "0x725F60", VA = "0x10727160")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AE89")]
    [Address(RVA = "0x726800", Offset = "0x725600", VA = "0x10726800")]
    private void DisableFirstDayHiddenOject(GameObject parent)
    {
    }

    [Token(Token = "0x600AE8A")]
    [Address(RVA = "0x7264C0", Offset = "0x7252C0", VA = "0x107264C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE8B")]
    [Address(RVA = "0x726930", Offset = "0x725730", VA = "0x10726930")]
    private void FlipTodaysItem()
    {
    }

    [Token(Token = "0x600AE8C")]
    [Address(RVA = "0x727340", Offset = "0x726140", VA = "0x10727340")]
    private void PushPrevButton()
    {
    }

    [Token(Token = "0x600AE8D")]
    [Address(RVA = "0x727210", Offset = "0x726010", VA = "0x10727210")]
    private void PushNextButton()
    {
    }

    [Token(Token = "0x600AE8E")]
    [Address(RVA = "0x728520", Offset = "0x727320", VA = "0x10728520")]
    public LoginBonusWindowPremium()
    {
    }
  }
}
