// Decompiled with JetBrains decompiler
// Type: SRPG.EquipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D80")]
  [MessagePackObject(true)]
  public class EquipData
  {
    [Token(Token = "0x400E32E")]
    [FieldOffset(Offset = "0x8")]
    private long mUniqueID;
    [Token(Token = "0x400E32F")]
    [FieldOffset(Offset = "0x10")]
    private ItemParam mItemParam;
    [Token(Token = "0x400E330")]
    [FieldOffset(Offset = "0x14")]
    private RarityParam mRarityParam;
    [Token(Token = "0x400E331")]
    [FieldOffset(Offset = "0x18")]
    private int mExp;
    [Token(Token = "0x400E332")]
    [FieldOffset(Offset = "0x1C")]
    private int mRank;
    [Token(Token = "0x400E333")]
    [FieldOffset(Offset = "0x20")]
    private SkillData mSkill;
    [Token(Token = "0x400E334")]
    [FieldOffset(Offset = "0x24")]
    private bool mEquiped;

    [Token(Token = "0x17001BCE")]
    public long UniqueID
    {
      [Token(Token = "0x600D44F"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001BCF")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x600D450"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17001BD0")]
    public RarityParam RarityParam
    {
      [Token(Token = "0x600D451"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (RarityParam) null;
      }
    }

    [Token(Token = "0x17001BD1")]
    public string ItemID
    {
      [Token(Token = "0x600D452"), Address(RVA = "0x2B0C50", Offset = "0x2AFA50", VA = "0x102B0C50")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001BD2")]
    public int Rank
    {
      [Token(Token = "0x600D453"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BD3")]
    public EItemType ItemType
    {
      [Token(Token = "0x600D454"), Address(RVA = "0x919970", Offset = "0x918770", VA = "0x10919970")] get
      {
        return new EItemType();
      }
    }

    [Token(Token = "0x17001BD4")]
    public int Rarity
    {
      [Token(Token = "0x600D455"), Address(RVA = "0x919950", Offset = "0x918750", VA = "0x10919950")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BD5")]
    public int Exp
    {
      [Token(Token = "0x600D456"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001BD6")]
    public SkillData Skill
    {
      [Token(Token = "0x600D457"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x600D458")]
    [Address(RVA = "0x9DE860", Offset = "0x9DD660", VA = "0x109DE860")]
    public bool Setup(string item_iname) => new bool();

    [Token(Token = "0x600D459")]
    [Address(RVA = "0x9DE810", Offset = "0x9DD610", VA = "0x109DE810")]
    public void Reset()
    {
    }

    [Token(Token = "0x600D45A")]
    [Address(RVA = "0x9DDD00", Offset = "0x9DCB00", VA = "0x109DDD00")]
    public void Equip(Json_Equip json)
    {
    }

    [Token(Token = "0x600D45B")]
    [Address(RVA = "0x9DDC00", Offset = "0x9DCA00", VA = "0x109DDC00")]
    public void Equip(string iname, long iid, int exp)
    {
    }

    [Token(Token = "0x600D45C")]
    [Address(RVA = "0x596DE0", Offset = "0x595BE0", VA = "0x10596DE0")]
    public bool IsValid() => new bool();

    [Token(Token = "0x600D45D")]
    [Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")]
    public bool IsEquiped() => new bool();

    [Token(Token = "0x600D45E")]
    [Address(RVA = "0x9DE5F0", Offset = "0x9DD3F0", VA = "0x109DE5F0")]
    public int GetRankCap() => new int();

    [Token(Token = "0x600D45F")]
    [Address(RVA = "0x9DE2A0", Offset = "0x9DD0A0", VA = "0x109DE2A0")]
    public int GetNextExp(int rank) => new int();

    [Token(Token = "0x600D460")]
    [Address(RVA = "0x9DDF60", Offset = "0x9DCD60", VA = "0x109DDF60")]
    public int GetNeedExp(int rank) => new int();

    [Token(Token = "0x600D461")]
    [Address(RVA = "0x9DDBE0", Offset = "0x9DC9E0", VA = "0x109DDBE0")]
    public int CalcRank() => new int();

    [Token(Token = "0x600D462")]
    [Address(RVA = "0x9DDB00", Offset = "0x9DC900", VA = "0x109DDB00")]
    public int CalcRankFromExp(int current) => new int();

    [Token(Token = "0x600D463")]
    [Address(RVA = "0x9DEA70", Offset = "0x9DD870", VA = "0x109DEA70")]
    public void UpdateParam()
    {
    }

    [Token(Token = "0x600D464")]
    [Address(RVA = "0x9DDF20", Offset = "0x9DCD20", VA = "0x109DDF20")]
    public int GetExp() => new int();

    [Token(Token = "0x600D465")]
    [Address(RVA = "0x9DDEF0", Offset = "0x9DCCF0", VA = "0x109DDEF0")]
    public int GetExpFromExp(int current) => new int();

    [Token(Token = "0x600D466")]
    [Address(RVA = "0x9DE560", Offset = "0x9DD360", VA = "0x109DE560")]
    public int GetNextExp() => new int();

    [Token(Token = "0x600D467")]
    [Address(RVA = "0x9DE220", Offset = "0x9DD020", VA = "0x109DE220")]
    public int GetNextExpFromExp(int current) => new int();

    [Token(Token = "0x600D468")]
    [Address(RVA = "0x9DDE20", Offset = "0x9DCC20", VA = "0x109DDE20")]
    public void GainExp(int exp)
    {
    }

    [Token(Token = "0x600D469")]
    [Address(RVA = "0x9DDEB0", Offset = "0x9DCCB0", VA = "0x109DDEB0")]
    public int GetEnhanceCostScale() => new int();

    [Token(Token = "0x600D46A")]
    [Address(RVA = "0x9DE640", Offset = "0x9DD440", VA = "0x109DE640")]
    public List<ItemData> GetReturnItemList() => (List<ItemData>) null;

    [Token(Token = "0x600D46B")]
    [Address(RVA = "0x9DEA00", Offset = "0x9DD800", VA = "0x109DEA00", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600D46C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EquipData()
    {
    }
  }
}
