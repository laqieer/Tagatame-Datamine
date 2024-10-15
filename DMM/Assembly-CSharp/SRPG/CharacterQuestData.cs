// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002144")]
  public class CharacterQuestData
  {
    [Token(Token = "0x40090DB")]
    [FieldOffset(Offset = "0x8")]
    private CharacterQuestData.EStatus status;
    [Token(Token = "0x40090DC")]
    [FieldOffset(Offset = "0xC")]
    public CharacterQuestData.EType questType;
    [Token(Token = "0x40090DD")]
    [FieldOffset(Offset = "0x10")]
    public QuestParam questParam;
    [Token(Token = "0x40090DE")]
    [FieldOffset(Offset = "0x14")]
    public UnitData unitData1;
    [Token(Token = "0x40090DF")]
    [FieldOffset(Offset = "0x18")]
    public UnitData unitData2;
    [Token(Token = "0x40090E0")]
    [FieldOffset(Offset = "0x1C")]
    public UnitParam unitParam1;
    [Token(Token = "0x40090E1")]
    [FieldOffset(Offset = "0x20")]
    public UnitParam unitParam2;

    [Token(Token = "0x170013B3")]
    public bool HasUnit
    {
      [Token(Token = "0x6008BA5"), Address(RVA = "0x3683C0", Offset = "0x3671C0", VA = "0x103683C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013B4")]
    public bool HasPairUnit
    {
      [Token(Token = "0x6008BA6"), Address(RVA = "0x4F7510", Offset = "0x4F6310", VA = "0x104F7510")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013B5")]
    public CharacterQuestData.EStatus Status
    {
      [Token(Token = "0x6008BA7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new CharacterQuestData.EStatus();
      }
    }

    [Token(Token = "0x170013B6")]
    public bool IsLock
    {
      [Token(Token = "0x6008BA8"), Address(RVA = "0x4F7550", Offset = "0x4F6350", VA = "0x104F7550")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013B7")]
    public bool IsChallenged
    {
      [Token(Token = "0x6008BA9"), Address(RVA = "0x4F7530", Offset = "0x4F6330", VA = "0x104F7530")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013B8")]
    public bool IsComplete
    {
      [Token(Token = "0x6008BAA"), Address(RVA = "0x4F7540", Offset = "0x4F6340", VA = "0x104F7540")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013B9")]
    public bool IsNew
    {
      [Token(Token = "0x6008BAB"), Address(RVA = "0x4F7560", Offset = "0x4F6360", VA = "0x104F7560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008BAC")]
    [Address(RVA = "0x4F7110", Offset = "0x4F5F10", VA = "0x104F7110")]
    public CollaboSkillParam.Pair GetPairUnit() => (CollaboSkillParam.Pair) null;

    [Token(Token = "0x6008BAD")]
    [Address(RVA = "0x4F7180", Offset = "0x4F5F80", VA = "0x104F7180")]
    public void UpdateStatus()
    {
    }

    [Token(Token = "0x6008BAE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CharacterQuestData()
    {
    }

    [Token(Token = "0x2002145")]
    public enum EType
    {
      [Token(Token = "0x40090E3")] Chara,
      [Token(Token = "0x40090E4")] Collabo,
    }

    [Token(Token = "0x2002146")]
    public enum EStatus
    {
      [Token(Token = "0x40090E6")] New,
      [Token(Token = "0x40090E7")] Challenged,
      [Token(Token = "0x40090E8")] Lock,
      [Token(Token = "0x40090E9")] Complete,
    }
  }
}
