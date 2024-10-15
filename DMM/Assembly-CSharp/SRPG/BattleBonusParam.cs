// Decompiled with JetBrains decompiler
// Type: SRPG.BattleBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DD5")]
  [MessagePackObject(true)]
  public class BattleBonusParam
  {
    [Token(Token = "0x400778D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_BATTLE_BONUS;
    [Token(Token = "0x400778E")]
    [FieldOffset(Offset = "0x8")]
    public short[] values;
    [Token(Token = "0x400778F")]
    [FieldOffset(Offset = "0x4")]
    public static readonly ParamTypes[] ConvertParamTypes;

    [Token(Token = "0x6007A06")]
    [Address(RVA = "0x3B8C60", Offset = "0x3B7A60", VA = "0x103B8C60")]
    public string ToSuspendString() => (string) null;

    [Token(Token = "0x6007A07")]
    [Address(RVA = "0x3B85B0", Offset = "0x3B73B0", VA = "0x103B85B0")]
    public bool FromSuspendString(string str) => new bool();

    [Token(Token = "0x17001081")]
    [IgnoreMember]
    public short this[BattleBonus type]
    {
      [Token(Token = "0x6007A08"), Address(RVA = "0x3B8E20", Offset = "0x3B7C20", VA = "0x103B8E20")] get
      {
        return new short();
      }
      [Token(Token = "0x6007A09"), Address(RVA = "0x3B8E50", Offset = "0x3B7C50", VA = "0x103B8E50")] set
      {
      }
    }

    [Token(Token = "0x6007A0A")]
    [Address(RVA = "0x3B84B0", Offset = "0x3B72B0", VA = "0x103B84B0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007A0B")]
    [Address(RVA = "0x3B84E0", Offset = "0x3B72E0", VA = "0x103B84E0")]
    public void CopyTo(BattleBonusParam dsc)
    {
    }

    [Token(Token = "0x6007A0C")]
    [Address(RVA = "0x3B8130", Offset = "0x3B6F30", VA = "0x103B8130")]
    public void Add(BattleBonusParam src)
    {
    }

    [Token(Token = "0x6007A0D")]
    [Address(RVA = "0x3B8980", Offset = "0x3B7780", VA = "0x103B8980")]
    public void Sub(BattleBonusParam src)
    {
    }

    [Token(Token = "0x6007A0E")]
    [Address(RVA = "0x3B7EE0", Offset = "0x3B6CE0", VA = "0x103B7EE0")]
    public void AddRate(BattleBonusParam src)
    {
    }

    [Token(Token = "0x6007A0F")]
    [Address(RVA = "0x3B7CB0", Offset = "0x3B6AB0", VA = "0x103B7CB0")]
    public void AddRateRoundUp(BattleBonusParam src)
    {
    }

    [Token(Token = "0x6007A10")]
    [Address(RVA = "0x3B8870", Offset = "0x3B7670", VA = "0x103B8870")]
    public void SubRateRoundDown(long percent)
    {
    }

    [Token(Token = "0x6007A11")]
    [Address(RVA = "0x3B86D0", Offset = "0x3B74D0", VA = "0x103B86D0")]
    public void ReplceHighest(BattleBonusParam comp)
    {
    }

    [Token(Token = "0x6007A12")]
    [Address(RVA = "0x3B8750", Offset = "0x3B7550", VA = "0x103B8750")]
    public void ReplceLowest(BattleBonusParam comp)
    {
    }

    [Token(Token = "0x6007A13")]
    [Address(RVA = "0x3B8310", Offset = "0x3B7110", VA = "0x103B8310")]
    public void ChoiceHighest(BattleBonusParam scale, BattleBonusParam base_status)
    {
    }

    [Token(Token = "0x6007A14")]
    [Address(RVA = "0x3B83E0", Offset = "0x3B71E0", VA = "0x103B83E0")]
    public void ChoiceLowest(BattleBonusParam scale, BattleBonusParam base_status)
    {
    }

    [Token(Token = "0x6007A15")]
    [Address(RVA = "0x3B7C10", Offset = "0x3B6A10", VA = "0x103B7C10")]
    public void AddConvRate(BattleBonusParam scale, BattleBonusParam base_status)
    {
    }

    [Token(Token = "0x6007A16")]
    [Address(RVA = "0x3B87D0", Offset = "0x3B75D0", VA = "0x103B87D0")]
    public void SubConvRate(BattleBonusParam scale, BattleBonusParam base_status)
    {
    }

    [Token(Token = "0x6007A17")]
    [Address(RVA = "0x3B8660", Offset = "0x3B7460", VA = "0x103B8660")]
    public void Mul(int mul_val)
    {
    }

    [Token(Token = "0x6007A18")]
    [Address(RVA = "0x3B8550", Offset = "0x3B7350", VA = "0x103B8550")]
    public void Div(int div_val)
    {
    }

    [Token(Token = "0x6007A19")]
    [Address(RVA = "0x3B8B60", Offset = "0x3B7960", VA = "0x103B8B60")]
    public void Swap(BattleBonusParam src, bool is_rev)
    {
    }

    [Token(Token = "0x6007A1A")]
    [Address(RVA = "0x3B8600", Offset = "0x3B7400", VA = "0x103B8600")]
    public ParamTypes GetParamTypes(int index) => new ParamTypes();

    [Token(Token = "0x6007A1B")]
    [Address(RVA = "0x3B8DA0", Offset = "0x3B7BA0", VA = "0x103B8DA0")]
    public BattleBonusParam()
    {
    }

    [Token(Token = "0x6007A1C")]
    [Address(RVA = "0x3B8CB0", Offset = "0x3B7AB0", VA = "0x103B8CB0")]
    static BattleBonusParam()
    {
    }
  }
}
