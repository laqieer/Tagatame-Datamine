// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200206A")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestStart")]
  [FlowNode.Pin(10001, "設定を閉じる", FlowNode.PinTypes.Output, 10001)]
  [FlowNode.Pin(203, "刻印自動分解設定保存API開始", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(202, "刻印自動分解設定変更", FlowNode.PinTypes.Input, 202)]
  [FlowNode.Pin(103, "Raycastを有効化", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(201, "設定を閉じた", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(12, "表示更新", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(13, "時間計測バトル", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(102, "AP回復", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "周回リクエスト", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "出撃をタップ", FlowNode.PinTypes.Input, 11)]
  public class AutoRepeatQuestStart : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008B57")]
    private const int PIN_IN_INIT = 10;
    [Token(Token = "0x4008B58")]
    private const int PIN_OT_INIT = 100;
    [Token(Token = "0x4008B59")]
    private const int PIN_IN_CLICK_START = 11;
    [Token(Token = "0x4008B5A")]
    private const int PIN_OT_REQUEST = 101;
    [Token(Token = "0x4008B5B")]
    private const int PIN_OT_HEAL_AP = 102;
    [Token(Token = "0x4008B5C")]
    private const int PIN_IN_REFRESH = 12;
    [Token(Token = "0x4008B5D")]
    private const int PIN_IN_START_QUEST = 13;
    [Token(Token = "0x4008B5E")]
    private const int PIN_OT_CANVAS_BLOCK_RAYCAST_ON = 103;
    [Token(Token = "0x4008B5F")]
    private const int PIN_INPUT_WINDOW_CLOSE = 201;
    [Token(Token = "0x4008B60")]
    private const int PIN_INPUT_RUNE_DISASSEMBLE_CHANGE = 202;
    [Token(Token = "0x4008B61")]
    private const int PIN_OUTPUT_START_REQ_RUNE_DISASSEMBLE = 203;
    [Token(Token = "0x4008B62")]
    private const int PIN_OUTPUT_WINDOW_CLOSE = 10001;
    [Token(Token = "0x4008B63")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text QuestClearTime;
    [Token(Token = "0x4008B64")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text SelectAutoLapNum;
    [Token(Token = "0x4008B65")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle UseNotification;
    [Token(Token = "0x4008B66")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button AutoLapNumAdd;
    [Token(Token = "0x4008B67")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button AutoLapNumSub;
    [Token(Token = "0x4008B68")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle UseAPHealItem;
    [Token(Token = "0x4008B69")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ToggleGroup Group;
    [Token(Token = "0x4008B6A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle UseSelectLapNum;
    [Token(Token = "0x4008B6B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Toggle UseSelectBoxFull;
    [Token(Token = "0x4008B6C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle mPushNotifyToggle;
    [Token(Token = "0x4008B6D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mBoxSizeText;
    [Token(Token = "0x4008B6E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button mStartButton;
    [Token(Token = "0x4008B6F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mMeasureText;
    [Token(Token = "0x4008B70")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mDisableReasonText;
    [Token(Token = "0x4008B71")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mDisableMask;
    [Token(Token = "0x4008B72")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mMeasureButton;
    [Token(Token = "0x4008B73")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mReMeasureButton;
    [Token(Token = "0x4008B74")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mFooterUI_Enable;
    [Token(Token = "0x4008B75")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mFooterUI_Disable;
    [Token(Token = "0x4008B76")]
    [FieldOffset(Offset = "0x58")]
    [HeaderBar("▼刻印自動分解設定")]
    [SerializeField]
    private GameObject Runedisassembly;
    [Token(Token = "0x4008B77")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Toggle RuneCheckBox;
    [Token(Token = "0x4008B78")]
    [FieldOffset(Offset = "0x60")]
    private int m_LapNum;
    [Token(Token = "0x4008B79")]
    [FieldOffset(Offset = "0x64")]
    private int m_MaxLapNum;
    [Token(Token = "0x4008B7A")]
    [FieldOffset(Offset = "0x68")]
    private bool m_SelectBoxFull;
    [Token(Token = "0x4008B7B")]
    [FieldOffset(Offset = "0x69")]
    private bool m_UseLocalNotification;
    [Token(Token = "0x4008B7C")]
    [FieldOffset(Offset = "0x0")]
    private static AutoRepeatQuestStart mInstance;
    [Token(Token = "0x4008B7D")]
    [FieldOffset(Offset = "0x6A")]
    private bool mIsAutoDisassembleAPI;

    [Token(Token = "0x17001316")]
    public int LapNum
    {
      [Token(Token = "0x60086AA"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001317")]
    public bool IsUseAPHealItem
    {
      [Token(Token = "0x60086AB"), Address(RVA = "0x4820C0", Offset = "0x480EC0", VA = "0x104820C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001318")]
    public bool IsUseNotification
    {
      [Token(Token = "0x60086AC"), Address(RVA = "0x2B8B20", Offset = "0x2B7920", VA = "0x102B8B20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001319")]
    public bool IsSelectBoxFull
    {
      [Token(Token = "0x60086AD"), Address(RVA = "0x352390", Offset = "0x351190", VA = "0x10352390")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700131A")]
    public static AutoRepeatQuestStart Instance
    {
      [Token(Token = "0x60086AE"), Address(RVA = "0x482090", Offset = "0x480E90", VA = "0x10482090")] get
      {
        return (AutoRepeatQuestStart) null;
      }
    }

    [Token(Token = "0x60086AF")]
    [Address(RVA = "0x4804A0", Offset = "0x47F2A0", VA = "0x104804A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60086B0")]
    [Address(RVA = "0x480550", Offset = "0x47F350", VA = "0x10480550")]
    private void Awake()
    {
    }

    [Token(Token = "0x60086B1")]
    [Address(RVA = "0x481350", Offset = "0x480150", VA = "0x10481350")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60086B2")]
    [Address(RVA = "0x480C40", Offset = "0x47FA40", VA = "0x10480C40")]
    private void Init()
    {
    }

    [Token(Token = "0x60086B3")]
    [Address(RVA = "0x481B60", Offset = "0x480960", VA = "0x10481B60")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60086B4")]
    [Address(RVA = "0x481C20", Offset = "0x480A20", VA = "0x10481C20")]
    private void StartQuest()
    {
    }

    [Token(Token = "0x60086B5")]
    [Address(RVA = "0x481390", Offset = "0x480190", VA = "0x10481390")]
    private void OnLapNumAdd(Button button, bool is_refresh_btn_interactable)
    {
    }

    [Token(Token = "0x60086B6")]
    [Address(RVA = "0x481410", Offset = "0x480210", VA = "0x10481410")]
    private void OnLapNumSub(Button button, bool is_refresh_btn_interactable)
    {
    }

    [Token(Token = "0x60086B7")]
    [Address(RVA = "0x4816D0", Offset = "0x4804D0", VA = "0x104816D0")]
    private void RefreshSelectLapNumUI(bool is_refresh_btn_interactable = true)
    {
    }

    [Token(Token = "0x60086B8")]
    [Address(RVA = "0x4817F0", Offset = "0x4805F0", VA = "0x104817F0")]
    private void RefreshUI_Enable_or_Disable(QuestParam quest)
    {
    }

    [Token(Token = "0x60086B9")]
    [Address(RVA = "0x480A60", Offset = "0x47F860", VA = "0x10480A60")]
    private string GetDisableReason(QuestParam quest) => (string) null;

    [Token(Token = "0x60086BA")]
    [Address(RVA = "0x481500", Offset = "0x480300", VA = "0x10481500")]
    private void OnSelectToggle(bool value = false)
    {
    }

    [Token(Token = "0x60086BB")]
    [Address(RVA = "0x481490", Offset = "0x480290", VA = "0x10481490")]
    private void OnSelectTogglePushSetting(bool value = false)
    {
    }

    [Token(Token = "0x60086BC")]
    [Address(RVA = "0x4810A0", Offset = "0x47FEA0", VA = "0x104810A0")]
    private void OnClickStart()
    {
    }

    [Token(Token = "0x60086BD")]
    [Address(RVA = "0x482060", Offset = "0x480E60", VA = "0x10482060")]
    public AutoRepeatQuestStart()
    {
    }
  }
}
