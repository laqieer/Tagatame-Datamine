// Decompiled with JetBrains decompiler
// Type: SRPG.BaseStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DD1")]
  [MessagePackObject(true)]
  public class BaseStatus
  {
    [Token(Token = "0x4007724")]
    [FieldOffset(Offset = "0x0")]
    public static readonly short SHORT_PARAM_MAX;
    [Token(Token = "0x4007725")]
    [FieldOffset(Offset = "0x2")]
    public static readonly short SHORT_PARAM_MIN;
    [Token(Token = "0x4007726")]
    [FieldOffset(Offset = "0x8")]
    public StatusParam param;
    [Token(Token = "0x4007727")]
    [FieldOffset(Offset = "0xC")]
    public ElementParam element_assist;
    [Token(Token = "0x4007728")]
    [FieldOffset(Offset = "0x10")]
    public ElementParam element_resist;
    [Token(Token = "0x4007729")]
    [FieldOffset(Offset = "0x14")]
    public EnchantParam enchant_assist;
    [Token(Token = "0x400772A")]
    [FieldOffset(Offset = "0x18")]
    public EnchantParam enchant_resist;
    [Token(Token = "0x400772B")]
    [FieldOffset(Offset = "0x1C")]
    public BattleBonusParam bonus;
    [Token(Token = "0x400772C")]
    [FieldOffset(Offset = "0x20")]
    public TokkouParam tokkou;
    [Token(Token = "0x400772D")]
    [FieldOffset(Offset = "0x24")]
    public TokkouParam tokubou;
    [Token(Token = "0x400772E")]
    public const char SUSPEND_DATA_SEPARATOR = ',';
    [Token(Token = "0x400772F")]
    public const char SUSPEND_PAIR_SEPARATOR = '=';
    [Token(Token = "0x4007730")]
    public const char SUSPEND_STATUS_SEPARATOR = '|';

    [Token(Token = "0x60079E4")]
    [Address(RVA = "0x3B5A00", Offset = "0x3B4800", VA = "0x103B5A00")]
    public string ToSuspendString() => (string) null;

    [Token(Token = "0x60079E5")]
    [Address(RVA = "0x3B4EE0", Offset = "0x3B3CE0", VA = "0x103B4EE0")]
    public bool FromSuspendString(string str) => new bool();

    [Token(Token = "0x60079E6")]
    [Address(RVA = "0x3B4D30", Offset = "0x3B3B30", VA = "0x103B4D30")]
    private TokkouParam CreateTokkouParamFromJson(string str) => (TokkouParam) null;

    [Token(Token = "0x60079E7")]
    [Address(RVA = "0x3B4A30", Offset = "0x3B3830", VA = "0x103B4A30")]
    public static string ConvertSuspendStringFromArray(short[] values) => (string) null;

    [Token(Token = "0x60079E8")]
    [Address(RVA = "0x3B48D0", Offset = "0x3B36D0", VA = "0x103B48D0")]
    public static bool ConvertArrayFromSuspendString(ref short[] values, string str) => new bool();

    [Token(Token = "0x1700107C")]
    [IgnoreMember]
    public OInt this[StatusTypes type]
    {
      [Token(Token = "0x60079E9"), Address(RVA = "0x3B6140", Offset = "0x3B4F40", VA = "0x103B6140")] get
      {
        return new OInt();
      }
      [Token(Token = "0x60079EA"), Address(RVA = "0x3B7B70", Offset = "0x3B6970", VA = "0x103B7B70")] set
      {
      }
    }

    [Token(Token = "0x1700107D")]
    [IgnoreMember]
    public OInt this[EnchantCategory category, EElement element]
    {
      [Token(Token = "0x60079EB"), Address(RVA = "0x3B61F0", Offset = "0x3B4FF0", VA = "0x103B61F0")] get
      {
        return new OInt();
      }
      [Token(Token = "0x60079EC"), Address(RVA = "0x3B7B20", Offset = "0x3B6920", VA = "0x103B7B20")] set
      {
      }
    }

    [Token(Token = "0x1700107E")]
    [IgnoreMember]
    public OInt this[EnchantCategory category, EnchantTypes type]
    {
      [Token(Token = "0x60079ED"), Address(RVA = "0x3B7A80", Offset = "0x3B6880", VA = "0x103B7A80")] get
      {
        return new OInt();
      }
      [Token(Token = "0x60079EE"), Address(RVA = "0x3B7BC0", Offset = "0x3B69C0", VA = "0x103B7BC0")] set
      {
      }
    }

    [Token(Token = "0x1700107F")]
    [IgnoreMember]
    public OInt this[BattleBonus type]
    {
      [Token(Token = "0x60079EF"), Address(RVA = "0x3B6190", Offset = "0x3B4F90", VA = "0x103B6190")] get
      {
        return new OInt();
      }
      [Token(Token = "0x60079F0"), Address(RVA = "0x3B7AD0", Offset = "0x3B68D0", VA = "0x103B7AD0")] set
      {
      }
    }

    [Token(Token = "0x17001080")]
    [IgnoreMember]
    public virtual int this[ParamTypes type]
    {
      [Token(Token = "0x60079F1"), Address(RVA = "0x3B6240", Offset = "0x3B5040", VA = "0x103B6240", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60079F2")]
    [Address(RVA = "0x3B4810", Offset = "0x3B3610", VA = "0x103B4810")]
    public void Clear()
    {
    }

    [Token(Token = "0x60079F3")]
    [Address(RVA = "0x3B5DB0", Offset = "0x3B4BB0", VA = "0x103B5DB0")]
    public BaseStatus()
    {
    }

    [Token(Token = "0x60079F4")]
    [Address(RVA = "0x3B5F70", Offset = "0x3B4D70", VA = "0x103B5F70")]
    public BaseStatus(BaseStatus src)
    {
    }

    [Token(Token = "0x60079F5")]
    [Address(RVA = "0x3B4BF0", Offset = "0x3B39F0", VA = "0x103B4BF0")]
    public void CopyTo(BaseStatus dsc)
    {
    }

    [Token(Token = "0x60079F6")]
    [Address(RVA = "0x3B4420", Offset = "0x3B3220", VA = "0x103B4420")]
    public void Add(BaseStatus src)
    {
    }

    [Token(Token = "0x60079F7")]
    [Address(RVA = "0x3B57B0", Offset = "0x3B45B0", VA = "0x103B57B0")]
    public void Sub(BaseStatus src)
    {
    }

    [Token(Token = "0x60079F8")]
    [Address(RVA = "0x3B4380", Offset = "0x3B3180", VA = "0x103B4380")]
    public void AddRate(BaseStatus src)
    {
    }

    [Token(Token = "0x60079F9")]
    [Address(RVA = "0x3B4350", Offset = "0x3B3150", VA = "0x103B4350")]
    public void AddRate(StatusParam src)
    {
    }

    [Token(Token = "0x60079FA")]
    [Address(RVA = "0x3B42B0", Offset = "0x3B30B0", VA = "0x103B42B0")]
    public void AddRateRoundUp(BaseStatus src)
    {
    }

    [Token(Token = "0x60079FB")]
    [Address(RVA = "0x3B55E0", Offset = "0x3B43E0", VA = "0x103B55E0")]
    public void SubRateRoundDown(long percent)
    {
    }

    [Token(Token = "0x60079FC")]
    [Address(RVA = "0x3B51D0", Offset = "0x3B3FD0", VA = "0x103B51D0")]
    public void ReplaceHighest(BaseStatus comp)
    {
    }

    [Token(Token = "0x60079FD")]
    [Address(RVA = "0x3B5320", Offset = "0x3B4120", VA = "0x103B5320")]
    public void ReplaceLowest(BaseStatus comp)
    {
    }

    [Token(Token = "0x60079FE")]
    [Address(RVA = "0x3B44F0", Offset = "0x3B32F0", VA = "0x103B44F0")]
    public void ChoiceHighest(BaseStatus scale, BaseStatus base_status)
    {
    }

    [Token(Token = "0x60079FF")]
    [Address(RVA = "0x3B4680", Offset = "0x3B3480", VA = "0x103B4680")]
    public void ChoiceLowest(BaseStatus scale, BaseStatus base_status)
    {
    }

    [Token(Token = "0x6007A00")]
    [Address(RVA = "0x3B4140", Offset = "0x3B2F40", VA = "0x103B4140")]
    public void AddConvRate(BaseStatus scale, BaseStatus base_status)
    {
    }

    [Token(Token = "0x6007A01")]
    [Address(RVA = "0x3B5470", Offset = "0x3B4270", VA = "0x103B5470")]
    public void SubConvRate(BaseStatus scale, BaseStatus base_status)
    {
    }

    [Token(Token = "0x6007A02")]
    [Address(RVA = "0x3B50F0", Offset = "0x3B3EF0", VA = "0x103B50F0")]
    public void Mul(int mul_val)
    {
    }

    [Token(Token = "0x6007A03")]
    [Address(RVA = "0x3B4E00", Offset = "0x3B3C00", VA = "0x103B4E00")]
    public void Div(int div_val)
    {
    }

    [Token(Token = "0x6007A04")]
    [Address(RVA = "0x3B5850", Offset = "0x3B4650", VA = "0x103B5850")]
    public void Swap(BaseStatus src, bool is_rev = false)
    {
    }

    [Token(Token = "0x6007A05")]
    [Address(RVA = "0x3B5D70", Offset = "0x3B4B70", VA = "0x103B5D70")]
    static BaseStatus()
    {
    }

    [Token(Token = "0x2001DD2")]
    public enum eSuspendPair
    {
      [Token(Token = "0x4007732")] Key,
      [Token(Token = "0x4007733")] Val,
      [Token(Token = "0x4007734")] MAX,
    }

    [Token(Token = "0x2001DD3")]
    private enum eSuspendParam
    {
      [Token(Token = "0x4007736")] Param,
      [Token(Token = "0x4007737")] ElementAssist,
      [Token(Token = "0x4007738")] ElementResist,
      [Token(Token = "0x4007739")] EnchantAssist,
      [Token(Token = "0x400773A")] EnchantResist,
      [Token(Token = "0x400773B")] Bonus,
      [Token(Token = "0x400773C")] Tokkou,
      [Token(Token = "0x400773D")] Tokubou,
      [Token(Token = "0x400773E")] MAX,
    }
  }
}
