// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideResetStatusConfigWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B9")]
  public class RunePrideResetStatusConfigWindowModel
  {
    [Token(Token = "0x400F4E3")]
    [FieldOffset(Offset = "0x8")]
    protected string mEffectNameText;
    [Token(Token = "0x400F4E4")]
    [FieldOffset(Offset = "0xC")]
    protected int mMin;
    [Token(Token = "0x400F4E5")]
    [FieldOffset(Offset = "0x10")]
    protected int mMax;
    [Token(Token = "0x400F4E6")]
    [FieldOffset(Offset = "0x14")]
    protected int mTargetStatusNum;
    [Token(Token = "0x400F4E7")]
    [FieldOffset(Offset = "0x18")]
    protected Color mTargetStatusTextColor;
    [Token(Token = "0x400F4E8")]
    [FieldOffset(Offset = "0x28")]
    protected bool mIsValueMinus;

    [Token(Token = "0x1700209D")]
    public string EffectNameText
    {
      [Token(Token = "0x600E72B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700209E")]
    public int TargetStatusNum
    {
      [Token(Token = "0x600E72C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700209F")]
    public Color TargetStatusTextColor
    {
      [Token(Token = "0x600E72D"), Address(RVA = "0xAC70F0", Offset = "0xAC5EF0", VA = "0x10AC70F0")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x170020A0")]
    public int SliderMax
    {
      [Token(Token = "0x600E72E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020A1")]
    public int SliderMin
    {
      [Token(Token = "0x600E72F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020A2")]
    public int SliderValue
    {
      [Token(Token = "0x600E730"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E731"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] set
      {
      }
    }

    [Token(Token = "0x170020A3")]
    public bool IsValueMinus
    {
      [Token(Token = "0x600E732"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E733")]
    [Address(RVA = "0xAC75F0", Offset = "0xAC63F0", VA = "0x10AC75F0")]
    public void Init(RunePridePotentialStatusLotteryData data, RunePrideItemListParam param)
    {
    }

    [Token(Token = "0x600E734")]
    [Address(RVA = "0xAC7760", Offset = "0xAC6560", VA = "0x10AC7760")]
    public RunePrideResetStatusConfigWindowModel()
    {
    }
  }
}
