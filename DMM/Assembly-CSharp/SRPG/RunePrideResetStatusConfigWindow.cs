// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetStatusConfigWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A4D")]
  [FlowNode.Pin(5, "閉じるボタン押下", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(501, "初期化完了", FlowNode.PinTypes.Output, 501)]
  [FlowNode.Pin(1001, "ウィンドウを閉じる", FlowNode.PinTypes.Output, 1001)]
  public class RunePrideResetStatusConfigWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CDD0")]
    private const int PIN_INPUT_ON_CLOSE = 5;
    [Token(Token = "0x400CDD1")]
    private const int PIN_OUTPUT_INTIALIZED = 501;
    [Token(Token = "0x400CDD2")]
    private const int PIN_OUTPUT_CLOSE_EXEC = 1001;
    [Token(Token = "0x400CDD3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CDD4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RunePrideResetPotentialStatusCount mRelotteryRepeatCount;
    [Token(Token = "0x400CDD5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RunePrideResetPotentialStatusPriority mRelotteryPriority;
    [Token(Token = "0x400CDD6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button mOkButton;
    [Token(Token = "0x400CDD7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mEffectValueText;
    [Token(Token = "0x400CDD8")]
    [FieldOffset(Offset = "0x20")]
    private RunePrideResetStatusConfigWindowModel mModel;
    [Token(Token = "0x400CDD9")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mUnitData;
    [Token(Token = "0x400CDDA")]
    [FieldOffset(Offset = "0x28")]
    private string mBonusId;
    [Token(Token = "0x400CDDB")]
    [FieldOffset(Offset = "0x2C")]
    private int mSlotNum;
    [Token(Token = "0x400CDDC")]
    [FieldOffset(Offset = "0x30")]
    private RunePridePotentialParam mPotentialParam;
    [Token(Token = "0x400CDDD")]
    [FieldOffset(Offset = "0x34")]
    private RunePrideItemListParam mItemListParam;
    [Token(Token = "0x400CDDE")]
    [FieldOffset(Offset = "0x38")]
    private int mPotentioalIndex;
    [Token(Token = "0x400CDDF")]
    [FieldOffset(Offset = "0x3C")]
    private List<RunePridePotentialStatusLotteryData> mPotentialLotteryDataList;

    [Token(Token = "0x600C0F2")]
    [Address(RVA = "0x895E00", Offset = "0x894C00", VA = "0x10895E00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C0F3")]
    [Address(RVA = "0x895E30", Offset = "0x894C30", VA = "0x10895E30", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C0F4")]
    [Address(RVA = "0x895E60", Offset = "0x894C60", VA = "0x10895E60")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C0F5")]
    [Address(RVA = "0x896320", Offset = "0x895120", VA = "0x10896320")]
    public void Init(SerializeValueList valueList, UnityAction onClickOK)
    {
    }

    [Token(Token = "0x600C0F6")]
    [Address(RVA = "0x895F30", Offset = "0x894D30", VA = "0x10895F30")]
    private void Draw(RunePridePotentialStatusLotteryData data)
    {
    }

    [Token(Token = "0x600C0F7")]
    [Address(RVA = "0x896EB0", Offset = "0x895CB0", VA = "0x10896EB0")]
    private void OnValueChanged_Count()
    {
    }

    [Token(Token = "0x600C0F8")]
    [Address(RVA = "0x896F30", Offset = "0x895D30", VA = "0x10896F30")]
    private void OnValueChanged_Priority(bool isOn)
    {
    }

    [Token(Token = "0x600C0F9")]
    [Address(RVA = "0x895EB0", Offset = "0x894CB0", VA = "0x10895EB0")]
    private int CalcUseCount() => new int();

    [Token(Token = "0x600C0FA")]
    [Address(RVA = "0x896F50", Offset = "0x895D50", VA = "0x10896F50")]
    private void RefreshOkButton()
    {
    }

    [Token(Token = "0x600C0FB")]
    [Address(RVA = "0x896FD0", Offset = "0x895DD0", VA = "0x10896FD0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C0FC")]
    [Address(RVA = "0x896090", Offset = "0x894E90", VA = "0x10896090")]
    public List<JSON_RunePrideSubMats> GetEnoughCosts() => (List<JSON_RunePrideSubMats>) null;

    [Token(Token = "0x600C0FD")]
    [Address(RVA = "0x896900", Offset = "0x895700", VA = "0x10896900")]
    public bool IsReachDestPotentialStatus() => new bool();

    [Token(Token = "0x600C0FE")]
    [Address(RVA = "0x896120", Offset = "0x894F20", VA = "0x10896120")]
    private string GetParameterDrawName(RunePridePotentialSlotData data) => (string) null;

    [Token(Token = "0x600C0FF")]
    [Address(RVA = "0x8962A0", Offset = "0x8950A0", VA = "0x108962A0")]
    private string GetParameterDrawName(RunePridePotentialStatusLotteryData data) => (string) null;

    [Token(Token = "0x600C100")]
    [Address(RVA = "0x8961A0", Offset = "0x894FA0", VA = "0x108961A0")]
    private string GetParameterDrawName(BaseParameterData data) => (string) null;

    [Token(Token = "0x600C101")]
    [Address(RVA = "0x896D40", Offset = "0x895B40", VA = "0x10896D40")]
    public void OnValueChangedSlider(Slider slider)
    {
    }

    [Token(Token = "0x600C102")]
    [Address(RVA = "0x896CD0", Offset = "0x895AD0", VA = "0x10896CD0")]
    public void OnEffectCycleForward()
    {
    }

    [Token(Token = "0x600C103")]
    [Address(RVA = "0x896C70", Offset = "0x895A70", VA = "0x10896C70")]
    public void OnEffectCycleBackward()
    {
    }

    [Token(Token = "0x600C104")]
    [Address(RVA = "0x897130", Offset = "0x895F30", VA = "0x10897130")]
    private void SavePrefs()
    {
    }

    [Token(Token = "0x600C105")]
    [Address(RVA = "0x896010", Offset = "0x894E10", VA = "0x10896010")]
    public int GetContinueCount() => new int();

    [Token(Token = "0x600C106")]
    [Address(RVA = "0x897300", Offset = "0x896100", VA = "0x10897300")]
    public void SetLocalPosScale()
    {
    }

    [Token(Token = "0x600C107")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideResetStatusConfigWindow()
    {
    }
  }
}
