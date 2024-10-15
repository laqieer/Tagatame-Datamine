// Decompiled with JetBrains decompiler
// Type: SRPG.SliderCommon
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
  [Token(Token = "0x20021BD")]
  public class SliderCommon : MonoBehaviour
  {
    [Token(Token = "0x40093DC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider mSliderObj;
    [Token(Token = "0x40093DD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mButtonMinus;
    [Token(Token = "0x40093DE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button mButtonPlus;
    [Token(Token = "0x40093DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mButtonMinValue;
    [Token(Token = "0x40093E0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button mButtonMaxValue;
    [Token(Token = "0x40093E1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mTextCurrntValue;
    [Token(Token = "0x40093E2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool mIsSigned;
    [Token(Token = "0x40093E3")]
    [FieldOffset(Offset = "0x28")]
    private UnityAction<int> m_OnChangedValue;
    [Token(Token = "0x40093E4")]
    [FieldOffset(Offset = "0x2C")]
    private int m_StepValue;
    [Token(Token = "0x40093E5")]
    [FieldOffset(Offset = "0x30")]
    private int m_DefaultValue;
    [Token(Token = "0x40093E6")]
    [FieldOffset(Offset = "0x34")]
    private int m_MinValue;
    [Token(Token = "0x40093E7")]
    [FieldOffset(Offset = "0x38")]
    private int m_MaxValue;

    [Token(Token = "0x1700140C")]
    public int CurrentValue
    {
      [Token(Token = "0x6008E1B"), Address(RVA = "0x51E510", Offset = "0x51D310", VA = "0x1051E510")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700140D")]
    public int StepValue
    {
      [Token(Token = "0x6008E1C"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700140E")]
    public int DefaultValue
    {
      [Token(Token = "0x6008E1D"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700140F")]
    public int MinValue
    {
      [Token(Token = "0x6008E1E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001410")]
    public int MaxValue
    {
      [Token(Token = "0x6008E1F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008E20")]
    [Address(RVA = "0x51E1A0", Offset = "0x51CFA0", VA = "0x1051E1A0")]
    public void Setup(
      int defaultValue,
      int minValue,
      int maxValue,
      int stepValue,
      UnityAction<int> changeValueCallback = null)
    {
    }

    [Token(Token = "0x6008E21")]
    [Address(RVA = "0x51DE30", Offset = "0x51CC30", VA = "0x1051DE30")]
    public void SetEnable(bool enable)
    {
    }

    [Token(Token = "0x6008E22")]
    [Address(RVA = "0x51E180", Offset = "0x51CF80", VA = "0x1051E180")]
    public void SetValue(int value)
    {
    }

    [Token(Token = "0x6008E23")]
    [Address(RVA = "0x51DE10", Offset = "0x51CC10", VA = "0x1051DE10")]
    public void ResetDefaultValue()
    {
    }

    [Token(Token = "0x6008E24")]
    [Address(RVA = "0x51D7E0", Offset = "0x51C5E0", VA = "0x1051D7E0")]
    public int GetCurrentValue() => new int();

    [Token(Token = "0x6008E25")]
    [Address(RVA = "0x51E2A0", Offset = "0x51D0A0", VA = "0x1051E2A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008E26")]
    [Address(RVA = "0x51E040", Offset = "0x51CE40", VA = "0x1051E040")]
    private void SetSliderValueSilent(int value)
    {
    }

    [Token(Token = "0x6008E27")]
    [Address(RVA = "0x51DB20", Offset = "0x51C920", VA = "0x1051DB20")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008E28")]
    [Address(RVA = "0x51DAD0", Offset = "0x51C8D0", VA = "0x1051DAD0")]
    private void OnSliderChanged(float value)
    {
    }

    [Token(Token = "0x6008E29")]
    [Address(RVA = "0x51DA30", Offset = "0x51C830", VA = "0x1051DA30")]
    private void OnButtonPuls()
    {
    }

    [Token(Token = "0x6008E2A")]
    [Address(RVA = "0x51D990", Offset = "0x51C790", VA = "0x1051D990")]
    private void OnButtonMinus()
    {
    }

    [Token(Token = "0x6008E2B")]
    [Address(RVA = "0x51D900", Offset = "0x51C700", VA = "0x1051D900")]
    private void OnButtonMinValue()
    {
    }

    [Token(Token = "0x6008E2C")]
    [Address(RVA = "0x51D870", Offset = "0x51C670", VA = "0x1051D870")]
    private void OnButtonMaxValue()
    {
    }

    [Token(Token = "0x6008E2D")]
    [Address(RVA = "0x51E4E0", Offset = "0x51D2E0", VA = "0x1051E4E0")]
    public SliderCommon()
    {
    }
  }
}
