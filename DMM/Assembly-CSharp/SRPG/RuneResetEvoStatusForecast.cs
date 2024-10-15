// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetEvoStatusForecast
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029CE")]
  public class RuneResetEvoStatusForecast : MonoBehaviour
  {
    [Token(Token = "0x400CAF7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mParent;
    [Token(Token = "0x400CAF8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneResetEvoStatusForecastChild mForecastChild;
    [Token(Token = "0x400CAF9")]
    private const string KEY_NAME = "RUNESETTING.RUNEFORECAST";
    [Token(Token = "0x400CAFA")]
    [FieldOffset(Offset = "0x14")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400CAFB")]
    [FieldOffset(Offset = "0x18")]
    private BaseStatus mAfterStatus;
    [Token(Token = "0x400CAFC")]
    [FieldOffset(Offset = "0x1C")]
    private BaseStatus mAfterScale;
    [Token(Token = "0x400CAFD")]
    [FieldOffset(Offset = "0x20")]
    private UnityAction<bool> mOnValueChanged;
    [Token(Token = "0x400CAFE")]
    [FieldOffset(Offset = "0x24")]
    private RuneStatusGaugeSelector mSelector;
    [Token(Token = "0x400CAFF")]
    [FieldOffset(Offset = "0x28")]
    private List<RuneResetEvoStatusForecastChild> mForecastList;

    [Token(Token = "0x600BE67")]
    [Address(RVA = "0x85E4F0", Offset = "0x85D2F0", VA = "0x1085E4F0")]
    public void Setup(
      RuneStatusGaugeSelector selector,
      BindRuneData bind_rune,
      UnityAction<bool> onValueChanged,
      BaseStatus after_status = null,
      BaseStatus after_scale = null)
    {
    }

    [Token(Token = "0x600BE68")]
    [Address(RVA = "0x85E4B0", Offset = "0x85D2B0", VA = "0x1085E4B0")]
    public void SetAfterParameter(BaseStatus after_status, BaseStatus after_scale)
    {
    }

    [Token(Token = "0x600BE69")]
    [Address(RVA = "0x85DC70", Offset = "0x85CA70", VA = "0x1085DC70")]
    public int GetToggleOnCount() => new int();

    [Token(Token = "0x600BE6A")]
    [Address(RVA = "0x85E1C0", Offset = "0x85CFC0", VA = "0x1085E1C0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BE6B")]
    [Address(RVA = "0x85E190", Offset = "0x85CF90", VA = "0x1085E190")]
    private void OnValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x600BE6C")]
    [Address(RVA = "0x85DB20", Offset = "0x85C920", VA = "0x1085DB20")]
    private void ForecastChildSetup(GameObject obj, RuneData rune, int index, bool is_lock)
    {
    }

    [Token(Token = "0x600BE6D")]
    [Address(RVA = "0x85DF30", Offset = "0x85CD30", VA = "0x1085DF30")]
    public bool IsToggleOnForecast(int index) => new bool();

    [Token(Token = "0x600BE6E")]
    [Address(RVA = "0x85DDA0", Offset = "0x85CBA0", VA = "0x1085DDA0")]
    public bool IsAfterParamLower(int index) => new bool();

    [Token(Token = "0x600BE6F")]
    [Address(RVA = "0x85E2F0", Offset = "0x85D0F0", VA = "0x1085E2F0")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600BE70")]
    [Address(RVA = "0x85DFF0", Offset = "0x85CDF0", VA = "0x1085DFF0")]
    private void LoadPrefs()
    {
    }

    [Token(Token = "0x600BE71")]
    [Address(RVA = "0x85E8C0", Offset = "0x85D6C0", VA = "0x1085E8C0")]
    public RuneResetEvoStatusForecast()
    {
    }

    [Token(Token = "0x20029CF")]
    private class Config
    {
      [Token(Token = "0x400CB00")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400CB01")]
      [FieldOffset(Offset = "0xC")]
      public bool[] isOn;

      [Token(Token = "0x600BE72")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Config()
      {
      }
    }
  }
}
