// Decompiled with JetBrains decompiler
// Type: SRPG.JobParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E0E")]
  [MessagePackObject(true)]
  public class JobParam
  {
    [Token(Token = "0x40079FB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_JOB_RANK;
    [Token(Token = "0x40079FC")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40079FD")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40079FE")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40079FF")]
    [FieldOffset(Offset = "0x14")]
    public string model;
    [Token(Token = "0x4007A00")]
    [FieldOffset(Offset = "0x18")]
    public string ac2d;
    [Token(Token = "0x4007A01")]
    [FieldOffset(Offset = "0x1C")]
    public string modelp;
    [Token(Token = "0x4007A02")]
    [FieldOffset(Offset = "0x20")]
    public string pet;
    [Token(Token = "0x4007A03")]
    [FieldOffset(Offset = "0x24")]
    public string buki;
    [Token(Token = "0x4007A04")]
    [FieldOffset(Offset = "0x28")]
    public string origin;
    [Token(Token = "0x4007A05")]
    [FieldOffset(Offset = "0x2C")]
    public JobTypes type;
    [Token(Token = "0x4007A06")]
    [FieldOffset(Offset = "0x30")]
    public RoleTypes role;
    [Token(Token = "0x4007A07")]
    [FieldOffset(Offset = "0x34")]
    public OInt mov;
    [Token(Token = "0x4007A08")]
    [FieldOffset(Offset = "0x48")]
    public OInt jmp;
    [Token(Token = "0x4007A09")]
    [FieldOffset(Offset = "0x5C")]
    public string wepmdl;
    [Token(Token = "0x4007A0A")]
    [FieldOffset(Offset = "0x60")]
    public string[] atkskill;
    [Token(Token = "0x4007A0B")]
    [FieldOffset(Offset = "0x64")]
    public string artifact;
    [Token(Token = "0x4007A0C")]
    [FieldOffset(Offset = "0x68")]
    public string ai;
    [Token(Token = "0x4007A0D")]
    [FieldOffset(Offset = "0x6C")]
    public string master;
    [Token(Token = "0x4007A0E")]
    [FieldOffset(Offset = "0x70")]
    public string fixed_ability;
    [Token(Token = "0x4007A0F")]
    [FieldOffset(Offset = "0x74")]
    public string MapEffectAbility;
    [Token(Token = "0x4007A10")]
    [FieldOffset(Offset = "0x78")]
    public bool IsMapEffectRevReso;
    [Token(Token = "0x4007A11")]
    [FieldOffset(Offset = "0x7C")]
    public string DescCharacteristic;
    [Token(Token = "0x4007A12")]
    [FieldOffset(Offset = "0x80")]
    public string DescOther;
    [Token(Token = "0x4007A13")]
    [FieldOffset(Offset = "0x84")]
    public StatusParam status;
    [Token(Token = "0x4007A14")]
    [FieldOffset(Offset = "0x88")]
    public OInt avoid;
    [Token(Token = "0x4007A15")]
    [FieldOffset(Offset = "0x9C")]
    public OInt inimp;
    [Token(Token = "0x4007A16")]
    [FieldOffset(Offset = "0xB0")]
    public JobRankParam[] ranks;
    [Token(Token = "0x4007A17")]
    [FieldOffset(Offset = "0xB4")]
    public string unit_image;
    [Token(Token = "0x4007A18")]
    [FieldOffset(Offset = "0xB8")]
    private ArtifactParam m_DefaultArtifact;
    [Token(Token = "0x4007A19")]
    [FieldOffset(Offset = "0xBC")]
    public eMovType MovType;
    [Token(Token = "0x4007A1A")]
    [FieldOffset(Offset = "0xC0")]
    public string[] tags;
    [Token(Token = "0x4007A1B")]
    [FieldOffset(Offset = "0xC4")]
    public string buff;
    [Token(Token = "0x4007A1C")]
    [FieldOffset(Offset = "0xC8")]
    private BitArray mFlags;

    [Token(Token = "0x170010F3")]
    public ArtifactParam DefaultArtifact
    {
      [Token(Token = "0x6007B5C"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x170010F4")]
    public bool IsRiding
    {
      [Token(Token = "0x6007B5D"), Address(RVA = "0x3E16D0", Offset = "0x3E04D0", VA = "0x103E16D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010F5")]
    public bool IsFlyingPass
    {
      [Token(Token = "0x6007B5E"), Address(RVA = "0x3E16A0", Offset = "0x3E04A0", VA = "0x103E16A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007B5F")]
    [Address(RVA = "0x3E02C0", Offset = "0x3DF0C0", VA = "0x103E02C0")]
    public bool Deserialize(JSON_JobParam json, MasterParam master_param) => new bool();

    [Token(Token = "0x6007B60")]
    [Address(RVA = "0x3DFF90", Offset = "0x3DED90", VA = "0x103DFF90")]
    private void CreateBuffList(MasterParam master_param)
    {
    }

    [Token(Token = "0x6007B61")]
    [Address(RVA = "0x3E0EC0", Offset = "0x3DFCC0", VA = "0x103E0EC0")]
    public int GetJobChangeCost(int lv) => new int();

    [Token(Token = "0x6007B62")]
    [Address(RVA = "0x3E0F40", Offset = "0x3DFD40", VA = "0x103E0F40")]
    public string[] GetJobChangeItems(int lv) => (string[]) null;

    [Token(Token = "0x6007B63")]
    [Address(RVA = "0x3E0F00", Offset = "0x3DFD00", VA = "0x103E0F00")]
    public int[] GetJobChangeItemNums(int lv) => (int[]) null;

    [Token(Token = "0x6007B64")]
    [Address(RVA = "0x3E12B0", Offset = "0x3E00B0", VA = "0x103E12B0")]
    public int GetRankupCost(int lv) => new int();

    [Token(Token = "0x6007B65")]
    [Address(RVA = "0x3E1340", Offset = "0x3E0140", VA = "0x103E1340")]
    public string[] GetRankupItems(int lv) => (string[]) null;

    [Token(Token = "0x6007B66")]
    [Address(RVA = "0x3E12F0", Offset = "0x3E00F0", VA = "0x103E12F0")]
    public string GetRankupItemID(int lv, int index) => (string) null;

    [Token(Token = "0x6007B67")]
    [Address(RVA = "0x3E1270", Offset = "0x3E0070", VA = "0x103E1270")]
    public OString[] GetLearningAbilitys(int lv) => (OString[]) null;

    [Token(Token = "0x6007B68")]
    [Address(RVA = "0x3E0F80", Offset = "0x3DFD80", VA = "0x103E0F80")]
    public int GetJobRankAvoidRate(int lv) => new int();

    [Token(Token = "0x6007B69")]
    [Address(RVA = "0x3E1070", Offset = "0x3DFE70", VA = "0x103E1070")]
    public int GetJobRankInitJewelRate(int lv) => new int();

    [Token(Token = "0x6007B6A")]
    [Address(RVA = "0x3E10C0", Offset = "0x3DFEC0", VA = "0x103E10C0")]
    public StatusParam GetJobRankStatus(int lv) => (StatusParam) null;

    [Token(Token = "0x6007B6B")]
    [Address(RVA = "0x3E10F0", Offset = "0x3DFEF0", VA = "0x103E10F0")]
    public BaseStatus GetJobTransfarStatus(int lv, EElement element) => (BaseStatus) null;

    [Token(Token = "0x6007B6C")]
    [Address(RVA = "0x3E0FD0", Offset = "0x3DFDD0", VA = "0x103E0FD0")]
    public static int GetJobRankCap(int unitRarity) => new int();

    [Token(Token = "0x6007B6D")]
    [Address(RVA = "0x3E0C30", Offset = "0x3DFA30", VA = "0x103E0C30")]
    public int FindRankOfAbility(string abilityID) => new int();

    [Token(Token = "0x6007B6E")]
    [Address(RVA = "0x3E0D90", Offset = "0x3DFB90", VA = "0x103E0D90")]
    public List<string> GetAllLearningAbilitys() => (List<string>) null;

    [Token(Token = "0x6007B6F")]
    [Address(RVA = "0x3E1380", Offset = "0x3E0180", VA = "0x103E1380")]
    public static void UpdateCache(List<JobParam> jobParams)
    {
    }

    [Token(Token = "0x6007B70")]
    [Address(RVA = "0x3E14B0", Offset = "0x3E02B0", VA = "0x103E14B0")]
    private void UpdateDefaultArtifactCache(MasterParam master)
    {
    }

    [Token(Token = "0x6007B71")]
    [Address(RVA = "0x3E1530", Offset = "0x3E0330", VA = "0x103E1530")]
    public JobParam()
    {
    }

    [Token(Token = "0x6007B72")]
    [Address(RVA = "0x3E1500", Offset = "0x3E0300", VA = "0x103E1500")]
    static JobParam()
    {
    }

    [Token(Token = "0x2001E0F")]
    private enum eFlags
    {
      [Token(Token = "0x4007A1E")] RIDING,
      [Token(Token = "0x4007A1F")] FLYING_PASS,
      [Token(Token = "0x4007A20")] MAX,
    }
  }
}
