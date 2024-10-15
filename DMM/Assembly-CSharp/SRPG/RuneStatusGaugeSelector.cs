// Decompiled with JetBrains decompiler
// Type: SRPG.RuneStatusGaugeSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F2")]
  public class RuneStatusGaugeSelector : MonoBehaviour
  {
    [Token(Token = "0x400CBCC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneEvoStatusSelector mRuneEvoStatusSelector;
    [Token(Token = "0x400CBCD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SliderCommon mSliderCommon;
    [Token(Token = "0x400CBCE")]
    private const string KEY_NAME = "RUNESETTING.GAUGESELECTOR";
    [Token(Token = "0x400CBCF")]
    [FieldOffset(Offset = "0x14")]
    private BindRuneData mBindRuneData;
    [Token(Token = "0x400CBD0")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction mOnValueChanged;

    [Token(Token = "0x170019BE")]
    public ParamTypes SelectParamTypes
    {
      [Token(Token = "0x600BF34"), Address(RVA = "0x867CF0", Offset = "0x866AF0", VA = "0x10867CF0")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x170019BF")]
    public SkillParamCalcTypes SelectCalc
    {
      [Token(Token = "0x600BF35"), Address(RVA = "0x867CC0", Offset = "0x866AC0", VA = "0x10867CC0")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x600BF36")]
    [Address(RVA = "0x8676F0", Offset = "0x8664F0", VA = "0x108676F0")]
    public void GetBaseStatus(ref BaseStatus add_state, ref BaseStatus scale_state)
    {
    }

    [Token(Token = "0x600BF37")]
    [Address(RVA = "0x867B00", Offset = "0x866900", VA = "0x10867B00")]
    public void Setup(BindRuneData bind, UnityAction selector)
    {
    }

    [Token(Token = "0x600BF38")]
    [Address(RVA = "0x867D80", Offset = "0x866B80", VA = "0x10867D80")]
    private void onChangedStatusCallback(RuneLotteryEvoState lottery_evo_state)
    {
    }

    [Token(Token = "0x600BF39")]
    [Address(RVA = "0x867D20", Offset = "0x866B20", VA = "0x10867D20")]
    private void onChangedParameterCallback(int value)
    {
    }

    [Token(Token = "0x600BF3A")]
    [Address(RVA = "0x867A10", Offset = "0x866810", VA = "0x10867A10")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600BF3B")]
    [Address(RVA = "0x867840", Offset = "0x866640", VA = "0x10867840")]
    private bool LoadPrefs() => new bool();

    [Token(Token = "0x600BF3C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneStatusGaugeSelector()
    {
    }

    [Token(Token = "0x20029F3")]
    private class Config
    {
      [Token(Token = "0x400CBD1")]
      [FieldOffset(Offset = "0x8")]
      public int slot;
      [Token(Token = "0x400CBD2")]
      [FieldOffset(Offset = "0xC")]
      public int select_index;
      [Token(Token = "0x400CBD3")]
      [FieldOffset(Offset = "0x10")]
      public int value;

      [Token(Token = "0x600BF3D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Config()
      {
      }
    }
  }
}
