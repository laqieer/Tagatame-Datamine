// Decompiled with JetBrains decompiler
// Type: SRPG.CondAttachment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D7E")]
  [MessagePackObject(true)]
  public class CondAttachment
  {
    [Token(Token = "0x400E317")]
    [FieldOffset(Offset = "0x8")]
    public Unit user;
    [Token(Token = "0x400E318")]
    [FieldOffset(Offset = "0xC")]
    public Unit CheckTarget;
    [Token(Token = "0x400E319")]
    [FieldOffset(Offset = "0x10")]
    private OInt mCheckTiming;
    [Token(Token = "0x400E31A")]
    [FieldOffset(Offset = "0x24")]
    private OInt mUseCondition;
    [Token(Token = "0x400E31B")]
    [FieldOffset(Offset = "0x38")]
    public OInt turn;
    [Token(Token = "0x400E31C")]
    [FieldOffset(Offset = "0x4C")]
    public OBool IsPassive;
    [Token(Token = "0x400E31D")]
    [FieldOffset(Offset = "0x58")]
    public SkillData skill;
    [Token(Token = "0x400E31E")]
    [FieldOffset(Offset = "0x5C")]
    public SkillEffectTargets skilltarget;
    [Token(Token = "0x400E31F")]
    [FieldOffset(Offset = "0x60")]
    public string CondId;
    [Token(Token = "0x400E320")]
    [FieldOffset(Offset = "0x64")]
    private CondEffectParam mParam;
    [Token(Token = "0x400E321")]
    [FieldOffset(Offset = "0x68")]
    private OInt mCondType;
    [Token(Token = "0x400E322")]
    [FieldOffset(Offset = "0x80")]
    private OLong mCondition;
    [Token(Token = "0x400E324")]
    [FieldOffset(Offset = "0xAC")]
    public BuffEffect LinkageBuff;
    [Token(Token = "0x400E325")]
    [FieldOffset(Offset = "0xB0")]
    public uint LinkageID;
    [Token(Token = "0x400E326")]
    [FieldOffset(Offset = "0xB4")]
    public int Damage;
    [Token(Token = "0x400E327")]
    [FieldOffset(Offset = "0xB8")]
    public int CostJewel;
    [Token(Token = "0x400E328")]
    [FieldOffset(Offset = "0xBC")]
    public int HealCount;
    [Token(Token = "0x400E329")]
    [FieldOffset(Offset = "0xC0")]
    public int MpDamage;
    [Token(Token = "0x400E32A")]
    [FieldOffset(Offset = "0xC4")]
    public int JewelMax;

    [Token(Token = "0x17001BC8")]
    public EffectCheckTimings CheckTiming
    {
      [Token(Token = "0x600D436"), Address(RVA = "0x9DCE60", Offset = "0x9DBC60", VA = "0x109DCE60")] get
      {
        return new EffectCheckTimings();
      }
      [Token(Token = "0x600D437"), Address(RVA = "0x9DCFA0", Offset = "0x9DBDA0", VA = "0x109DCFA0")] set
      {
      }
    }

    [Token(Token = "0x17001BC9")]
    public ESkillCondition UseCondition
    {
      [Token(Token = "0x600D438"), Address(RVA = "0x9DCF00", Offset = "0x9DBD00", VA = "0x109DCF00")] get
      {
        return new ESkillCondition();
      }
      [Token(Token = "0x600D439"), Address(RVA = "0x9DCFD0", Offset = "0x9DBDD0", VA = "0x109DCFD0")] set
      {
      }
    }

    [Token(Token = "0x17001BCA")]
    public CondEffectParam Param
    {
      [Token(Token = "0x600D43A"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return (CondEffectParam) null;
      }
    }

    [Token(Token = "0x17001BCB")]
    public ConditionEffectTypes CondType
    {
      [Token(Token = "0x600D43B"), Address(RVA = "0x9DCE00", Offset = "0x9DBC00", VA = "0x109DCE00")] get
      {
        return new ConditionEffectTypes();
      }
      [Token(Token = "0x600D43C"), Address(RVA = "0x9DCF30", Offset = "0x9DBD30", VA = "0x109DCF30")] set
      {
      }
    }

    [Token(Token = "0x17001BCC")]
    public EUnitCondition Condition
    {
      [Token(Token = "0x600D43D"), Address(RVA = "0x9DDA70", Offset = "0x9DC870", VA = "0x109DDA70")] get
      {
        return new EUnitCondition();
      }
      [Token(Token = "0x600D43E"), Address(RVA = "0x9DDAB0", Offset = "0x9DC8B0", VA = "0x109DDAB0")] set
      {
      }
    }

    [Token(Token = "0x17001BCD")]
    public bool IsCurse
    {
      [Token(Token = "0x600D43F"), Address(RVA = "0x5FC050", Offset = "0x5FAE50", VA = "0x105FC050")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D440"), Address(RVA = "0x5FC150", Offset = "0x5FAF50", VA = "0x105FC150")] set
      {
      }
    }

    [Token(Token = "0x600D441")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CondAttachment()
    {
    }

    [Token(Token = "0x600D442")]
    [Address(RVA = "0x9DDA40", Offset = "0x9DC840", VA = "0x109DDA40")]
    public CondAttachment(CondEffectParam param)
    {
    }

    [Token(Token = "0x600D443")]
    [Address(RVA = "0x9DD590", Offset = "0x9DC390", VA = "0x109DD590")]
    public void CopyTo(CondAttachment dsc)
    {
    }

    [Token(Token = "0x600D444")]
    [Address(RVA = "0x9DD770", Offset = "0x9DC570", VA = "0x109DD770")]
    public bool IsFailCondition() => new bool();

    [Token(Token = "0x600D445")]
    [Address(RVA = "0x9DD540", Offset = "0x9DC340", VA = "0x109DD540")]
    public bool ContainsCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x600D446")]
    [Address(RVA = "0x9DD7B0", Offset = "0x9DC5B0", VA = "0x109DD7B0")]
    public bool IsSame(CondAttachment dsc, bool is_ignore_timing = false) => new bool();

    [Token(Token = "0x600D447")]
    [Address(RVA = "0x9DD930", Offset = "0x9DC730", VA = "0x109DD930")]
    public void SetupLinkageBuff()
    {
    }

    [Token(Token = "0x600D448")]
    [Address(RVA = "0x9DD000", Offset = "0x9DBE00", VA = "0x109DD000")]
    public static bool CalcBombParam(Unit target, ref int cost_jewel) => new bool();

    [Token(Token = "0x600D449")]
    [Address(RVA = "0x9DD350", Offset = "0x9DC150", VA = "0x109DD350")]
    public static bool CalcSlipParam(Unit target, ref int damage, ref int heal_count) => new bool();

    [Token(Token = "0x600D44A")]
    [Address(RVA = "0x9DD1F0", Offset = "0x9DBFF0", VA = "0x109DD1F0")]
    public static bool CalcDownParam(
      Unit target,
      ref int mp_damage,
      ref int cost_jewel,
      ref int jewel_max)
    {
      return new bool();
    }
  }
}
