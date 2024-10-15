// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200206E")]
  [FlowNode.Pin(20, "初期化", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "自動更新の一時停止ON", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "初期化完了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "自動更新開始", FlowNode.PinTypes.Output, 120)]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestTop")]
  [FlowNode.Pin(11, "自動更新の一時停止OFF", FlowNode.PinTypes.Input, 11)]
  public class AutoRepeatQuestTop : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008B8A")]
    private const int PIN_INPUT_AUTO_REFRESH_PAUSE_ON = 10;
    [Token(Token = "0x4008B8B")]
    private const int PIN_INPUT_AUTO_REFRESH_PAUSE_OFF = 11;
    [Token(Token = "0x4008B8C")]
    private const int PIN_INPUT_INIT = 20;
    [Token(Token = "0x4008B8D")]
    private const int PIN_OUTPUT_INIT = 110;
    [Token(Token = "0x4008B8E")]
    private const int PIN_OUTPUT_AUTO_REFRESH = 120;
    [Token(Token = "0x4008B8F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string TREASURE_BOX_INAME;
    [Token(Token = "0x4008B90")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string BG_MODEL_GAMEOBJECT_ID;
    [Token(Token = "0x4008B91")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private float BG_ROTATE_SPEED;
    [Token(Token = "0x4008B92")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool mIsDispShadow;
    [Token(Token = "0x4008B93")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool mIsFlatUnitHeight;
    [Token(Token = "0x4008B94")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mBackgroundPrefab;
    [Token(Token = "0x4008B95")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mRunningCameraPos;
    [Token(Token = "0x4008B96")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mFinishedCameraPos;
    [Token(Token = "0x4008B97")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform mRunningUnitPos;
    [Token(Token = "0x4008B98")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Transform mFinishedUnitPos;
    [Token(Token = "0x4008B99")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnityEngine.Camera mCamera3D;
    [Token(Token = "0x4008B9A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private UnityEngine.Camera mBGCmaera;
    [Token(Token = "0x4008B9B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AutoRepeatQuestUnit mUnitControllerTemplate;
    [Token(Token = "0x4008B9C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Transform mBackGroundPos;
    [Token(Token = "0x4008B9D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mRotateRoot;
    [Token(Token = "0x4008B9E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private AutoRepeatQuestUnit.UnitAnimationParam[] mAnimSettings;
    [Token(Token = "0x4008B9F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private bool mIsPutTreasureBox;
    [Token(Token = "0x4008BA0")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Transform[] mTreasureBoxPos;
    [Token(Token = "0x4008BA1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private float AUTO_REFRESH_TIME;
    [Token(Token = "0x4008BA2")]
    [FieldOffset(Offset = "0x54")]
    private List<AutoRepeatQuestUnit> mUnitControllerList;
    [Token(Token = "0x4008BA3")]
    [FieldOffset(Offset = "0x58")]
    private List<UnitController> mTreasureBoxList;
    [Token(Token = "0x4008BA4")]
    [FieldOffset(Offset = "0x5C")]
    private bool mIsAutoRepeatQuestFinished;
    [Token(Token = "0x4008BA5")]
    [FieldOffset(Offset = "0x60")]
    private float mRestAutoRefreshTime;
    [Token(Token = "0x4008BA6")]
    [FieldOffset(Offset = "0x64")]
    private bool mIsNeedAutoRefresh;
    [Token(Token = "0x4008BA7")]
    [FieldOffset(Offset = "0x65")]
    private bool mIsPauseAutoRefresh;
    [Token(Token = "0x4008BA8")]
    [FieldOffset(Offset = "0x0")]
    private static AutoRepeatQuestTop mInstance;

    [Token(Token = "0x1700131B")]
    public static AutoRepeatQuestTop Instance
    {
      [Token(Token = "0x60086D1"), Address(RVA = "0x483620", Offset = "0x482420", VA = "0x10483620")] get
      {
        return (AutoRepeatQuestTop) null;
      }
    }

    [Token(Token = "0x1700131C")]
    private bool IsEnableAutoRefresh
    {
      [Token(Token = "0x60086D2"), Address(RVA = "0x483650", Offset = "0x482450", VA = "0x10483650")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60086D3")]
    [Address(RVA = "0x482130", Offset = "0x480F30", VA = "0x10482130", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60086D4")]
    [Address(RVA = "0x483110", Offset = "0x481F10", VA = "0x10483110")]
    private void SetAutoRefreshPause(bool is_pause)
    {
    }

    [Token(Token = "0x60086D5")]
    [Address(RVA = "0x482FD0", Offset = "0x481DD0", VA = "0x10482FD0")]
    public void PrepareAssets()
    {
    }

    [Token(Token = "0x60086D6")]
    [Address(RVA = "0x482190", Offset = "0x480F90", VA = "0x10482190")]
    private void Awake()
    {
    }

    [Token(Token = "0x60086D7")]
    [Address(RVA = "0x483380", Offset = "0x482180", VA = "0x10483380")]
    private void Update()
    {
    }

    [Token(Token = "0x60086D8")]
    [Address(RVA = "0x4832C0", Offset = "0x4820C0", VA = "0x104832C0")]
    private void Update_AutoRefresh()
    {
    }

    [Token(Token = "0x60086D9")]
    [Address(RVA = "0x483130", Offset = "0x481F30", VA = "0x10483130")]
    private void SetAutoRefreshTime()
    {
    }

    [Token(Token = "0x60086DA")]
    [Address(RVA = "0x482A00", Offset = "0x481800", VA = "0x10482A00")]
    private void Init()
    {
    }

    [Token(Token = "0x60086DB")]
    [Address(RVA = "0x482200", Offset = "0x481000", VA = "0x10482200")]
    private void CreateTeasureBox()
    {
    }

    [Token(Token = "0x60086DC")]
    [Address(RVA = "0x4823B0", Offset = "0x4811B0", VA = "0x104823B0")]
    private void CreateUnits(bool is_finished)
    {
    }

    [Token(Token = "0x60086DD")]
    [Address(RVA = "0x4827B0", Offset = "0x4815B0", VA = "0x104827B0")]
    private List<UnitData> GetUnits() => (List<UnitData>) null;

    [Token(Token = "0x60086DE")]
    [Address(RVA = "0x482660", Offset = "0x481460", VA = "0x10482660")]
    private void FlatUnitSize()
    {
    }

    [Token(Token = "0x60086DF")]
    [Address(RVA = "0x482DD0", Offset = "0x481BD0", VA = "0x10482DD0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60086E0")]
    [Address(RVA = "0x483510", Offset = "0x482310", VA = "0x10483510")]
    public AutoRepeatQuestTop()
    {
    }
  }
}
