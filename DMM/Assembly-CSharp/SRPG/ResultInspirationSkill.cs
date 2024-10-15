// Decompiled with JetBrains decompiler
// Type: SRPG.ResultInspirationSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C65")]
  [FlowNode.Pin(1, "開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "セット", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("Battle/BattleUI/ResultInspirationSkill")]
  [FlowNode.Pin(111, "終了", FlowNode.PinTypes.Output, 111)]
  public class ResultInspirationSkill : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4002168")]
    [FieldOffset(Offset = "0xC")]
    private readonly string LOCAL_EVENT_TIGGER_BTN_ON;
    [Token(Token = "0x4002169")]
    [FieldOffset(Offset = "0x10")]
    private readonly string LOCAL_EVENT_TIGGER_BTN_OFF;
    [Token(Token = "0x400216A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400216B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(5f)]
    private GameObject[] GoInsps;
    [Token(Token = "0x400216C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject[] GoLvUps;
    [Token(Token = "0x400216D")]
    [FieldOffset(Offset = "0x20")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoBindUnit;
    [Token(Token = "0x400216E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject GoBindArtifact;
    [Token(Token = "0x400216F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject GoBindAbility;
    [Token(Token = "0x4002170")]
    [FieldOffset(Offset = "0x2C")]
    [Space(5f)]
    [SerializeField]
    private SRPG_Button NextBtn;
    [Token(Token = "0x4002171")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SRPG_Button SetBtn;
    [Token(Token = "0x4002172")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private SRPG_Button ResetBtn;
    [Token(Token = "0x4002173")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text ResetNeedCoin;
    [Token(Token = "0x4002174")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private SRPG_Button CloseAllBtn;
    [Token(Token = "0x4002175")]
    [FieldOffset(Offset = "0x40")]
    [Space(5f)]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PREFAB_PATH_INSPIRATION_SKIILL_WINDOW;
    [Token(Token = "0x4002176")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x4002177")]
    private const int PIN_OUT_SET = 101;
    [Token(Token = "0x4002178")]
    private const int PIN_OUT_EXIT = 111;
    [Token(Token = "0x4002179")]
    [FieldOffset(Offset = "0x0")]
    private static BattleCore.Record mRecord;
    [Token(Token = "0x400217A")]
    [FieldOffset(Offset = "0x4")]
    private static int mInspCount;
    [Token(Token = "0x400217B")]
    [FieldOffset(Offset = "0x8")]
    private static int mLvUpCount;

    [Token(Token = "0x60030DC")]
    [Address(RVA = "0x10235D0", Offset = "0x10223D0", VA = "0x110235D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60030DD")]
    [Address(RVA = "0x1024160", Offset = "0x1022F60", VA = "0x11024160")]
    private void EnableGos(GameObject[] gos, bool is_enable)
    {
    }

    [Token(Token = "0x60030DE")]
    [Address(RVA = "0x10236A0", Offset = "0x10224A0", VA = "0x110236A0")]
    private void EffectStart()
    {
    }

    [Token(Token = "0x60030DF")]
    [Address(RVA = "0x1024610", Offset = "0x1023410", VA = "0x11024610")]
    private void OnNext()
    {
    }

    [Token(Token = "0x60030E0")]
    [Address(RVA = "0x1024640", Offset = "0x1023440", VA = "0x11024640")]
    private void OnSet()
    {
    }

    [Token(Token = "0x60030E1")]
    [Address(RVA = "0x1024360", Offset = "0x1023160", VA = "0x11024360")]
    public void OnCreateResetWindow(BattleCore.Record.InspResult insp_result)
    {
    }

    [Token(Token = "0x60030E2")]
    [Address(RVA = "0x10235B0", Offset = "0x10223B0", VA = "0x110235B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60030E3")]
    [Address(RVA = "0x1024200", Offset = "0x1023000", VA = "0x11024200")]
    private static void Init()
    {
    }

    [Token(Token = "0x60030E4")]
    [Address(RVA = "0x1023640", Offset = "0x1022440", VA = "0x11023640")]
    private static void Finish()
    {
    }

    [Token(Token = "0x60030E5")]
    [Address(RVA = "0x1024200", Offset = "0x1023000", VA = "0x11024200")]
    public static void InitEffect()
    {
    }

    [Token(Token = "0x60030E6")]
    [Address(RVA = "0x1023640", Offset = "0x1022440", VA = "0x11023640")]
    public static void DestroyEffect()
    {
    }

    [Token(Token = "0x60030E7")]
    [Address(RVA = "0x1024320", Offset = "0x1023120", VA = "0x11024320")]
    public static bool IsRemainEffect() => new bool();

    [Token(Token = "0x60030E8")]
    [Address(RVA = "0x1024690", Offset = "0x1023490", VA = "0x11024690")]
    public ResultInspirationSkill()
    {
    }
  }
}
