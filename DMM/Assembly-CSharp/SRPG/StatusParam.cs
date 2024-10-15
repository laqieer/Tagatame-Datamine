// Decompiled with JetBrains decompiler
// Type: SRPG.StatusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E7F")]
  [MessagePackObject(true)]
  public class StatusParam
  {
    [Token(Token = "0x4007E90")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_STATUS;
    [Token(Token = "0x4007E91")]
    [FieldOffset(Offset = "0x8")]
    public int values_hp;
    [Token(Token = "0x4007E92")]
    [FieldOffset(Offset = "0xC")]
    public short[] values;
    [Token(Token = "0x4007E93")]
    private const string SUSPEND_STATUS_HP_KEY = "h";
    [Token(Token = "0x4007E94")]
    [FieldOffset(Offset = "0x4")]
    public static readonly ParamTypes[] ConvertParamTypes;

    [Token(Token = "0x6007CDC")]
    [Address(RVA = "0x3EE800", Offset = "0x3ED600", VA = "0x103EE800")]
    public string ToSuspendString() => (string) null;

    [Token(Token = "0x6007CDD")]
    [Address(RVA = "0x3EDEA0", Offset = "0x3ECCA0", VA = "0x103EDEA0")]
    public bool FromSuspendString(string str) => new bool();

    [Token(Token = "0x17001168")]
    public int Length
    {
      [Token(Token = "0x6007CDE"), Address(RVA = "0x3EEAC0", Offset = "0x3ED8C0", VA = "0x103EEAC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001169")]
    [IgnoreMember]
    public int this[StatusTypes type]
    {
      [Token(Token = "0x6007CDF"), Address(RVA = "0x3EEA90", Offset = "0x3ED890", VA = "0x103EEA90")] get
      {
        return new int();
      }
      [Token(Token = "0x6007CE0"), Address(RVA = "0x3EEDC0", Offset = "0x3EDBC0", VA = "0x103EEDC0")] set
      {
      }
    }

    [Token(Token = "0x1700116A")]
    public int hp
    {
      [Token(Token = "0x6007CE1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007CE2"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
      {
      }
    }

    [Token(Token = "0x1700116B")]
    public short mp
    {
      [Token(Token = "0x6007CE3"), Address(RVA = "0x3EECE0", Offset = "0x3EDAE0", VA = "0x103EECE0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CE4"), Address(RVA = "0x3EEFE0", Offset = "0x3EDDE0", VA = "0x103EEFE0")] set
      {
      }
    }

    [Token(Token = "0x1700116C")]
    public short imp
    {
      [Token(Token = "0x6007CE5"), Address(RVA = "0x3EEBC0", Offset = "0x3ED9C0", VA = "0x103EEBC0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CE6"), Address(RVA = "0x3EEEC0", Offset = "0x3EDCC0", VA = "0x103EEEC0")] set
      {
      }
    }

    [Token(Token = "0x1700116D")]
    public short atk
    {
      [Token(Token = "0x6007CE7"), Address(RVA = "0x3EEB00", Offset = "0x3ED900", VA = "0x103EEB00")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CE8"), Address(RVA = "0x3EEE00", Offset = "0x3EDC00", VA = "0x103EEE00")] set
      {
      }
    }

    [Token(Token = "0x1700116E")]
    public short def
    {
      [Token(Token = "0x6007CE9"), Address(RVA = "0x3EEB60", Offset = "0x3ED960", VA = "0x103EEB60")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CEA"), Address(RVA = "0x3EEE60", Offset = "0x3EDC60", VA = "0x103EEE60")] set
      {
      }
    }

    [Token(Token = "0x1700116F")]
    public short mag
    {
      [Token(Token = "0x6007CEB"), Address(RVA = "0x3EEC50", Offset = "0x3EDA50", VA = "0x103EEC50")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CEC"), Address(RVA = "0x3EEF50", Offset = "0x3EDD50", VA = "0x103EEF50")] set
      {
      }
    }

    [Token(Token = "0x17001170")]
    public short mnd
    {
      [Token(Token = "0x6007CED"), Address(RVA = "0x3EEC80", Offset = "0x3EDA80", VA = "0x103EEC80")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CEE"), Address(RVA = "0x3EEF80", Offset = "0x3EDD80", VA = "0x103EEF80")] set
      {
      }
    }

    [Token(Token = "0x17001171")]
    public short rec
    {
      [Token(Token = "0x6007CEF"), Address(RVA = "0x3EED10", Offset = "0x3EDB10", VA = "0x103EED10")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CF0"), Address(RVA = "0x3EF010", Offset = "0x3EDE10", VA = "0x103EF010")] set
      {
      }
    }

    [Token(Token = "0x17001172")]
    public short dex
    {
      [Token(Token = "0x6007CF1"), Address(RVA = "0x3EEB90", Offset = "0x3ED990", VA = "0x103EEB90")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CF2"), Address(RVA = "0x3EEE90", Offset = "0x3EDC90", VA = "0x103EEE90")] set
      {
      }
    }

    [Token(Token = "0x17001173")]
    public short spd
    {
      [Token(Token = "0x6007CF3"), Address(RVA = "0x3EED40", Offset = "0x3EDB40", VA = "0x103EED40")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CF4"), Address(RVA = "0x3EF040", Offset = "0x3EDE40", VA = "0x103EF040")] set
      {
      }
    }

    [Token(Token = "0x17001174")]
    public short cri
    {
      [Token(Token = "0x6007CF5"), Address(RVA = "0x3EEB30", Offset = "0x3ED930", VA = "0x103EEB30")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CF6"), Address(RVA = "0x3EEE30", Offset = "0x3EDC30", VA = "0x103EEE30")] set
      {
      }
    }

    [Token(Token = "0x17001175")]
    public short luk
    {
      [Token(Token = "0x6007CF7"), Address(RVA = "0x3EEC20", Offset = "0x3EDA20", VA = "0x103EEC20")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CF8"), Address(RVA = "0x3EEF20", Offset = "0x3EDD20", VA = "0x103EEF20")] set
      {
      }
    }

    [Token(Token = "0x17001176")]
    public short mov
    {
      [Token(Token = "0x6007CF9"), Address(RVA = "0x3EECB0", Offset = "0x3EDAB0", VA = "0x103EECB0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CFA"), Address(RVA = "0x3EEFB0", Offset = "0x3EDDB0", VA = "0x103EEFB0")] set
      {
      }
    }

    [Token(Token = "0x17001177")]
    public short jmp
    {
      [Token(Token = "0x6007CFB"), Address(RVA = "0x3EEBF0", Offset = "0x3ED9F0", VA = "0x103EEBF0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007CFC"), Address(RVA = "0x3EEEF0", Offset = "0x3EDCF0", VA = "0x103EEEF0")] set
      {
      }
    }

    [Token(Token = "0x17001178")]
    public int total
    {
      [Token(Token = "0x6007CFD"), Address(RVA = "0x3EED70", Offset = "0x3EDB70", VA = "0x103EED70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007CFE")]
    [Address(RVA = "0x3EDD90", Offset = "0x3ECB90", VA = "0x103EDD90")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007CFF")]
    [Address(RVA = "0x3EDDC0", Offset = "0x3ECBC0", VA = "0x103EDDC0")]
    public void CopyTo(StatusParam dsc)
    {
    }

    [Token(Token = "0x6007D00")]
    [Address(RVA = "0x3ED830", Offset = "0x3EC630", VA = "0x103ED830")]
    public void Add(StatusParam src)
    {
    }

    [Token(Token = "0x6007D01")]
    [Address(RVA = "0x3EE4C0", Offset = "0x3ED2C0", VA = "0x103EE4C0")]
    public void Sub(StatusParam src)
    {
    }

    [Token(Token = "0x6007D02")]
    [Address(RVA = "0x3ED5B0", Offset = "0x3EC3B0", VA = "0x103ED5B0")]
    public void AddRate(StatusParam src)
    {
    }

    [Token(Token = "0x6007D03")]
    [Address(RVA = "0x3ED320", Offset = "0x3EC120", VA = "0x103ED320")]
    public void AddRateRoundUp(StatusParam src)
    {
    }

    [Token(Token = "0x6007D04")]
    [Address(RVA = "0x3EE380", Offset = "0x3ED180", VA = "0x103EE380")]
    public void SubRateRoundDown(long percent)
    {
    }

    [Token(Token = "0x6007D05")]
    [Address(RVA = "0x3EE180", Offset = "0x3ECF80", VA = "0x103EE180")]
    public void ReplceHighest(StatusParam comp)
    {
    }

    [Token(Token = "0x6007D06")]
    [Address(RVA = "0x3EE200", Offset = "0x3ED000", VA = "0x103EE200")]
    public void ReplceLowest(StatusParam comp)
    {
    }

    [Token(Token = "0x6007D07")]
    [Address(RVA = "0x3EDB40", Offset = "0x3EC940", VA = "0x103EDB40")]
    public void ChoiceHighest(StatusParam scale, StatusParam base_status)
    {
    }

    [Token(Token = "0x6007D08")]
    [Address(RVA = "0x3EDC70", Offset = "0x3ECA70", VA = "0x103EDC70")]
    public void ChoiceLowest(StatusParam scale, StatusParam base_status)
    {
    }

    [Token(Token = "0x6007D09")]
    [Address(RVA = "0x3EDA10", Offset = "0x3EC810", VA = "0x103EDA10")]
    public void ApplyMinVal()
    {
    }

    [Token(Token = "0x6007D0A")]
    [Address(RVA = "0x3ED220", Offset = "0x3EC020", VA = "0x103ED220")]
    public void AddConvRate(StatusParam scale, StatusParam base_status)
    {
    }

    [Token(Token = "0x6007D0B")]
    [Address(RVA = "0x3EE280", Offset = "0x3ED080", VA = "0x103EE280")]
    public void SubConvRate(StatusParam scale, StatusParam base_status)
    {
    }

    [Token(Token = "0x6007D0C")]
    [Address(RVA = "0x3EE110", Offset = "0x3ECF10", VA = "0x103EE110")]
    public void Mul(int mul_val)
    {
    }

    [Token(Token = "0x6007D0D")]
    [Address(RVA = "0x3EDE30", Offset = "0x3ECC30", VA = "0x103EDE30")]
    public void Div(int div_val)
    {
    }

    [Token(Token = "0x6007D0E")]
    [Address(RVA = "0x3EE6A0", Offset = "0x3ED4A0", VA = "0x103EE6A0")]
    public void Swap(StatusParam src, bool is_rev)
    {
    }

    [Token(Token = "0x6007D0F")]
    [Address(RVA = "0x3EE0B0", Offset = "0x3ECEB0", VA = "0x103EE0B0")]
    public ParamTypes GetParamTypes(int index) => new ParamTypes();

    [Token(Token = "0x6007D10")]
    [Address(RVA = "0x3EEA10", Offset = "0x3ED810", VA = "0x103EEA10")]
    public StatusParam()
    {
    }

    [Token(Token = "0x6007D11")]
    [Address(RVA = "0x3EE920", Offset = "0x3ED720", VA = "0x103EE920")]
    static StatusParam()
    {
    }
  }
}
