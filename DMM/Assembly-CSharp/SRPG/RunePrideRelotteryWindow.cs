// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideRelotteryWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A43")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(200, "実行", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(500, "連続変更ウィンドウ作成", FlowNode.PinTypes.Input, 500)]
  [FlowNode.Pin(1500, "連続変更開始", FlowNode.PinTypes.Output, 1500)]
  [FlowNode.Pin(1001, "代用品確認", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(501, "連続変更停止ボタン押下", FlowNode.PinTypes.Input, 501)]
  [FlowNode.Pin(1501, "連続変更停止開始", FlowNode.PinTypes.Output, 1501)]
  [FlowNode.Pin(1000, "抽選実行", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(502, "連続変更継続判断", FlowNode.PinTypes.Input, 502)]
  public class RunePrideRelotteryWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CD83")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CD84")]
    private const int PIN_INPUT_EXECUTE = 200;
    [Token(Token = "0x400CD85")]
    private const int PIN_INPUT_CONFIG_DATA_SET = 500;
    [Token(Token = "0x400CD86")]
    private const int PIN_INPUT_RELOT_STOP_RESERVE = 501;
    [Token(Token = "0x400CD87")]
    private const int PIN_INPUT_RELOT_CYCLE = 502;
    [Token(Token = "0x400CD88")]
    private const int PIN_OUTPUT_RELOTTERY_EXEC = 1000;
    [Token(Token = "0x400CD89")]
    private const int PIN_OUTPUT_REPLACE_CHECK = 1001;
    [Token(Token = "0x400CD8A")]
    private const int PIN_OUTPUT_CONTINUOUS_RELOT_EXEC = 1500;
    [Token(Token = "0x400CD8B")]
    private const int PIN_OUTPUT_CONTINUOUS_RELOT_STOP = 1501;
    [Token(Token = "0x400CD8C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RunePrideNeedItemListView ViewObj;
    [Token(Token = "0x400CD8D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CD8E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour SerializeValue;
    [Token(Token = "0x400CD8F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mText;
    [Token(Token = "0x400CD90")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mOnConfig;
    [Token(Token = "0x400CD91")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x400CD92")]
    [FieldOffset(Offset = "0x24")]
    private RunePrideBaseNeedItemWindowModel mModel;
    [Token(Token = "0x400CD93")]
    [FieldOffset(Offset = "0x28")]
    private UnitData mUnitData;
    [Token(Token = "0x400CD94")]
    [FieldOffset(Offset = "0x2C")]
    private string mBonusId;
    [Token(Token = "0x400CD95")]
    [FieldOffset(Offset = "0x30")]
    private int mSlotNum;
    [Token(Token = "0x400CD96")]
    [FieldOffset(Offset = "0x34")]
    private string mPotentialIname;
    [Token(Token = "0x400CD97")]
    [FieldOffset(Offset = "0x38")]
    private RunePridePotentialParam mPotentialParam;
    [Token(Token = "0x400CD98")]
    [FieldOffset(Offset = "0x3C")]
    private RunePridePotentialBonusWindow.SlotStatus mSlotStatus;
    [Token(Token = "0x400CD99")]
    [FieldOffset(Offset = "0x40")]
    private RunePrideItemListParam mItemListParam;
    [Token(Token = "0x400CD9A")]
    [FieldOffset(Offset = "0x44")]
    private List<JSON_RunePrideSubMats> mMaterials;
    [Token(Token = "0x400CD9B")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsSelectorPassed;
    [Token(Token = "0x400CD9C")]
    [FieldOffset(Offset = "0x4C")]
    private int mContinueCount;
    [Token(Token = "0x400CD9D")]
    [FieldOffset(Offset = "0x50")]
    private string mTargetIname;
    [Token(Token = "0x400CD9E")]
    [FieldOffset(Offset = "0x54")]
    private List<string> mSubInames;
    [Token(Token = "0x400CD9F")]
    [FieldOffset(Offset = "0x58")]
    private int mReplaceNum;
    [Token(Token = "0x400CDA0")]
    public const string PREFAB_PATH_RUNE_PRIDE_RESET_STATUS_CONFIG_WINDOW = "UI/RunePride/RunePrideResetStatusConfigWindow";
    [Token(Token = "0x400CDA1")]
    private const float RESET_STATUS_WAIT_TIME = 1.5f;
    [Token(Token = "0x400CDA2")]
    [FieldOffset(Offset = "0x5C")]
    private RunePrideResetStatusConfigWindow mRunePrideResetStatusConfigWindow;
    [Token(Token = "0x400CDA3")]
    [FieldOffset(Offset = "0x60")]
    private bool mIsStopReserved;
    [Token(Token = "0x400CDA4")]
    [FieldOffset(Offset = "0x64")]
    private RunePrideRelotteryWindow.ResetContinue mResetContinue;

    [Token(Token = "0x600C0B6")]
    [Address(RVA = "0x892730", Offset = "0x891530", VA = "0x10892730", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C0B7")]
    [Address(RVA = "0x8927F0", Offset = "0x8915F0", VA = "0x108927F0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C0B8")]
    [Address(RVA = "0x893580", Offset = "0x892380", VA = "0x10893580")]
    public void Initialize(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C0B9")]
    [Address(RVA = "0x892950", Offset = "0x891750", VA = "0x10892950")]
    private void CreateNeedItem(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C0BA")]
    [Address(RVA = "0x893490", Offset = "0x892290", VA = "0x10893490")]
    private void Draw()
    {
    }

    [Token(Token = "0x600C0BB")]
    [Address(RVA = "0x8935A0", Offset = "0x8923A0", VA = "0x108935A0")]
    public void OnExec()
    {
    }

    [Token(Token = "0x600C0BC")]
    [Address(RVA = "0x893910", Offset = "0x892710", VA = "0x10893910")]
    private void ShowConfigWindow()
    {
    }

    [Token(Token = "0x600C0BD")]
    [Address(RVA = "0x8928D0", Offset = "0x8916D0", VA = "0x108928D0")]
    private void ActiveSelfWindow()
    {
    }

    [Token(Token = "0x600C0BE")]
    [Address(RVA = "0x893510", Offset = "0x892310", VA = "0x10893510")]
    private void EnableConfigWindow()
    {
    }

    [Token(Token = "0x600C0BF")]
    [Address(RVA = "0x893420", Offset = "0x892220", VA = "0x10893420")]
    private void DisableConfigWindow()
    {
    }

    [Token(Token = "0x600C0C0")]
    [Address(RVA = "0x893740", Offset = "0x892540", VA = "0x10893740")]
    private void OnStartResetStatusContinue()
    {
    }

    [Token(Token = "0x600C0C1")]
    [Address(RVA = "0x8938A0", Offset = "0x8926A0", VA = "0x108938A0")]
    private IEnumerator ResetStatusContinue() => (IEnumerator) null;

    [Token(Token = "0x600C0C2")]
    [Address(RVA = "0x893C00", Offset = "0x892A00", VA = "0x10893C00")]
    public RunePrideRelotteryWindow()
    {
    }

    [Token(Token = "0x2002A44")]
    private enum ResetContinue
    {
      [Token(Token = "0x400CDA6")] None,
      [Token(Token = "0x400CDA7")] Executing,
    }
  }
}
