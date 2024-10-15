// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E9F")]
  public abstract class ConditionsResult
  {
    [Token(Token = "0x4002CE7")]
    [FieldOffset(Offset = "0x8")]
    protected bool mIsClear;
    [Token(Token = "0x4002CE8")]
    [FieldOffset(Offset = "0xC")]
    protected int mTargetValue;
    [Token(Token = "0x4002CE9")]
    [FieldOffset(Offset = "0x10")]
    protected int mCurrentValue;

    [Token(Token = "0x170004BB")]
    public bool isClear
    {
      [Token(Token = "0x6003CD8"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004BC")]
    public int targetValue
    {
      [Token(Token = "0x6003CD9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004BD")]
    public int currentValue
    {
      [Token(Token = "0x6003CDA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004BE")]
    public abstract string text { [Token(Token = "0x6003CDB")] get; }

    [Token(Token = "0x170004BF")]
    public abstract string errorText { [Token(Token = "0x6003CDC")] get; }

    [Token(Token = "0x170004C0")]
    public bool isConditionsUnitLv
    {
      [Token(Token = "0x6003CDD"), Address(RVA = "0x10F4E40", Offset = "0x10F3C40", VA = "0x110F4E40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004C1")]
    public bool isConditionsAwake
    {
      [Token(Token = "0x6003CDE"), Address(RVA = "0x10F4C10", Offset = "0x10F3A10", VA = "0x110F4C10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004C2")]
    public bool isConditionsJobLv
    {
      [Token(Token = "0x6003CDF"), Address(RVA = "0x10F4C80", Offset = "0x10F3A80", VA = "0x110F4C80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004C3")]
    public bool isConditionsTobiraLv
    {
      [Token(Token = "0x6003CE0"), Address(RVA = "0x10F4D60", Offset = "0x10F3B60", VA = "0x110F4D60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004C4")]
    public bool isConditionsQuestClear
    {
      [Token(Token = "0x6003CE1"), Address(RVA = "0x10F4CF0", Offset = "0x10F3AF0", VA = "0x110F4CF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004C5")]
    public bool isConditionsTobiraNoConditions
    {
      [Token(Token = "0x6003CE2"), Address(RVA = "0x10F4DD0", Offset = "0x10F3BD0", VA = "0x110F4DD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003CE3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    protected ConditionsResult()
    {
    }
  }
}
