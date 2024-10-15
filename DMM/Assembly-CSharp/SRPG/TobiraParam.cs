// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D69")]
  [MessagePackObject(true)]
  public class TobiraParam
  {
    [Token(Token = "0x40073D4")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_TOBIRA_COUNT;
    [Token(Token = "0x40073D5")]
    [FieldOffset(Offset = "0x8")]
    private string mUnitIname;
    [Token(Token = "0x40073D6")]
    [FieldOffset(Offset = "0xC")]
    private bool mEnable;
    [Token(Token = "0x40073D7")]
    [FieldOffset(Offset = "0x10")]
    private TobiraParam.Category mCategory;
    [Token(Token = "0x40073D8")]
    [FieldOffset(Offset = "0x14")]
    private string mRecipeId;
    [Token(Token = "0x40073D9")]
    [FieldOffset(Offset = "0x18")]
    private string mSkillIname;
    [Token(Token = "0x40073DA")]
    [FieldOffset(Offset = "0x1C")]
    private List<TobiraLearnAbilityParam> mLearnAbilities;
    [Token(Token = "0x40073DB")]
    [FieldOffset(Offset = "0x20")]
    private string mOverwriteLeaderSkillIname;
    [Token(Token = "0x40073DC")]
    [FieldOffset(Offset = "0x24")]
    private int mOverwriteLeaderSkillLevel;
    [Token(Token = "0x40073DD")]
    [FieldOffset(Offset = "0x28")]
    private int mPriority;

    [Token(Token = "0x6007866")]
    [Address(RVA = "0x3A46D0", Offset = "0x3A34D0", VA = "0x103A46D0")]
    public static string GetCategoryName(TobiraParam.Category category) => (string) null;

    [Token(Token = "0x17001014")]
    public string UnitIname
    {
      [Token(Token = "0x6007867"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001015")]
    public bool Enable
    {
      [Token(Token = "0x6007868"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001016")]
    public TobiraParam.Category TobiraCategory
    {
      [Token(Token = "0x6007869"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new TobiraParam.Category();
      }
    }

    [Token(Token = "0x17001017")]
    public string RecipeId
    {
      [Token(Token = "0x600786A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001018")]
    public string SkillIname
    {
      [Token(Token = "0x600786B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001019")]
    public TobiraLearnAbilityParam[] LeanAbilityParam
    {
      [Token(Token = "0x600786C"), Address(RVA = "0x3A4B00", Offset = "0x3A3900", VA = "0x103A4B00")] get
      {
        return (TobiraLearnAbilityParam[]) null;
      }
    }

    [Token(Token = "0x1700101A")]
    public string OverwriteLeaderSkillIname
    {
      [Token(Token = "0x600786D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700101B")]
    public int OverwriteLeaderSkillLevel
    {
      [Token(Token = "0x600786E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700101C")]
    public int Priority
    {
      [Token(Token = "0x600786F"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700101D")]
    public bool HasLeaerSkill
    {
      [Token(Token = "0x6007870"), Address(RVA = "0x3A4930", Offset = "0x3A3730", VA = "0x103A4930")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700101E")]
    public bool IsUnlockConceptCardSlot2
    {
      [Token(Token = "0x6007871"), Address(RVA = "0x3A4950", Offset = "0x3A3750", VA = "0x103A4950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700101F")]
    public bool IsUnlockTruthEquipment
    {
      [Token(Token = "0x6007872"), Address(RVA = "0x3A4A30", Offset = "0x3A3830", VA = "0x103A4A30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007873")]
    [Address(RVA = "0x3A4460", Offset = "0x3A3260", VA = "0x103A4460")]
    public void Deserialize(JSON_TobiraParam json)
    {
    }

    [Token(Token = "0x6007874")]
    [Address(RVA = "0x3A48C0", Offset = "0x3A36C0", VA = "0x103A48C0")]
    public TobiraParam()
    {
    }

    [Token(Token = "0x6007875")]
    [Address(RVA = "0x3A4890", Offset = "0x3A3690", VA = "0x103A4890")]
    static TobiraParam()
    {
    }

    [Token(Token = "0x2001D6A")]
    public enum Category
    {
      [Token(Token = "0x40073DF")] START = 0,
      [Token(Token = "0x40073E0")] Unlock = 0,
      [Token(Token = "0x40073E1")] Envy = 1,
      [Token(Token = "0x40073E2")] Wrath = 2,
      [Token(Token = "0x40073E3")] Sloth = 3,
      [Token(Token = "0x40073E4")] Lust = 4,
      [Token(Token = "0x40073E5")] Gluttony = 5,
      [Token(Token = "0x40073E6")] Greed = 6,
      [Token(Token = "0x40073E7")] Pride = 7,
      [Token(Token = "0x40073E8")] MAX = 8,
    }
  }
}
