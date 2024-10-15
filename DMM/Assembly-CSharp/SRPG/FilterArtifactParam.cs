// Decompiled with JetBrains decompiler
// Type: SRPG.FilterArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D29")]
  public class FilterArtifactParam
  {
    [Token(Token = "0x400725E")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400725F")]
    [FieldOffset(Offset = "0xC")]
    private string mTabName;
    [Token(Token = "0x4007260")]
    [FieldOffset(Offset = "0x10")]
    private string mName;
    [Token(Token = "0x4007261")]
    [FieldOffset(Offset = "0x14")]
    private string mSubName;
    [Token(Token = "0x4007262")]
    [FieldOffset(Offset = "0x18")]
    private FilterArtifactParam.eCategorytype mCategorytype;
    [Token(Token = "0x4007263")]
    [FieldOffset(Offset = "0x1C")]
    private FilterArtifactParam.Condition[] mConds;

    [Token(Token = "0x17000FCD")]
    public string Iname
    {
      [Token(Token = "0x6007793"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FCE")]
    public string TabName
    {
      [Token(Token = "0x6007794"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FCF")]
    public string Name
    {
      [Token(Token = "0x6007795"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FD0")]
    public string SubName
    {
      [Token(Token = "0x6007796"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FD1")]
    public FilterArtifactParam.eCategorytype Categorytype
    {
      [Token(Token = "0x6007797"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new FilterArtifactParam.eCategorytype();
      }
    }

    [Token(Token = "0x17000FD2")]
    public List<FilterArtifactParam.Condition> CondList
    {
      [Token(Token = "0x6007798"), Address(RVA = "0x3900F0", Offset = "0x38EEF0", VA = "0x103900F0")] get
      {
        return (List<FilterArtifactParam.Condition>) null;
      }
    }

    [Token(Token = "0x6007799")]
    [Address(RVA = "0x38FCA0", Offset = "0x38EAA0", VA = "0x1038FCA0")]
    public void Deserialize(JSON_FilterArtifactParam json)
    {
    }

    [Token(Token = "0x600779A")]
    [Address(RVA = "0x38FE40", Offset = "0x38EC40", VA = "0x1038FE40")]
    public static void Deserialize(JSON_FilterArtifactParam[] json, ref FilterArtifactParam[] array)
    {
    }

    [Token(Token = "0x600779B")]
    [Address(RVA = "0x38FF50", Offset = "0x38ED50", VA = "0x1038FF50")]
    public static FilterArtifactParam GetParam(string key) => (FilterArtifactParam) null;

    [Token(Token = "0x600779C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterArtifactParam()
    {
    }

    [Token(Token = "0x2001D2A")]
    public enum eCategorytype
    {
      [Token(Token = "0x4007265")] None,
      [Token(Token = "0x4007266")] Rarity,
      [Token(Token = "0x4007267")] EquipType,
      [Token(Token = "0x4007268")] ArmsType,
      [Token(Token = "0x4007269")] Paramater,
      [Token(Token = "0x400726A")] Other,
    }

    [Token(Token = "0x2001D2B")]
    public enum eFilterType
    {
      [Token(Token = "0x400726C")] None,
      [Token(Token = "0x400726D")] Rarity,
      [Token(Token = "0x400726E")] EquipType,
      [Token(Token = "0x400726F")] ArmsType,
      [Token(Token = "0x4007270")] WeaponParam,
      [Token(Token = "0x4007271")] Favorite,
      [Token(Token = "0x4007272")] Equipment,
      [Token(Token = "0x4007273")] WeaponAbility,
      [Token(Token = "0x4007274")] InspratinoSkill,
    }

    [Token(Token = "0x2001D2C")]
    public class Condition
    {
      [Token(Token = "0x4007275")]
      [FieldOffset(Offset = "0x8")]
      private FilterArtifactParam mParent;
      [Token(Token = "0x4007276")]
      [FieldOffset(Offset = "0xC")]
      private FilterArtifactParam.eFilterType mFilterType;
      [Token(Token = "0x4007277")]
      [FieldOffset(Offset = "0x10")]
      private string mCndsName;
      [Token(Token = "0x4007278")]
      [FieldOffset(Offset = "0x14")]
      private string mName;
      [Token(Token = "0x4007279")]
      [FieldOffset(Offset = "0x18")]
      private int mRarity;
      [Token(Token = "0x400727A")]
      [FieldOffset(Offset = "0x1C")]
      private ArtifactTypes mEquipType;
      [Token(Token = "0x400727B")]
      [FieldOffset(Offset = "0x20")]
      private string[] mArmsType;
      [Token(Token = "0x400727C")]
      [FieldOffset(Offset = "0x24")]
      private ParamTypes[] mParamTypes;
      [Token(Token = "0x400727D")]
      [FieldOffset(Offset = "0x28")]
      private bool mIsHave;

      [Token(Token = "0x17000FD3")]
      public FilterArtifactParam.eFilterType FilterType
      {
        [Token(Token = "0x600779D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new FilterArtifactParam.eFilterType();
        }
      }

      [Token(Token = "0x17000FD4")]
      public string CndsName
      {
        [Token(Token = "0x600779E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000FD5")]
      public string Name
      {
        [Token(Token = "0x600779F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000FD6")]
      public int Rarity
      {
        [Token(Token = "0x60077A0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000FD7")]
      public ArtifactTypes EquipType
      {
        [Token(Token = "0x60077A1"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new ArtifactTypes();
        }
      }

      [Token(Token = "0x17000FD8")]
      public string[] ArmsType
      {
        [Token(Token = "0x60077A2"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (string[]) null;
        }
      }

      [Token(Token = "0x17000FD9")]
      public ParamTypes[] ParamTypes
      {
        [Token(Token = "0x60077A3"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return (ParamTypes[]) null;
        }
      }

      [Token(Token = "0x17000FDA")]
      public bool IsHave
      {
        [Token(Token = "0x60077A4"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17000FDB")]
      public string PrefsKey
      {
        [Token(Token = "0x60077A5"), Address(RVA = "0x38FAA0", Offset = "0x38E8A0", VA = "0x1038FAA0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60077A6")]
      [Address(RVA = "0x38F940", Offset = "0x38E740", VA = "0x1038F940")]
      public void Deserialize(FilterArtifactParam parent, JSON_FilterArtifactParam.Condition json)
      {
      }

      [Token(Token = "0x60077A7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Condition()
      {
      }
    }
  }
}
