// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEvoStatusSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A4")]
  public class RuneEvoStatusSelector : MonoBehaviour
  {
    [Token(Token = "0x400C996")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTextStatus;
    [Token(Token = "0x400C997")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mTextStatusDescription;
    [Token(Token = "0x400C998")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button mButtonLeft;
    [Token(Token = "0x400C999")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mButtonRight;
    [Token(Token = "0x400C99A")]
    [FieldOffset(Offset = "0x1C")]
    private UnityAction<RuneLotteryEvoState> m_OnChangedValue;
    [Token(Token = "0x400C99B")]
    [FieldOffset(Offset = "0x20")]
    private List<RuneLotteryEvoState> mLotteryEvoState;
    [Token(Token = "0x400C99C")]
    [FieldOffset(Offset = "0x24")]
    private int mSelectedEvoStateIndex;

    [Token(Token = "0x1700198D")]
    public int SelectedEvoStateIndex
    {
      [Token(Token = "0x600BCEF"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700198E")]
    public RuneLotteryEvoState SelectedEvoState
    {
      [Token(Token = "0x600BCF0"), Address(RVA = "0x8499E0", Offset = "0x8487E0", VA = "0x108499E0")] get
      {
        return (RuneLotteryEvoState) null;
      }
    }

    [Token(Token = "0x600BCF1")]
    [Address(RVA = "0x8498B0", Offset = "0x8486B0", VA = "0x108498B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BCF2")]
    [Address(RVA = "0x849810", Offset = "0x848610", VA = "0x10849810")]
    public void Setup(
      RuneData rune,
      UnityAction<RuneLotteryEvoState> onChangedValueCallback)
    {
    }

    [Token(Token = "0x600BCF3")]
    [Address(RVA = "0x8497F0", Offset = "0x8485F0", VA = "0x108497F0")]
    public void SetSelectedEvoStateIndex(int index)
    {
    }

    [Token(Token = "0x600BCF4")]
    [Address(RVA = "0x849620", Offset = "0x848420", VA = "0x10849620")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BCF5")]
    [Address(RVA = "0x8495A0", Offset = "0x8483A0", VA = "0x108495A0")]
    private void OnChangedValue()
    {
    }

    [Token(Token = "0x600BCF6")]
    [Address(RVA = "0x849500", Offset = "0x848300", VA = "0x10849500")]
    private void OnButtonLeft()
    {
    }

    [Token(Token = "0x600BCF7")]
    [Address(RVA = "0x849550", Offset = "0x848350", VA = "0x10849550")]
    private void OnButtonRight()
    {
    }

    [Token(Token = "0x600BCF8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneEvoStatusSelector()
    {
    }
  }
}
