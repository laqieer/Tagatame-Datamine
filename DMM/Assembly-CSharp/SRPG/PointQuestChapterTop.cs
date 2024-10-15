// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestChapterTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200280E")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(153, "ショップ開催なし", FlowNode.PinTypes.Output, 153)]
  [FlowNode.Pin(201, "古代編用戻る", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "スコアチャレンジ用戻る", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(151, "更新ありショップウィンドウ", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(61, "順位更新", FlowNode.PinTypes.Input, 61)]
  [FlowNode.Pin(51, "ショップを開く", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(152, "更新なしショップウィンドウ", FlowNode.PinTypes.Output, 152)]
  [FlowNode.Pin(203, "例外挙動", FlowNode.PinTypes.Output, 203)]
  public class PointQuestChapterTop : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400BED0")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400BED1")]
    public const int PIN_IN_SHOP_OPEN = 51;
    [Token(Token = "0x400BED2")]
    public const int PIN_IN_REFRESH_RANKING = 61;
    [Token(Token = "0x400BED3")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400BED4")]
    public const int PIN_OUT_UPDATE_SHOP = 151;
    [Token(Token = "0x400BED5")]
    public const int PIN_OUT_NOUPDATE_SHOP = 152;
    [Token(Token = "0x400BED6")]
    public const int PIN_OUT_NOT_SHOP = 153;
    [Token(Token = "0x400BED7")]
    public const int PIN_OUT_BACK_DRAGON_GOD = 201;
    [Token(Token = "0x400BED8")]
    public const int PIN_OUT_BACK_SCORE_CHALLENGE = 202;
    [Token(Token = "0x400BED9")]
    public const int PIN_OUT_BACK_EXCEPTION = 203;
    [Token(Token = "0x400BEDA")]
    [FieldOffset(Offset = "0xC")]
    public string mPathPrefix;
    [Token(Token = "0x400BEDB")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼背景画像")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x400BEDC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [HeaderBar("▼ランキングタイトル")]
    private GameObject mPersonRankingTitle;
    [Token(Token = "0x400BEDD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mPortRankingTitle;
    [Token(Token = "0x400BEDE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HeaderBar("▼ランキング数値")]
    private Text mRankingText;
    [Token(Token = "0x400BEDF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HeaderBar("▼難易度ボタン")]
    private Toggle mNormalBtnObject;
    [Token(Token = "0x400BEE0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mNormalOn;
    [Token(Token = "0x400BEE1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle mEliteBtnObject;
    [Token(Token = "0x400BEE2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mEliteOn;
    [Token(Token = "0x400BEE3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle mExtraBtnObject;
    [Token(Token = "0x400BEE4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mExtraOn;
    [Token(Token = "0x400BEE5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [HeaderBar("▼Hard/Extraロックボタン")]
    private SRPG_Button mEliteLockBtn;
    [Token(Token = "0x400BEE6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private SRPG_Button mExtraLockBtn;
    [Token(Token = "0x400BEE7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [HeaderBar("▼チャプター名テキスト")]
    private Text mChapterNameText;
    [Token(Token = "0x400BEE8")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private string mReplaceToken;
    [Token(Token = "0x400BEE9")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼バックボタン")]
    [SerializeField]
    private SRPG_Button mBackBtn;
    [Token(Token = "0x400BEEA")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [HeaderBar("▼ショップボタン")]
    private SRPG_Button mShopButton;
    [Token(Token = "0x400BEEB")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼ボーナスボタン")]
    [SerializeField]
    private SRPG_Button mBonusButton;
    [Token(Token = "0x400BEEC")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    [HeaderBar("▼開催期間")]
    private GameObject mPeriodObject;
    [Token(Token = "0x400BEED")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mPeriodTextObject;
    [Token(Token = "0x400BEEE")]
    [FieldOffset(Offset = "0x5C")]
    private PointQuestEventParam mPointQuestEventParam;
    [Token(Token = "0x400BEEF")]
    [FieldOffset(Offset = "0x60")]
    private ChapterParam mChapterParam;

    [Token(Token = "0x600B4F7")]
    [Address(RVA = "0x7BAC90", Offset = "0x7B9A90", VA = "0x107BAC90")]
    private void Start()
    {
    }

    [Token(Token = "0x600B4F8")]
    [Address(RVA = "0x7B9620", Offset = "0x7B8420", VA = "0x107B9620", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B4F9")]
    [Address(RVA = "0x7B98D0", Offset = "0x7B86D0", VA = "0x107B98D0")]
    private bool Init() => new bool();

    [Token(Token = "0x600B4FA")]
    [Address(RVA = "0x7B97F0", Offset = "0x7B85F0", VA = "0x107B97F0")]
    private void FinishLoad()
    {
    }

    [Token(Token = "0x600B4FB")]
    [Address(RVA = "0x7B9730", Offset = "0x7B8530", VA = "0x107B9730")]
    private void BGDownloaded(GameObject prefab)
    {
    }

    [Token(Token = "0x600B4FC")]
    [Address(RVA = "0x7BA9A0", Offset = "0x7B97A0", VA = "0x107BA9A0")]
    private string RemakeChapterName(string src, string dest) => (string) null;

    [Token(Token = "0x600B4FD")]
    [Address(RVA = "0x7B9810", Offset = "0x7B8610", VA = "0x107B9810", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600B4FE")]
    [Address(RVA = "0x7BA5E0", Offset = "0x7B93E0", VA = "0x107BA5E0")]
    public void OnClickLockImage(SRPG_Button obj)
    {
    }

    [Token(Token = "0x600B4FF")]
    [Address(RVA = "0x7BA450", Offset = "0x7B9250", VA = "0x107BA450")]
    public void OnClickBack(SRPG_Button obj)
    {
    }

    [Token(Token = "0x600B500")]
    [Address(RVA = "0x7BAA10", Offset = "0x7B9810", VA = "0x107BAA10")]
    private void SetRanking()
    {
    }

    [Token(Token = "0x600B501")]
    [Address(RVA = "0x7BAD50", Offset = "0x7B9B50", VA = "0x107BAD50")]
    public PointQuestChapterTop()
    {
    }
  }
}
