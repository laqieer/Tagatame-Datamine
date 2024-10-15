// Decompiled with JetBrains decompiler
// Type: SRPG.JobData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D81")]
  [MessagePackObject(true)]
  public class JobData
  {
    [Token(Token = "0x400E335")]
    public const int MAX_RANKUP_EQUIPS = 6;
    [Token(Token = "0x400E336")]
    public const int MAX_LARNING_ABILITY = 8;
    [Token(Token = "0x400E337")]
    public const int MAX_ABILITY_SLOT = 5;
    [Token(Token = "0x400E338")]
    [FieldOffset(Offset = "0x8")]
    private UnitData mOwner;
    [Token(Token = "0x400E339")]
    [FieldOffset(Offset = "0x10")]
    private long mUniqueID;
    [Token(Token = "0x400E33A")]
    [FieldOffset(Offset = "0x18")]
    private JobParam mJobParam;
    [Token(Token = "0x400E33B")]
    [FieldOffset(Offset = "0x1C")]
    private OInt mRank;
    [Token(Token = "0x400E33C")]
    [FieldOffset(Offset = "0x30")]
    private SkillData mNormalAttackSkill;
    [Token(Token = "0x400E33D")]
    [FieldOffset(Offset = "0x34")]
    private SkillData mJobMaster;
    [Token(Token = "0x400E33E")]
    [FieldOffset(Offset = "0x38")]
    private EquipData[] mEquips;
    [Token(Token = "0x400E33F")]
    [FieldOffset(Offset = "0x3C")]
    private List<AbilityData> mLearnAbilitys;
    [Token(Token = "0x400E340")]
    [FieldOffset(Offset = "0x0")]
    public static EAbilitySlot[] ABILITY_SLOT_TYPES;
    [Token(Token = "0x400E341")]
    [FieldOffset(Offset = "0x40")]
    private long[] mAbilitySlots;
    [Token(Token = "0x400E342")]
    [FieldOffset(Offset = "0x4")]
    public static ArtifactTypes[] ARTIFACT_SLOT_TYPES;
    [Token(Token = "0x400E343")]
    [FieldOffset(Offset = "0x44")]
    private long[] mArtifacts;
    [Token(Token = "0x400E344")]
    [FieldOffset(Offset = "0x48")]
    private ArtifactData[] mArtifactDatas;
    [Token(Token = "0x400E345")]
    [FieldOffset(Offset = "0x4C")]
    private string mSelectSkin;
    [Token(Token = "0x400E346")]
    [FieldOffset(Offset = "0x50")]
    private ArtifactData mSelectSkinData;

    [Token(Token = "0x600D46D")]
    [Address(RVA = "0xA48520", Offset = "0xA47320", VA = "0x10A48520")]
    public static int GetArtifactSlotIndex(ArtifactTypes type) => new int();

    [Token(Token = "0x17001BD7")]
    public UnitData Owner
    {
      [Token(Token = "0x600D46E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001BD8")]
    public JobParam Param
    {
      [Token(Token = "0x600D46F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (JobParam) null;
      }
    }

    [Token(Token = "0x17001BD9")]
    public long UniqueID
    {
      [Token(Token = "0x600D470"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x600D471"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] set
      {
      }
    }

    [Token(Token = "0x17001BDA")]
    public string JobID
    {
      [Token(Token = "0x600D472"), Address(RVA = "0xA49DF0", Offset = "0xA48BF0", VA = "0x10A49DF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001BDB")]
    public string Name
    {
      [Token(Token = "0x600D473"), Address(RVA = "0x3C1AD0", Offset = "0x3C08D0", VA = "0x103C1AD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001BDC")]
    public int Rank
    {
      [Token(Token = "0x600D474"), Address(RVA = "0xA49E80", Offset = "0xA48C80", VA = "0x10A49E80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BDD")]
    public JobTypes JobType
    {
      [Token(Token = "0x600D475"), Address(RVA = "0xA49E60", Offset = "0xA48C60", VA = "0x10A49E60")] get
      {
        return new JobTypes();
      }
    }

    [Token(Token = "0x17001BDE")]
    public RoleTypes RoleType
    {
      [Token(Token = "0x600D476"), Address(RVA = "0xA49EB0", Offset = "0xA48CB0", VA = "0x10A49EB0")] get
      {
        return new RoleTypes();
      }
    }

    [Token(Token = "0x17001BDF")]
    public string JobResourceID
    {
      [Token(Token = "0x600D477"), Address(RVA = "0xA49E40", Offset = "0xA48C40", VA = "0x10A49E40")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001BE0")]
    public EquipData[] Equips
    {
      [Token(Token = "0x600D478"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (EquipData[]) null;
      }
    }

    [Token(Token = "0x17001BE1")]
    public List<AbilityData> LearnAbilitys
    {
      [Token(Token = "0x600D479"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17001BE2")]
    public long[] AbilitySlots
    {
      [Token(Token = "0x600D47A"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (long[]) null;
      }
    }

    [Token(Token = "0x17001BE3")]
    public long[] Artifacts
    {
      [Token(Token = "0x600D47B"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (long[]) null;
      }
    }

    [Token(Token = "0x17001BE4")]
    public ArtifactData[] ArtifactDatas
    {
      [Token(Token = "0x600D47C"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (ArtifactData[]) null;
      }
    }

    [Token(Token = "0x600D47D")]
    [Address(RVA = "0xA47770", Offset = "0xA46570", VA = "0x10A47770")]
    public void CopyToArtifacts(ArtifactData[] _data)
    {
    }

    [Token(Token = "0x17001BE5")]
    public string SelectedSkin
    {
      [Token(Token = "0x600D47E"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600D47F"), Address(RVA = "0x2B4CC0", Offset = "0x2B3AC0", VA = "0x102B4CC0")] set
      {
      }
    }

    [Token(Token = "0x17001BE6")]
    public ArtifactData SelectSkinData
    {
      [Token(Token = "0x600D480"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return (ArtifactData) null;
      }
      [Token(Token = "0x600D481"), Address(RVA = "0x6855E0", Offset = "0x6843E0", VA = "0x106855E0")] set
      {
      }
    }

    [Token(Token = "0x17001BE7")]
    public bool IsActivated
    {
      [Token(Token = "0x600D482"), Address(RVA = "0xA49DC0", Offset = "0xA48BC0", VA = "0x10A49DC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001BE8")]
    public SkillData JobMaster
    {
      [Token(Token = "0x600D483"), Address(RVA = "0xA49E10", Offset = "0xA48C10", VA = "0x10A49E10")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x600D484")]
    [Address(RVA = "0xA49BE0", Offset = "0xA489E0", VA = "0x10A49BE0")]
    public JobData()
    {
    }

    [Token(Token = "0x600D485")]
    [Address(RVA = "0xA47800", Offset = "0xA46600", VA = "0x10A47800")]
    public void Deserialize(UnitData owner, Json_Job json)
    {
    }

    [Token(Token = "0x600D486")]
    [Address(RVA = "0xA49A90", Offset = "0xA48890", VA = "0x10A49A90")]
    public void UnlockSkillAll()
    {
    }

    [Token(Token = "0x600D487")]
    [Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")]
    public SkillData GetAttackSkill() => (SkillData) null;

    [Token(Token = "0x600D488")]
    [Address(RVA = "0xA486B0", Offset = "0xA474B0", VA = "0x10A486B0")]
    public int GetJobRankAvoidRate() => new int();

    [Token(Token = "0x600D489")]
    [Address(RVA = "0xA486F0", Offset = "0xA474F0", VA = "0x10A486F0")]
    public int GetJobRankAvoidRate(int rank) => new int();

    [Token(Token = "0x600D48A")]
    [Address(RVA = "0xA48780", Offset = "0xA47580", VA = "0x10A48780")]
    public int GetJobRankInitJewelRate() => new int();

    [Token(Token = "0x600D48B")]
    [Address(RVA = "0xA487C0", Offset = "0xA475C0", VA = "0x10A487C0")]
    public int GetJobRankInitJewelRate(int rank) => new int();

    [Token(Token = "0x600D48C")]
    [Address(RVA = "0xA487F0", Offset = "0xA475F0", VA = "0x10A487F0")]
    public StatusParam GetJobRankStatus() => (StatusParam) null;

    [Token(Token = "0x600D48D")]
    [Address(RVA = "0xA48830", Offset = "0xA47630", VA = "0x10A48830")]
    public StatusParam GetJobRankStatus(int rank) => (StatusParam) null;

    [Token(Token = "0x600D48E")]
    [Address(RVA = "0xA48890", Offset = "0xA47690", VA = "0x10A48890")]
    public BaseStatus GetJobTransfarStatus(EElement element) => (BaseStatus) null;

    [Token(Token = "0x600D48F")]
    [Address(RVA = "0xA48860", Offset = "0xA47660", VA = "0x10A48860")]
    public BaseStatus GetJobTransfarStatus(int rank, EElement element) => (BaseStatus) null;

    [Token(Token = "0x600D490")]
    [Address(RVA = "0xA488E0", Offset = "0xA476E0", VA = "0x10A488E0")]
    public OString[] GetLearningAbilitys(int rank) => (OString[]) null;

    [Token(Token = "0x600D491")]
    [Address(RVA = "0xA48620", Offset = "0xA47420", VA = "0x10A48620")]
    public int GetJobChangeCost(int rank) => new int();

    [Token(Token = "0x600D492")]
    [Address(RVA = "0xA48680", Offset = "0xA47480", VA = "0x10A48680")]
    public string[] GetJobChangeItems(int rank) => (string[]) null;

    [Token(Token = "0x600D493")]
    [Address(RVA = "0xA48650", Offset = "0xA47450", VA = "0x10A48650")]
    public int[] GetJobChangeItemNums(int rank) => (int[]) null;

    [Token(Token = "0x600D494")]
    [Address(RVA = "0xA48910", Offset = "0xA47710", VA = "0x10A48910")]
    public int GetRankupCost(int rank) => new int();

    [Token(Token = "0x600D495")]
    [Address(RVA = "0xA48970", Offset = "0xA47770", VA = "0x10A48970")]
    public string[] GetRankupItems(int rank) => (string[]) null;

    [Token(Token = "0x600D496")]
    [Address(RVA = "0xA48940", Offset = "0xA47740", VA = "0x10A48940")]
    public string GetRankupItemID(int rank, int index) => (string) null;

    [Token(Token = "0x600D497")]
    [Address(RVA = "0xA48420", Offset = "0xA47220", VA = "0x10A48420")]
    public int FindEquipSlotByItemID(string iname) => new int();

    [Token(Token = "0x600D498")]
    [Address(RVA = "0xA47260", Offset = "0xA46060", VA = "0x10A47260")]
    public bool CheckEnableEquipSlot(int index) => new bool();

    [Token(Token = "0x600D499")]
    [Address(RVA = "0xA482D0", Offset = "0xA470D0", VA = "0x10A482D0")]
    public bool Equip(int index) => new bool();

    [Token(Token = "0x600D49A")]
    [Address(RVA = "0xA48FB0", Offset = "0xA47DB0", VA = "0x10A48FB0")]
    public void JobRankUp()
    {
    }

    [Token(Token = "0x600D49B")]
    [Address(RVA = "0xA48720", Offset = "0xA47520", VA = "0x10A48720")]
    public int GetJobRankCap(UnitData self) => new int();

    [Token(Token = "0x600D49C")]
    [Address(RVA = "0xA475F0", Offset = "0xA463F0", VA = "0x10A475F0")]
    public bool CheckJobRankUp(UnitData self, bool canCreate = false, bool useCommon = true)
    {
      return new bool();
    }

    [Token(Token = "0x600D49D")]
    [Address(RVA = "0xA47400", Offset = "0xA46200", VA = "0x10A47400")]
    public bool[] CheckJobEquip(UnitData self) => (bool[]) null;

    [Token(Token = "0x600D49E")]
    [Address(RVA = "0xA484A0", Offset = "0xA472A0", VA = "0x10A484A0")]
    public void GetAllEquipOnly(
      ref int cost,
      ref Dictionary<string, int> equips,
      ref Dictionary<string, int> consumes,
      ref int target_rank,
      ref bool can_jobmaster,
      ref bool can_jobmax,
      NeedEquipItemList item_list = null,
      bool all = false)
    {
    }

    [Token(Token = "0x600D49F")]
    [Address(RVA = "0xA47160", Offset = "0xA45F60", VA = "0x10A47160")]
    public bool CanAllEquip(
      ref int cost,
      ref Dictionary<string, int> equips,
      ref Dictionary<string, int> consumes,
      ref int target_rank,
      ref bool can_jobmaster,
      ref bool can_jobmax,
      ref NeedEquipItemList item_list,
      bool all = false,
      bool isUseCommon = false)
    {
      return new bool();
    }

    [Token(Token = "0x600D4A0")]
    [Address(RVA = "0xA47200", Offset = "0xA46000", VA = "0x10A47200")]
    public bool CanAllEquip(
      ref int cost,
      ref Dictionary<string, int> equips,
      ref Dictionary<string, int> consumes,
      NeedEquipItemList item_list = null)
    {
      return new bool();
    }

    [Token(Token = "0x600D4A1")]
    [Address(RVA = "0xA485C0", Offset = "0xA473C0", VA = "0x10A485C0")]
    public int GetEnableEquipUnitLevel(int slot) => new int();

    [Token(Token = "0x600D4A2")]
    [Address(RVA = "0xA49710", Offset = "0xA48510", VA = "0x10A49710")]
    public void SetAbilitySlot(int slot, AbilityData ability)
    {
    }

    [Token(Token = "0x600D4A3")]
    [Address(RVA = "0xA49850", Offset = "0xA48650", VA = "0x10A49850")]
    public bool SetEquipArtifact(int slot, ArtifactData artifact, bool is_force = false)
    {
      return new bool();
    }

    [Token(Token = "0x600D4A4")]
    [Address(RVA = "0xA47300", Offset = "0xA46100", VA = "0x10A47300")]
    public bool CheckEquipArtifact(int slot, ArtifactData artifact) => new bool();

    [Token(Token = "0x600D4A5")]
    [Address(RVA = "0xA48EF0", Offset = "0xA47CF0", VA = "0x10A48EF0")]
    public bool IsEquipArtifact(long iid) => new bool();

    [Token(Token = "0x600D4A6")]
    [Address(RVA = "0xA489A0", Offset = "0xA477A0", VA = "0x10A489A0")]
    public ArtifactData GetSelectedSkinData() => (ArtifactData) null;

    [Token(Token = "0x600D4A7")]
    [Address(RVA = "0xA48B30", Offset = "0xA47930", VA = "0x10A48B30")]
    public List<ArtifactData> GetSortArifactData() => (List<ArtifactData>) null;

    [Token(Token = "0x600D4A8")]
    [Address(RVA = "0xA474C0", Offset = "0xA462C0", VA = "0x10A474C0")]
    public bool CheckJobMaster() => new bool();

    [Token(Token = "0x600D4A9")]
    [Address(RVA = "0xA46FF0", Offset = "0xA45DF0", VA = "0x10A46FF0")]
    public void AddJobBaseStatus(
      UnitData self,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus)
    {
    }

    [Token(Token = "0x600D4AA")]
    [Address(RVA = "0xA49B20", Offset = "0xA48920", VA = "0x10A49B20")]
    static JobData()
    {
    }

    [Token(Token = "0x2002D82")]
    public enum eAbilitySlotIndex
    {
      [Token(Token = "0x400E348")] Fixed = 0,
      [Token(Token = "0x400E349")] Base = 1,
      [Token(Token = "0x400E34A")] MAX = 5,
    }

    [Token(Token = "0x2002D83")]
    public enum EArtifactSlotIndex
    {
      [Token(Token = "0x400E34C")] SLOT_1,
      [Token(Token = "0x400E34D")] SLOT_2,
      [Token(Token = "0x400E34E")] SLOT_3,
      [Token(Token = "0x400E34F")] MAX,
    }
  }
}
