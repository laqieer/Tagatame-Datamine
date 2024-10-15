// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001990")]
  [MessagePackObject(true)]
  public class ArtifactParam
  {
    [Token(Token = "0x4005D5D")]
    private const string ARTIFACT_EXPR_PREFIX = "_EXPR";
    [Token(Token = "0x4005D5E")]
    private const string ARTIFACT_FLAVOR_PREFIX = "_FLAVOR";
    [Token(Token = "0x4005D5F")]
    private const string ARTIFACT_ILLUSTRATOR_PREFIX = "_ILLUST";
    [Token(Token = "0x4005D60")]
    private const string ARTIFACT_FILTER_KEYWORD_PREFIX = "_FILTER_KEYWORD";
    [Token(Token = "0x4005D61")]
    public const int ARTIFACT_RARITY_MAX = 4;
    [Token(Token = "0x4005D62")]
    public const int ARTIFACT_DRILLING_MAX = 999;
    [Token(Token = "0x4005D63")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005D64")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4005D65")]
    [FieldOffset(Offset = "0x10")]
    public string spec;
    [Token(Token = "0x4005D66")]
    [FieldOffset(Offset = "0x14")]
    public string asset;
    [Token(Token = "0x4005D67")]
    [FieldOffset(Offset = "0x18")]
    public string voice;
    [Token(Token = "0x4005D68")]
    [FieldOffset(Offset = "0x1C")]
    public string icon;
    [Token(Token = "0x4005D69")]
    [FieldOffset(Offset = "0x20")]
    public ArtifactTypes type;
    [Token(Token = "0x4005D6A")]
    [FieldOffset(Offset = "0x24")]
    public int rareini;
    [Token(Token = "0x4005D6B")]
    [FieldOffset(Offset = "0x28")]
    public int raremax;
    [Token(Token = "0x4005D6C")]
    [FieldOffset(Offset = "0x2C")]
    public string kakera;
    [Token(Token = "0x4005D6D")]
    [FieldOffset(Offset = "0x30")]
    public bool is_create;
    [Token(Token = "0x4005D6E")]
    [FieldOffset(Offset = "0x34")]
    public int maxnum;
    [Token(Token = "0x4005D6F")]
    [FieldOffset(Offset = "0x38")]
    public string skill;
    [Token(Token = "0x4005D70")]
    [FieldOffset(Offset = "0x3C")]
    public int kcoin;
    [Token(Token = "0x4005D71")]
    [FieldOffset(Offset = "0x40")]
    public int tcoin;
    [Token(Token = "0x4005D72")]
    [FieldOffset(Offset = "0x44")]
    public int acoin;
    [Token(Token = "0x4005D73")]
    [FieldOffset(Offset = "0x48")]
    public int mcoin;
    [Token(Token = "0x4005D74")]
    [FieldOffset(Offset = "0x4C")]
    public int pcoin;
    [Token(Token = "0x4005D75")]
    [FieldOffset(Offset = "0x50")]
    public int buy;
    [Token(Token = "0x4005D76")]
    [FieldOffset(Offset = "0x54")]
    public int sell;
    [Token(Token = "0x4005D77")]
    [FieldOffset(Offset = "0x58")]
    public int enhance_cost;
    [Token(Token = "0x4005D78")]
    [FieldOffset(Offset = "0x5C")]
    public string[] skills;
    [Token(Token = "0x4005D79")]
    [FieldOffset(Offset = "0x60")]
    public string[] equip_effects;
    [Token(Token = "0x4005D7A")]
    [FieldOffset(Offset = "0x64")]
    public string[] attack_effects;
    [Token(Token = "0x4005D7B")]
    [FieldOffset(Offset = "0x68")]
    public string[] abil_inames;
    [Token(Token = "0x4005D7C")]
    [FieldOffset(Offset = "0x6C")]
    public string[] abil_conds;
    [Token(Token = "0x4005D7D")]
    [FieldOffset(Offset = "0x70")]
    public int[] abil_levels;
    [Token(Token = "0x4005D7E")]
    [FieldOffset(Offset = "0x74")]
    public int[] abil_rareties;
    [Token(Token = "0x4005D7F")]
    [FieldOffset(Offset = "0x78")]
    public int[] abil_shows;
    [Token(Token = "0x4005D80")]
    [FieldOffset(Offset = "0x7C")]
    public string tag;
    [Token(Token = "0x4005D81")]
    [FieldOffset(Offset = "0x80")]
    public int condition_lv;
    [Token(Token = "0x4005D82")]
    [FieldOffset(Offset = "0x84")]
    public string[] condition_units;
    [Token(Token = "0x4005D83")]
    [FieldOffset(Offset = "0x88")]
    public string[] condition_jobs;
    [Token(Token = "0x4005D84")]
    [FieldOffset(Offset = "0x8C")]
    public string condition_birth;
    [Token(Token = "0x4005D85")]
    [FieldOffset(Offset = "0x90")]
    public ESex condition_sex;
    [Token(Token = "0x4005D86")]
    [FieldOffset(Offset = "0x94")]
    public EElement condition_element;
    [Token(Token = "0x4005D87")]
    [FieldOffset(Offset = "0x98")]
    public int condition_raremin;
    [Token(Token = "0x4005D88")]
    [FieldOffset(Offset = "0x9C")]
    public int condition_raremax;
    [Token(Token = "0x4005D89")]
    [FieldOffset(Offset = "0xA0")]
    public int CachedKakeraCount;
    [Token(Token = "0x4005D8A")]
    [FieldOffset(Offset = "0xA4")]
    public string CondSkillMotion;
    [Token(Token = "0x4005D8B")]
    [FieldOffset(Offset = "0xA8")]
    public int skin_hide;
    [Token(Token = "0x4005D8C")]
    [FieldOffset(Offset = "0xAC")]
    public string insp_skill;
    [Token(Token = "0x4005D8D")]
    [FieldOffset(Offset = "0xB0")]
    public int insp_lv_bonus;
    [Token(Token = "0x4005D8E")]
    [FieldOffset(Offset = "0xB4")]
    public GalleryVisibilityType gallery_view;
    [Token(Token = "0x4005D8F")]
    [FieldOffset(Offset = "0xB8")]
    public bool stone_no_open;
    [Token(Token = "0x4005D90")]
    [FieldOffset(Offset = "0xB9")]
    public bool stone_no_ch;
    [Token(Token = "0x4005D91")]
    [FieldOffset(Offset = "0xBC")]
    public int[] stone_conversion_item_count_list;
    [Token(Token = "0x4005D92")]
    [FieldOffset(Offset = "0xC0")]
    private SkillMotionParam m_SkillMotionParam;
    [Token(Token = "0x4005D93")]
    [FieldOffset(Offset = "0x0")]
    private static BaseStatus WorkScaleStatus;

    [Token(Token = "0x17000ACE")]
    public int Rarity
    {
      [Token(Token = "0x6006822"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ACF")]
    [IgnoreMember]
    public string Expr
    {
      [Token(Token = "0x6006823"), Address(RVA = "0x321070", Offset = "0x31FE70", VA = "0x10321070")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AD0")]
    [IgnoreMember]
    public string Flavor
    {
      [Token(Token = "0x6006824"), Address(RVA = "0x321130", Offset = "0x31FF30", VA = "0x10321130")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AD1")]
    [IgnoreMember]
    public string Illustrator
    {
      [Token(Token = "0x6006825"), Address(RVA = "0x3211B0", Offset = "0x31FFB0", VA = "0x103211B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AD2")]
    [IgnoreMember]
    public string FilterKeyword
    {
      [Token(Token = "0x6006826"), Address(RVA = "0x3210D0", Offset = "0x31FED0", VA = "0x103210D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AD3")]
    [IgnoreMember]
    public bool HasAbility
    {
      [Token(Token = "0x6006827"), Address(RVA = "0x321190", Offset = "0x31FF90", VA = "0x10321190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AD4")]
    public int[] StoneConversionItemCountList
    {
      [Token(Token = "0x6006828"), Address(RVA = "0x321210", Offset = "0x320010", VA = "0x10321210")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x6006829")]
    [Address(RVA = "0x320B10", Offset = "0x31F910", VA = "0x10320B10")]
    public int GetStoneConversionItemCount(int rarity) => new int();

    [Token(Token = "0x600682A")]
    [Address(RVA = "0x320E80", Offset = "0x31FC80", VA = "0x10320E80")]
    public bool IsExchangeStoneConversion(int rarity) => new bool();

    [Token(Token = "0x600682B")]
    [Address(RVA = "0x31FDB0", Offset = "0x31EBB0", VA = "0x1031FDB0")]
    public bool Deserialize(JSON_ArtifactParam json) => new bool();

    [Token(Token = "0x600682C")]
    [Address(RVA = "0x31F960", Offset = "0x31E760", VA = "0x1031F960")]
    public bool CheckEnableEquip(UnitData self, int jobIndex = -1) => new bool();

    [Token(Token = "0x600682D")]
    [Address(RVA = "0x3208D0", Offset = "0x31F6D0", VA = "0x103208D0")]
    public int GetBuyNum(ESaleType type) => new int();

    [Token(Token = "0x600682E")]
    [Address(RVA = "0x320BE0", Offset = "0x31F9E0", VA = "0x10320BE0")]
    public string GetText(string table, string key) => (string) null;

    [Token(Token = "0x600682F")]
    [Address(RVA = "0x320DC0", Offset = "0x31FBC0", VA = "0x10320DC0")]
    public static bool IsDetachableArtifact(JSON_ArtifactParam param) => new bool();

    [Token(Token = "0x6006830")]
    [Address(RVA = "0x320D00", Offset = "0x31FB00", VA = "0x10320D00")]
    public static bool IsDetachableArtifact(ArtifactParam param) => new bool();

    [Token(Token = "0x6006831")]
    [Address(RVA = "0x320C80", Offset = "0x31FA80", VA = "0x10320C80")]
    public static bool IsDetachableArtifact(string _icon) => new bool();

    [Token(Token = "0x6006832")]
    [Address(RVA = "0x320940", Offset = "0x31F740", VA = "0x10320940")]
    public void GetHomePassiveBuffStatus(
      ref BaseStatus fixed_status,
      ref BaseStatus scale_status,
      UnitData user = null,
      int job_index = 0,
      bool bCheckCondition = true)
    {
    }

    [Token(Token = "0x6006833")]
    [Address(RVA = "0x320FD0", Offset = "0x31FDD0", VA = "0x10320FD0")]
    public ArtifactParam()
    {
    }

    [Token(Token = "0x6006834")]
    [Address(RVA = "0x320F60", Offset = "0x31FD60", VA = "0x10320F60")]
    static ArtifactParam()
    {
    }
  }
}
