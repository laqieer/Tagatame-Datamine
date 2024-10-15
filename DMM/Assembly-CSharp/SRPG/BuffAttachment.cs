// Decompiled with JetBrains decompiler
// Type: SRPG.BuffAttachment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D7C")]
  [MessagePackObject(true)]
  public class BuffAttachment
  {
    [Token(Token = "0x400E300")]
    [FieldOffset(Offset = "0x8")]
    public Unit user;
    [Token(Token = "0x400E301")]
    [FieldOffset(Offset = "0xC")]
    public Unit CheckTarget;
    [Token(Token = "0x400E302")]
    [FieldOffset(Offset = "0x10")]
    private OInt mCheckTiming;
    [Token(Token = "0x400E303")]
    [FieldOffset(Offset = "0x24")]
    private OInt mUseCondition;
    [Token(Token = "0x400E304")]
    [FieldOffset(Offset = "0x38")]
    public OInt turn;
    [Token(Token = "0x400E305")]
    [FieldOffset(Offset = "0x4C")]
    public OBool IsPassive;
    [Token(Token = "0x400E306")]
    [FieldOffset(Offset = "0x58")]
    public SkillData skill;
    [Token(Token = "0x400E307")]
    [FieldOffset(Offset = "0x5C")]
    public SkillEffectTargets skilltarget;
    [Token(Token = "0x400E308")]
    [FieldOffset(Offset = "0x60")]
    private BuffEffect mBuffEffect;
    [Token(Token = "0x400E309")]
    [FieldOffset(Offset = "0x64")]
    public BaseStatus status;
    [Token(Token = "0x400E30A")]
    [FieldOffset(Offset = "0x68")]
    private OInt mBuffType;
    [Token(Token = "0x400E30B")]
    [FieldOffset(Offset = "0x7C")]
    public bool IsNegativeValueIsBuff;
    [Token(Token = "0x400E30C")]
    [FieldOffset(Offset = "0x80")]
    private OInt mCalcType;
    [Token(Token = "0x400E30D")]
    [FieldOffset(Offset = "0x94")]
    public int DuplicateCount;
    [Token(Token = "0x400E30E")]
    [FieldOffset(Offset = "0x98")]
    public bool IsCalculated;
    [Token(Token = "0x400E30F")]
    [FieldOffset(Offset = "0x9C")]
    public uint LinkageID;
    [Token(Token = "0x400E310")]
    [FieldOffset(Offset = "0xA0")]
    public OInt UpBuffCount;
    [Token(Token = "0x400E311")]
    [FieldOffset(Offset = "0xB4")]
    public List<BuffAttachment.ResistStatusBuff> ResistStatusBuffList;
    [Token(Token = "0x400E312")]
    [FieldOffset(Offset = "0xB8")]
    public bool IsPrevApply;
    [Token(Token = "0x400E313")]
    [FieldOffset(Offset = "0xB9")]
    public AttackDetailTypes LastAtkDetailType;
    [Token(Token = "0x400E314")]
    [FieldOffset(Offset = "0xBA")]
    public bool IsPredictIgonre;

    [Token(Token = "0x17001BC1")]
    public EffectCheckTimings CheckTiming
    {
      [Token(Token = "0x600D425"), Address(RVA = "0x9DCE60", Offset = "0x9DBC60", VA = "0x109DCE60")] get
      {
        return new EffectCheckTimings();
      }
      [Token(Token = "0x600D426"), Address(RVA = "0x9DCFA0", Offset = "0x9DBDA0", VA = "0x109DCFA0")] set
      {
      }
    }

    [Token(Token = "0x17001BC2")]
    public ESkillCondition UseCondition
    {
      [Token(Token = "0x600D427"), Address(RVA = "0x9DCF00", Offset = "0x9DBD00", VA = "0x109DCF00")] get
      {
        return new ESkillCondition();
      }
      [Token(Token = "0x600D428"), Address(RVA = "0x9DCFD0", Offset = "0x9DBDD0", VA = "0x109DCFD0")] set
      {
      }
    }

    [Token(Token = "0x17001BC3")]
    public BuffEffect BuffEffect
    {
      [Token(Token = "0x600D429"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return (BuffEffect) null;
      }
    }

    [Token(Token = "0x17001BC4")]
    public BuffEffectParam Param
    {
      [Token(Token = "0x600D42A"), Address(RVA = "0x9DCEE0", Offset = "0x9DBCE0", VA = "0x109DCEE0")] get
      {
        return (BuffEffectParam) null;
      }
    }

    [Token(Token = "0x17001BC5")]
    public BuffTypes BuffType
    {
      [Token(Token = "0x600D42B"), Address(RVA = "0x9DCE00", Offset = "0x9DBC00", VA = "0x109DCE00")] get
      {
        return new BuffTypes();
      }
      [Token(Token = "0x600D42C"), Address(RVA = "0x9DCF30", Offset = "0x9DBD30", VA = "0x109DCF30")] set
      {
      }
    }

    [Token(Token = "0x17001BC6")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x600D42D"), Address(RVA = "0x9DCE30", Offset = "0x9DBC30", VA = "0x109DCE30")] get
      {
        return new SkillParamCalcTypes();
      }
      [Token(Token = "0x600D42E"), Address(RVA = "0x9DCF60", Offset = "0x9DBD60", VA = "0x109DCF60")] set
      {
      }
    }

    [Token(Token = "0x600D42F")]
    [Address(RVA = "0x9DCD30", Offset = "0x9DBB30", VA = "0x109DCD30")]
    public BuffAttachment()
    {
    }

    [Token(Token = "0x600D430")]
    [Address(RVA = "0x9DCC50", Offset = "0x9DBA50", VA = "0x109DCC50")]
    public BuffAttachment(BuffEffect buff_effect)
    {
    }

    [Token(Token = "0x600D431")]
    [Address(RVA = "0x9DC7A0", Offset = "0x9DB5A0", VA = "0x109DC7A0")]
    public void CopyTo(BuffAttachment dsc)
    {
    }

    [Token(Token = "0x17001BC7")]
    public bool IsCalcLaterCondition
    {
      [Token(Token = "0x600D432"), Address(RVA = "0x9DCE90", Offset = "0x9DBC90", VA = "0x109DCE90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D433")]
    [Address(RVA = "0x9DC960", Offset = "0x9DB760", VA = "0x109DC960")]
    public void EntryResistStatusBuffList(int[] status_buffs)
    {
    }

    [Token(Token = "0x600D434")]
    [Address(RVA = "0x9DCB00", Offset = "0x9DB900", VA = "0x109DCB00")]
    public static int[] GetResistStatusBuffList(List<BuffAttachment.ResistStatusBuff> rsb_list)
    {
      return (int[]) null;
    }

    [Token(Token = "0x2002D7D")]
    [MessagePackObject(false)]
    public class ResistStatusBuff
    {
      [Token(Token = "0x400E315")]
      [FieldOffset(Offset = "0x8")]
      [Key(0)]
      public StatusTypes mType;
      [Token(Token = "0x400E316")]
      [FieldOffset(Offset = "0xC")]
      [Key(1)]
      public OInt mVal;

      [Token(Token = "0x600D435")]
      [Address(RVA = "0x9DEA90", Offset = "0x9DD890", VA = "0x109DEA90")]
      [SerializationConstructor]
      public ResistStatusBuff(StatusTypes st, int val)
      {
      }
    }
  }
}
