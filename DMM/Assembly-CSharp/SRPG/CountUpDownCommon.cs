// Decompiled with JetBrains decompiler
// Type: SRPG.CountUpDownCommon
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
  [Token(Token = "0x20021B8")]
  public class CountUpDownCommon : MonoBehaviour
  {
    [Token(Token = "0x40093B6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button mButtonMinus;
    [Token(Token = "0x40093B7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mButtonPlus;
    [Token(Token = "0x40093B8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button mButtonMinValue;
    [Token(Token = "0x40093B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mButtonMaxValue;
    [Token(Token = "0x40093BA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text TextCurrntValue;
    [Token(Token = "0x40093BB")]
    [FieldOffset(Offset = "0x20")]
    private UnityAction<int> m_OnChangedValue;
    [Token(Token = "0x40093BC")]
    [FieldOffset(Offset = "0x24")]
    private bool m_ButtonsEnable;
    [Token(Token = "0x40093BD")]
    [FieldOffset(Offset = "0x28")]
    private int m_CurrValue;
    [Token(Token = "0x40093BE")]
    [FieldOffset(Offset = "0x2C")]
    private int m_StepValue;
    [Token(Token = "0x40093BF")]
    [FieldOffset(Offset = "0x30")]
    private int m_DefaultValue;
    [Token(Token = "0x40093C0")]
    [FieldOffset(Offset = "0x34")]
    private int m_MinValue;
    [Token(Token = "0x40093C1")]
    [FieldOffset(Offset = "0x38")]
    private int m_MaxValue;

    [Token(Token = "0x17001407")]
    public int CurrentValue
    {
      [Token(Token = "0x6008DFE"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001408")]
    public int StepValue
    {
      [Token(Token = "0x6008DFF"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001409")]
    public int DefaultValue
    {
      [Token(Token = "0x6008E00"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700140A")]
    public int MinValue
    {
      [Token(Token = "0x6008E01"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700140B")]
    public int MaxValue
    {
      [Token(Token = "0x6008E02"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008E03")]
    [Address(RVA = "0x51C3C0", Offset = "0x51B1C0", VA = "0x1051C3C0")]
    public void Setup(
      int defaultValue,
      int minValue,
      int maxValue,
      int stepValue,
      UnityAction<int> changeValueCallback = null)
    {
    }

    [Token(Token = "0x6008E04")]
    [Address(RVA = "0x51C350", Offset = "0x51B150", VA = "0x1051C350")]
    public void SetEnable(bool b_enable)
    {
    }

    [Token(Token = "0x6008E05")]
    [Address(RVA = "0x51C370", Offset = "0x51B170", VA = "0x1051C370")]
    public void SetValue(int value)
    {
    }

    [Token(Token = "0x6008E06")]
    [Address(RVA = "0x51C310", Offset = "0x51B110", VA = "0x1051C310")]
    public void ResetDefaultValue()
    {
    }

    [Token(Token = "0x6008E07")]
    [Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")]
    public int GetCurrentValue() => new int();

    [Token(Token = "0x6008E08")]
    [Address(RVA = "0x51C440", Offset = "0x51B240", VA = "0x1051C440")]
    private void Start()
    {
    }

    [Token(Token = "0x6008E09")]
    [Address(RVA = "0x51C200", Offset = "0x51B000", VA = "0x1051C200")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008E0A")]
    [Address(RVA = "0x51C1B0", Offset = "0x51AFB0", VA = "0x1051C1B0")]
    private void OnButtonPuls()
    {
    }

    [Token(Token = "0x6008E0B")]
    [Address(RVA = "0x51C160", Offset = "0x51AF60", VA = "0x1051C160")]
    private void OnButtonMinus()
    {
    }

    [Token(Token = "0x6008E0C")]
    [Address(RVA = "0x51C120", Offset = "0x51AF20", VA = "0x1051C120")]
    private void OnButtonMinValue()
    {
    }

    [Token(Token = "0x6008E0D")]
    [Address(RVA = "0x51C0E0", Offset = "0x51AEE0", VA = "0x1051C0E0")]
    private void OnButtonMaxValue()
    {
    }

    [Token(Token = "0x6008E0E")]
    [Address(RVA = "0x51C740", Offset = "0x51B540", VA = "0x1051C740")]
    public CountUpDownCommon()
    {
    }
  }
}
