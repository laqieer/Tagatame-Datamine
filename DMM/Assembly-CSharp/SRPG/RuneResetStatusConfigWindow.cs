// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetStatusConfigWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029D7")]
  public class RuneResetStatusConfigWindow : MonoBehaviour
  {
    [Token(Token = "0x400CB23")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneStatusGaugeSelector mStatusGauseSelector;
    [Token(Token = "0x400CB24")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneResetEvoStatusForecast mRuneResetEvoStatusForecast;
    [Token(Token = "0x400CB25")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneResetEvoStatusPriority mRuneResetEvoStatusPriority;
    [Token(Token = "0x400CB26")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneResetEvoStatusCount mRuneResetEvoStatusCount;
    [Token(Token = "0x400CB27")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button mOkButton;
    [Token(Token = "0x400CB28")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button mCloseButton;
    [Token(Token = "0x400CB29")]
    [FieldOffset(Offset = "0x24")]
    private BindRuneData mBindRuneData;

    [Token(Token = "0x600BE9A")]
    [Address(RVA = "0x860A50", Offset = "0x85F850", VA = "0x10860A50")]
    public void Setup(BindRuneData rune, UnityAction onClickOK)
    {
    }

    [Token(Token = "0x600BE9B")]
    [Address(RVA = "0x8606B0", Offset = "0x85F4B0", VA = "0x108606B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BE9C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BE9D")]
    [Address(RVA = "0x8607F0", Offset = "0x85F5F0", VA = "0x108607F0")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600BE9E")]
    [Address(RVA = "0x85FF20", Offset = "0x85ED20", VA = "0x1085FF20")]
    private int CalcUseCount() => new int();

    [Token(Token = "0x600BE9F")]
    [Address(RVA = "0x8604F0", Offset = "0x85F2F0", VA = "0x108604F0")]
    private void OnValueChanged_Selector()
    {
    }

    [Token(Token = "0x600BEA0")]
    [Address(RVA = "0x860490", Offset = "0x85F290", VA = "0x10860490")]
    private void OnValueChanged_Forecast(bool isOn)
    {
    }

    [Token(Token = "0x600BEA1")]
    [Address(RVA = "0x8604D0", Offset = "0x85F2D0", VA = "0x108604D0")]
    private void OnValueChanged_Priority(bool isOn)
    {
    }

    [Token(Token = "0x600BEA2")]
    [Address(RVA = "0x860490", Offset = "0x85F290", VA = "0x10860490")]
    private void OnValueChanged_Count()
    {
    }

    [Token(Token = "0x600BEA3")]
    [Address(RVA = "0x860590", Offset = "0x85F390", VA = "0x10860590")]
    private void RefreshOkButton()
    {
    }

    [Token(Token = "0x600BEA4")]
    [Address(RVA = "0x860380", Offset = "0x85F180", VA = "0x10860380")]
    public bool IsToggleOnForecast(int index) => new bool();

    [Token(Token = "0x600BEA5")]
    [Address(RVA = "0x860200", Offset = "0x85F000", VA = "0x10860200")]
    public bool IsAfterParamLower(int index) => new bool();

    [Token(Token = "0x600BEA6")]
    [Address(RVA = "0x860180", Offset = "0x85EF80", VA = "0x10860180")]
    public int GetEnoughCostIndex() => new int();

    [Token(Token = "0x600BEA7")]
    [Address(RVA = "0x860100", Offset = "0x85EF00", VA = "0x10860100")]
    public int GetContinueCount() => new int();

    [Token(Token = "0x600BEA8")]
    [Address(RVA = "0x860280", Offset = "0x85F080", VA = "0x10860280")]
    public bool IsContainCostCoin() => new bool();

    [Token(Token = "0x600BEA9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneResetStatusConfigWindow()
    {
    }
  }
}
