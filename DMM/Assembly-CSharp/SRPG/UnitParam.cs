// Decompiled with JetBrains decompiler
// Type: SRPG.UnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E8D")]
  [MessagePackObject(true)]
  public class UnitParam
  {
    [Token(Token = "0x4007ED3")]
    [FieldOffset(Offset = "0x0")]
    private static string[] UnitHourVoices;
    [Token(Token = "0x4007ED4")]
    [FieldOffset(Offset = "0x4")]
    public static int MASTER_QUEST_RARITY;
    [Token(Token = "0x4007ED5")]
    [FieldOffset(Offset = "0x8")]
    public static int MASTER_QUEST_LV;
    [Token(Token = "0x4007ED6")]
    [FieldOffset(Offset = "0xC")]
    public static string AI_TYPE_DEFAULT;
    [Token(Token = "0x4007ED7")]
    [FieldOffset(Offset = "0x8")]
    public FlagManager flag;
    [Token(Token = "0x4007ED8")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4007ED9")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007EDA")]
    [FieldOffset(Offset = "0x14")]
    public string model;
    [Token(Token = "0x4007EDB")]
    [FieldOffset(Offset = "0x18")]
    public OString birth;
    [Token(Token = "0x4007EDC")]
    [FieldOffset(Offset = "0x1C")]
    public int birthID;
    [Token(Token = "0x4007EDD")]
    [FieldOffset(Offset = "0x20")]
    public OString grow;
    [Token(Token = "0x4007EDE")]
    [FieldOffset(Offset = "0x24")]
    public string[] jobsets;
    [Token(Token = "0x4007EDF")]
    [FieldOffset(Offset = "0x28")]
    public string[] tags;
    [Token(Token = "0x4007EE0")]
    [FieldOffset(Offset = "0x2C")]
    public string piece;
    [Token(Token = "0x4007EE1")]
    [FieldOffset(Offset = "0x30")]
    public string subPiece;
    [Token(Token = "0x4007EE2")]
    [FieldOffset(Offset = "0x34")]
    public string ability;
    [Token(Token = "0x4007EE3")]
    [FieldOffset(Offset = "0x38")]
    public string ma_quest;
    [Token(Token = "0x4007EE4")]
    [FieldOffset(Offset = "0x3C")]
    public ESex sex;
    [Token(Token = "0x4007EE5")]
    [FieldOffset(Offset = "0x40")]
    public byte rare;
    [Token(Token = "0x4007EE6")]
    [FieldOffset(Offset = "0x41")]
    public byte raremax;
    [Token(Token = "0x4007EE7")]
    [FieldOffset(Offset = "0x44")]
    public EUnitType type;
    [Token(Token = "0x4007EE8")]
    [FieldOffset(Offset = "0x48")]
    public EElement element;
    [Token(Token = "0x4007EE9")]
    [FieldOffset(Offset = "0x49")]
    public byte sw;
    [Token(Token = "0x4007EEA")]
    [FieldOffset(Offset = "0x4A")]
    public byte sh;
    [Token(Token = "0x4007EEB")]
    [FieldOffset(Offset = "0x4B")]
    public byte sd;
    [Token(Token = "0x4007EEC")]
    [FieldOffset(Offset = "0x4C")]
    public string dbuki;
    [Token(Token = "0x4007EED")]
    [FieldOffset(Offset = "0x50")]
    public byte search;
    [Token(Token = "0x4007EEE")]
    [FieldOffset(Offset = "0x52")]
    public short height;
    [Token(Token = "0x4007EEF")]
    [FieldOffset(Offset = "0x54")]
    public short weight;
    [Token(Token = "0x4007EF0")]
    [FieldOffset(Offset = "0x58")]
    public DateTime available_at;
    [Token(Token = "0x4007EF1")]
    [FieldOffset(Offset = "0x60")]
    public string image;
    [Token(Token = "0x4007EF2")]
    [FieldOffset(Offset = "0x64")]
    public string voice;
    [Token(Token = "0x4007EF3")]
    [FieldOffset(Offset = "0x68")]
    public UnitParam.Status ini_status;
    [Token(Token = "0x4007EF4")]
    [FieldOffset(Offset = "0x6C")]
    public UnitParam.Status max_status;
    [Token(Token = "0x4007EF5")]
    [FieldOffset(Offset = "0x70")]
    public string[] leader_skills;
    [Token(Token = "0x4007EF6")]
    [FieldOffset(Offset = "0x74")]
    public string[] recipes;
    [Token(Token = "0x4007EF7")]
    [FieldOffset(Offset = "0x78")]
    public UnitParam.NoJobStatus no_job_status;
    [Token(Token = "0x4007EF8")]
    [FieldOffset(Offset = "0x7C")]
    public string[] skins;
    [Token(Token = "0x4007EF9")]
    [FieldOffset(Offset = "0x80")]
    private JobSetParam[] mJobSetCache;
    [Token(Token = "0x4007EFA")]
    [FieldOffset(Offset = "0x84")]
    public string unlock_time;
    [Token(Token = "0x4007EFB")]
    [FieldOffset(Offset = "0x88")]
    public string unit_piece_shop_group;
    [Token(Token = "0x4007EFC")]
    [FieldOffset(Offset = "0x8C")]
    private List<JobSetParam> mClassChangeJobSetCache;
    [Token(Token = "0x4007EFD")]
    [FieldOffset(Offset = "0x90")]
    private string truth_equipment_id;
    [Token(Token = "0x4007EFE")]
    [FieldOffset(Offset = "0x94")]
    private TruthEquipmentParam m_TruthEquipmentParam;
    [Token(Token = "0x4007EFF")]
    [FieldOffset(Offset = "0x98")]
    private int mElementPlus;
    [Token(Token = "0x4007F00")]
    [FieldOffset(Offset = "0x9C")]
    private string rune_pride_pattern;
    [Token(Token = "0x4007F01")]
    [FieldOffset(Offset = "0xA0")]
    private DateTime mIgnoreSerchTime;
    [Token(Token = "0x4007F02")]
    [FieldOffset(Offset = "0x10")]
    private static EElement[] WeakElements;
    [Token(Token = "0x4007F03")]
    [FieldOffset(Offset = "0x14")]
    private static EElement[] ResistElements;

    [Token(Token = "0x6007D36")]
    [Address(RVA = "0x3F3EB0", Offset = "0x3F2CB0", VA = "0x103F3EB0")]
    public bool IsHero() => new bool();

    [Token(Token = "0x6007D37")]
    [Address(RVA = "0x3F3F10", Offset = "0x3F2D10", VA = "0x103F3F10")]
    public bool IsSummon() => new bool();

    [Token(Token = "0x6007D38")]
    [Address(RVA = "0x3F3F20", Offset = "0x3F2D20", VA = "0x103F3F20")]
    public bool IsThrow() => new bool();

    [Token(Token = "0x6007D39")]
    [Address(RVA = "0x3F3ED0", Offset = "0x3F2CD0", VA = "0x103F3ED0")]
    public bool IsKnockBack() => new bool();

    [Token(Token = "0x6007D3A")]
    [Address(RVA = "0x3F3EA0", Offset = "0x3F2CA0", VA = "0x103F3EA0")]
    public bool IsChanging() => new bool();

    [Token(Token = "0x6007D3B")]
    [Address(RVA = "0x3F3EC0", Offset = "0x3F2CC0", VA = "0x103F3EC0")]
    public bool IsInspiration() => new bool();

    [Token(Token = "0x6007D3C")]
    [Address(RVA = "0x3F3EE0", Offset = "0x3F2CE0", VA = "0x103F3EE0")]
    public bool IsNoRecommended() => new bool();

    [Token(Token = "0x6007D3D")]
    [Address(RVA = "0x3F3EF0", Offset = "0x3F2CF0", VA = "0x103F3EF0")]
    public bool IsStopped() => new bool();

    [Token(Token = "0x1700117C")]
    public bool IsFlyingPass
    {
      [Token(Token = "0x6007D3E"), Address(RVA = "0x3F4950", Offset = "0x3F3750", VA = "0x103F4950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700117D")]
    public bool IsPlayableUnit
    {
      [Token(Token = "0x6007D3F"), Address(RVA = "0x3F4A40", Offset = "0x3F3840", VA = "0x103F4A40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700117E")]
    public bool IsHighElement
    {
      [Token(Token = "0x6007D40"), Address(RVA = "0x3F4970", Offset = "0x3F3770", VA = "0x103F4970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700117F")]
    public int ElementPlus
    {
      [Token(Token = "0x6007D41"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001180")]
    public bool IsIgnoreSerch
    {
      [Token(Token = "0x6007D42"), Address(RVA = "0x3F4990", Offset = "0x3F3790", VA = "0x103F4990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001181")]
    [IgnoreMember]
    public TruthEquipmentParam TruthEquipmentParam
    {
      [Token(Token = "0x6007D43"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (TruthEquipmentParam) null;
      }
    }

    [Token(Token = "0x17001182")]
    [IgnoreMember]
    public string TruthEquipmentIname
    {
      [Token(Token = "0x6007D44"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001183")]
    public string RunePridePattern
    {
      [Token(Token = "0x6007D45"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007D46")]
    [Address(RVA = "0x3F16D0", Offset = "0x3F04D0", VA = "0x103F16D0")]
    public void CacheReferences(MasterParam master)
    {
    }

    [Token(Token = "0x6007D47")]
    [Address(RVA = "0x3F3780", Offset = "0x3F2580", VA = "0x103F3780")]
    public JobSetParam GetJobSetFast(int index) => (JobSetParam) null;

    [Token(Token = "0x17001184")]
    public string SexPrefix
    {
      [Token(Token = "0x6007D48"), Address(RVA = "0x3F4A70", Offset = "0x3F3870", VA = "0x103F4A70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007D49")]
    [Address(RVA = "0x3F21B0", Offset = "0x3F0FB0", VA = "0x103F21B0")]
    public bool Deserialize(JSON_UnitParam json) => new bool();

    [Token(Token = "0x6007D4A")]
    [Address(RVA = "0x3F39D0", Offset = "0x3F27D0", VA = "0x103F39D0")]
    public RecipeParam GetRarityUpRecipe(int rarity) => (RecipeParam) null;

    [Token(Token = "0x6007D4B")]
    [Address(RVA = "0x2B8A30", Offset = "0x2B7830", VA = "0x102B8A30")]
    public static int GetLeaderSkillLevel(int rarity, int awakeLv) => new int();

    [Token(Token = "0x6007D4C")]
    [Address(RVA = "0x3F1A60", Offset = "0x3F0860", VA = "0x103F1A60")]
    public static void CalcUnitLevelStatus(UnitParam unit, int unitLv, ref BaseStatus status)
    {
    }

    [Token(Token = "0x6007D4D")]
    [Address(RVA = "0x3F1860", Offset = "0x3F0660", VA = "0x103F1860")]
    public static void CalcUnitElementStatus(EElement element, ref BaseStatus status)
    {
    }

    [Token(Token = "0x6007D4E")]
    [Address(RVA = "0x3F3B90", Offset = "0x3F2990", VA = "0x103F3B90")]
    public static EElement GetWeakElement(EElement type) => new EElement();

    [Token(Token = "0x6007D4F")]
    [Address(RVA = "0x3F3A90", Offset = "0x3F2890", VA = "0x103F3A90")]
    public static EElement GetResistElement(EElement type) => new EElement();

    [Token(Token = "0x6007D50")]
    [Address(RVA = "0x3F3440", Offset = "0x3F2240", VA = "0x103F3440")]
    public static string GetBirthplaceName(int birth_id) => (string) null;

    [Token(Token = "0x6007D51")]
    [Address(RVA = "0x3F3AF0", Offset = "0x3F28F0", VA = "0x103F3AF0")]
    public int GetUnlockNeedPieces() => new int();

    [Token(Token = "0x6007D52")]
    [Address(RVA = "0x3F1F90", Offset = "0x3F0D90", VA = "0x103F1F90")]
    public bool CheckEnableUnlock() => new bool();

    [Token(Token = "0x6007D53")]
    [Address(RVA = "0x3F1F30", Offset = "0x3F0D30", VA = "0x103F1F30")]
    public bool CheckAvailable(DateTime now) => new bool();

    [Token(Token = "0x6007D54")]
    [Address(RVA = "0x3F3720", Offset = "0x3F2520", VA = "0x103F3720")]
    public string GetJobVoice(string jobName) => (string) null;

    [Token(Token = "0x6007D55")]
    [Address(RVA = "0x3F3720", Offset = "0x3F2520", VA = "0x103F3720")]
    public string GetJobImage(string jobName) => (string) null;

    [Token(Token = "0x6007D56")]
    [Address(RVA = "0x3F3750", Offset = "0x3F2550", VA = "0x103F3750")]
    private string GetJobOptions(string jobName, bool isImage) => (string) null;

    [Token(Token = "0x6007D57")]
    [Address(RVA = "0x3F36C0", Offset = "0x3F24C0", VA = "0x103F36C0")]
    public string GetJobId(int jobIndex) => (string) null;

    [Token(Token = "0x17001185")]
    public bool IsNormalSize
    {
      [Token(Token = "0x6007D58"), Address(RVA = "0x3F4A20", Offset = "0x3F3820", VA = "0x103F4A20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007D59")]
    [Address(RVA = "0x2B6120", Offset = "0x2B4F20", VA = "0x102B6120")]
    public void SetClassChangeJobsetCache(List<JobSetParam> cache)
    {
    }

    [Token(Token = "0x6007D5A")]
    [Address(RVA = "0x3F3D60", Offset = "0x3F2B60", VA = "0x103F3D60")]
    public bool HasJobParam(string jobParamIname) => new bool();

    [Token(Token = "0x6007D5B")]
    [Address(RVA = "0x3F3BF0", Offset = "0x3F29F0", VA = "0x103F3BF0")]
    public bool HasArtifactByTag(string artifactTagName) => new bool();

    [Token(Token = "0x6007D5C")]
    [Address(RVA = "0x3F34E0", Offset = "0x3F22E0", VA = "0x103F34E0")]
    public static string GetCurrentHourVoice() => (string) null;

    [Token(Token = "0x6007D5D")]
    [Address(RVA = "0x3F37B0", Offset = "0x3F25B0", VA = "0x103F37B0")]
    public List<string> GetJobUpGradeList(string _jobset, JobSetParam[] _jobSetTargetList = null)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6007D5E")]
    [Address(RVA = "0x3F47E0", Offset = "0x3F35E0", VA = "0x103F47E0")]
    public UnitParam()
    {
    }

    [Token(Token = "0x6007D5F")]
    [Address(RVA = "0x3F3F30", Offset = "0x3F2D30", VA = "0x103F3F30")]
    static UnitParam()
    {
    }

    [Token(Token = "0x2001E8E")]
    private enum FLAG_TYPE
    {
      [Token(Token = "0x4007F05")] HERO,
      [Token(Token = "0x4007F06")] SUMMON,
      [Token(Token = "0x4007F07")] THROW,
      [Token(Token = "0x4007F08")] KNOCK_BACK,
      [Token(Token = "0x4007F09")] CHANGING,
      [Token(Token = "0x4007F0A")] INSP,
      [Token(Token = "0x4007F0B")] NORECOMMENDED,
      [Token(Token = "0x4007F0C")] FLYING_PASS,
      [Token(Token = "0x4007F0D")] HIGH_ELEMENT,
    }

    [Token(Token = "0x2001E8F")]
    [MessagePackObject(true)]
    public class Status
    {
      [Token(Token = "0x4007F0E")]
      [FieldOffset(Offset = "0x8")]
      public StatusParam param;
      [Token(Token = "0x4007F0F")]
      [FieldOffset(Offset = "0xC")]
      public EnchantParam enchant_resist;

      [Token(Token = "0x6007D60")]
      [Address(RVA = "0x3EFFB0", Offset = "0x3EEDB0", VA = "0x103EFFB0")]
      public void SetParamIni(JSON_UnitParam json)
      {
      }

      [Token(Token = "0x6007D61")]
      [Address(RVA = "0x3F0140", Offset = "0x3EEF40", VA = "0x103F0140")]
      public void SetParamMax(JSON_UnitParam json)
      {
      }

      [Token(Token = "0x6007D62")]
      [Address(RVA = "0x3EF430", Offset = "0x3EE230", VA = "0x103EF430")]
      public void SetEnchentParamIni(JSON_UnitParam json)
      {
      }

      [Token(Token = "0x6007D63")]
      [Address(RVA = "0x3EF0F0", Offset = "0x3EDEF0", VA = "0x103EF0F0")]
      private bool IsExistEnchentParamIni(JSON_UnitParam json) => new bool();

      [Token(Token = "0x6007D64")]
      [Address(RVA = "0x3EF9F0", Offset = "0x3EE7F0", VA = "0x103EF9F0")]
      public void SetEnchentParamMax(JSON_UnitParam json)
      {
      }

      [Token(Token = "0x6007D65")]
      [Address(RVA = "0x3EF290", Offset = "0x3EE090", VA = "0x103EF290")]
      private bool IsExistEnchentParamMax(JSON_UnitParam json) => new bool();

      [Token(Token = "0x6007D66")]
      [Address(RVA = "0x3EF070", Offset = "0x3EDE70", VA = "0x103EF070")]
      public BaseStatus CreateBaseStatus() => (BaseStatus) null;

      [Token(Token = "0x6007D67")]
      [Address(RVA = "0x3F02D0", Offset = "0x3EF0D0", VA = "0x103F02D0")]
      public Status()
      {
      }
    }

    [Token(Token = "0x2001E90")]
    [MessagePackObject(true)]
    public class NoJobStatus
    {
      [Token(Token = "0x4007F10")]
      [FieldOffset(Offset = "0x8")]
      public string default_skill;
      [Token(Token = "0x4007F11")]
      [FieldOffset(Offset = "0xC")]
      public JobTypes jobtype;
      [Token(Token = "0x4007F12")]
      [FieldOffset(Offset = "0x10")]
      public RoleTypes role;
      [Token(Token = "0x4007F13")]
      [FieldOffset(Offset = "0x14")]
      public byte mov;
      [Token(Token = "0x4007F14")]
      [FieldOffset(Offset = "0x15")]
      public byte jmp;
      [Token(Token = "0x4007F15")]
      [FieldOffset(Offset = "0x18")]
      public int inimp;

      [Token(Token = "0x6007D68")]
      [Address(RVA = "0x3EC380", Offset = "0x3EB180", VA = "0x103EC380")]
      public void SetParam(JSON_UnitParam json)
      {
      }

      [Token(Token = "0x6007D69")]
      [Address(RVA = "0x3EC330", Offset = "0x3EB130", VA = "0x103EC330")]
      public static bool IsExistParam(JSON_UnitParam json) => new bool();

      [Token(Token = "0x6007D6A")]
      [Address(RVA = "0x3EC3E0", Offset = "0x3EB1E0", VA = "0x103EC3E0")]
      public NoJobStatus()
      {
      }
    }
  }
}
