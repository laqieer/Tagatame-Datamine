// Decompiled with JetBrains decompiler
// Type: SRPG.UnitStatusAwakeWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CFD")]
  [FlowNode.Pin(12, "覚醒実行", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "MAX自動計算", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "選択クリア", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(11, "覚醒確認", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(13, "リセット確認", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(101, "覚醒実行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(14, "リセット実行", FlowNode.PinTypes.Input, 14)]
  [AddComponentMenu("UI/Unit/StatusAwakeWindow")]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(901, "エラー", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(102, "リセット実行", FlowNode.PinTypes.Output, 102)]
  public class UnitStatusAwakeWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400DFBD")]
    private const string SBV_KEY_USE_NUM = "SBV_KEY_USE_NUM";
    [Token(Token = "0x400DFBE")]
    public const string KEY_TARGET_UNIT_ID = "KEY_TARGET_UNIT_ID";
    [Token(Token = "0x400DFBF")]
    public const string KEY_SELECT_MATERIAL_DATAS = "KEY_SELECT_MATERIAL_DATAS";
    [Token(Token = "0x400DFC0")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400DFC1")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400DFC2")]
    private const int PIN_IN_SELECT_MAX = 3;
    [Token(Token = "0x400DFC3")]
    private const int PIN_IN_SELECT_CLEAR = 4;
    [Token(Token = "0x400DFC4")]
    private const int PIN_IN_AWAKE_CONFIRM = 11;
    [Token(Token = "0x400DFC5")]
    private const int PIN_IN_AWAKE_EXECUTE = 12;
    [Token(Token = "0x400DFC6")]
    private const int PIN_IN_RESET_CONFIRM = 13;
    [Token(Token = "0x400DFC7")]
    private const int PIN_IN_RESET_EXECUT = 14;
    [Token(Token = "0x400DFC8")]
    private const int PIN_OUT_EXECUTE = 101;
    [Token(Token = "0x400DFC9")]
    private const int PIN_OUT_REST = 102;
    [Token(Token = "0x400DFCA")]
    private const int PIN_OUT_ERROR = 901;
    [Token(Token = "0x400DFCB")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼覚醒画面")]
    [SerializeField]
    private SerializeValueBehaviour mSvb;
    [Token(Token = "0x400DFCC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400DFCD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button mExecuteBtn;
    [Token(Token = "0x400DFCE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button mMaxBtn;
    [Token(Token = "0x400DFCF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mClearBtn;
    [Token(Token = "0x400DFD0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int[] mBulkSelectList;
    [Token(Token = "0x400DFD1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mHpAndStatusAwake;
    [Token(Token = "0x400DFD2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mStatusAwakeNow;
    [Token(Token = "0x400DFD3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [HeaderBar("▼覚醒確認画面")]
    private Transform mParent;
    [Token(Token = "0x400DFD4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SerializeValueBehaviour mItemTemplete;
    [Token(Token = "0x400DFD5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mConfirmNowHp;
    [Token(Token = "0x400DFD6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mConfirmNewHp;
    [Token(Token = "0x400DFD7")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("▼リセット確認画面")]
    [SerializeField]
    private Transform mResetParent;
    [Token(Token = "0x400DFD8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SerializeValueBehaviour mResetItemTemplete;
    [Token(Token = "0x400DFD9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mLeagueMatchAlert;
    [Token(Token = "0x400DFDA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mResetNowHp;
    [Token(Token = "0x400DFDB")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mResetNewHp;
    [Token(Token = "0x400DFDC")]
    [FieldOffset(Offset = "0x50")]
    private UnitStatusAwakeModel mModel;
    [Token(Token = "0x400DFDD")]
    [FieldOffset(Offset = "0x54")]
    private UnitData mSelectUnit;
    [Token(Token = "0x400DFDE")]
    [FieldOffset(Offset = "0x58")]
    private int TotalSelectNum;
    [Token(Token = "0x400DFDF")]
    [FieldOffset(Offset = "0x5C")]
    private int StatusAwakeLimitNum;
    [Token(Token = "0x400DFE0")]
    [FieldOffset(Offset = "0x60")]
    private List<UnitStatusAwakeContent> mUnitStatusAwakeContentList;
    [Token(Token = "0x400DFE1")]
    [FieldOffset(Offset = "0x64")]
    private List<GameObject> mConfirmObjects;
    [Token(Token = "0x400DFE2")]
    [FieldOffset(Offset = "0x0")]
    private static UnitStatusAwakeWindow mInstance;

    [Token(Token = "0x17001B82")]
    public static UnitStatusAwakeWindow Instance
    {
      [Token(Token = "0x600D170"), Address(RVA = "0x9C8210", Offset = "0x9C7010", VA = "0x109C8210")] get
      {
        return (UnitStatusAwakeWindow) null;
      }
    }

    [Token(Token = "0x17001B83")]
    private bool IsStatusAwakeMax
    {
      [Token(Token = "0x600D171"), Address(RVA = "0x9C8240", Offset = "0x9C7040", VA = "0x109C8240")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D172")]
    [Address(RVA = "0x9C56E0", Offset = "0x9C44E0", VA = "0x109C56E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D173")]
    [Address(RVA = "0x9C6670", Offset = "0x9C5470", VA = "0x109C6670")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D174")]
    [Address(RVA = "0x9C4C80", Offset = "0x9C3A80", VA = "0x109C4C80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D175")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600D176")]
    [Address(RVA = "0x9C63E0", Offset = "0x9C51E0", VA = "0x109C63E0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600D177")]
    [Address(RVA = "0x9C6BC0", Offset = "0x9C59C0", VA = "0x109C6BC0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D178")]
    [Address(RVA = "0x9C66B0", Offset = "0x9C54B0", VA = "0x109C66B0")]
    private void OnMaxCalc()
    {
    }

    [Token(Token = "0x600D179")]
    [Address(RVA = "0x9C6960", Offset = "0x9C5760", VA = "0x109C6960")]
    private void OnSelectClear()
    {
    }

    [Token(Token = "0x600D17A")]
    [Address(RVA = "0x9C4EE0", Offset = "0x9C3CE0", VA = "0x109C4EE0")]
    public void AwakeConfirm()
    {
    }

    [Token(Token = "0x600D17B")]
    [Address(RVA = "0x9C55F0", Offset = "0x9C43F0", VA = "0x109C55F0")]
    public void AwakeExecute()
    {
    }

    [Token(Token = "0x600D17C")]
    [Address(RVA = "0x9C6C40", Offset = "0x9C5A40", VA = "0x109C6C40")]
    private void ResetConfirm()
    {
    }

    [Token(Token = "0x600D17D")]
    [Address(RVA = "0x9C7690", Offset = "0x9C6490", VA = "0x109C7690")]
    private void ResetExecute()
    {
    }

    [Token(Token = "0x600D17E")]
    [Address(RVA = "0x9C5A70", Offset = "0x9C4870", VA = "0x109C5A70")]
    private void InitContent()
    {
    }

    [Token(Token = "0x600D17F")]
    [Address(RVA = "0x9C65C0", Offset = "0x9C53C0", VA = "0x109C65C0")]
    private void OnAddNum(UnitStatusAwakeContent data, int add_num = 1)
    {
    }

    [Token(Token = "0x600D180")]
    [Address(RVA = "0x9C68A0", Offset = "0x9C56A0", VA = "0x109C68A0")]
    private void OnRemoveNum(UnitStatusAwakeContent data, int sub_num = 1)
    {
    }

    [Token(Token = "0x600D181")]
    [Address(RVA = "0x9C6AB0", Offset = "0x9C58B0", VA = "0x109C6AB0")]
    public void OnSelectUseNumChanged(UnitStatusAwakeContent data, float value)
    {
    }

    [Token(Token = "0x600D182")]
    [Address(RVA = "0x9C7B60", Offset = "0x9C6960", VA = "0x109C7B60")]
    private void UpdateViewAndBtn()
    {
    }

    [Token(Token = "0x600D183")]
    [Address(RVA = "0x9C7750", Offset = "0x9C6550", VA = "0x109C7750")]
    public void SetUnitStatusAwakeContentList(UnitStatusAwakeContent data)
    {
    }

    [Token(Token = "0x600D184")]
    [Address(RVA = "0x9C59B0", Offset = "0x9C47B0", VA = "0x109C59B0")]
    public UnitStatusAwakeContent GetUnitStatusAwakeContent(string item_iname)
    {
      return (UnitStatusAwakeContent) null;
    }

    [Token(Token = "0x600D185")]
    [Address(RVA = "0x9C5760", Offset = "0x9C4560", VA = "0x109C5760")]
    public ReqStatusAwake.RequestParam.MaterialData[] CreateReqestUseMaterialDatas()
    {
      return (ReqStatusAwake.RequestParam.MaterialData[]) null;
    }

    [Token(Token = "0x600D186")]
    [Address(RVA = "0x9C81A0", Offset = "0x9C6FA0", VA = "0x109C81A0")]
    public UnitStatusAwakeWindow()
    {
    }
  }
}
