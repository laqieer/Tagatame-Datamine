// Decompiled with JetBrains decompiler
// Type: SRPG.SkillMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BC6")]
  public class SkillMap
  {
    [Token(Token = "0x4001DCE")]
    [FieldOffset(Offset = "0x8")]
    private Unit m_Owner;
    [Token(Token = "0x4001DCF")]
    [FieldOffset(Offset = "0xC")]
    private uint[] m_SkillSeed;
    [Token(Token = "0x4001DD0")]
    [FieldOffset(Offset = "0x10")]
    private List<SkillMap.Data> m_List;
    [Token(Token = "0x4001DD1")]
    [FieldOffset(Offset = "0x14")]
    private BattleCore.SkillResult m_UseSkill;
    [Token(Token = "0x4001DD2")]
    [FieldOffset(Offset = "0x18")]
    private AIAction m_Action;
    [Token(Token = "0x4001DD3")]
    [FieldOffset(Offset = "0x1C")]
    private bool m_IsNoExecActionSkill;
    [Token(Token = "0x4001DD4")]
    [FieldOffset(Offset = "0x20")]
    private List<SkillData> m_AllSkills;
    [Token(Token = "0x4001DD5")]
    [FieldOffset(Offset = "0x24")]
    private int m_AttackHeight;
    [Token(Token = "0x4001DD6")]
    [FieldOffset(Offset = "0x28")]
    private int m_UseSkillNum;
    [Token(Token = "0x4001DD7")]
    [FieldOffset(Offset = "0x2C")]
    private List<List<SkillData>> m_UseSkillLists;
    [Token(Token = "0x4001DD8")]
    [FieldOffset(Offset = "0x30")]
    private List<SkillData> m_ForceSkillList;
    [Token(Token = "0x4001DD9")]
    [FieldOffset(Offset = "0x34")]
    private List<SkillData> m_HealSkills;
    [Token(Token = "0x4001DDA")]
    [FieldOffset(Offset = "0x38")]
    private List<SkillData> m_DamageSkills;
    [Token(Token = "0x4001DDB")]
    [FieldOffset(Offset = "0x3C")]
    private List<SkillData> m_SupportSkills;
    [Token(Token = "0x4001DDC")]
    [FieldOffset(Offset = "0x40")]
    private List<SkillData> m_CureConditionSkills;
    [Token(Token = "0x4001DDD")]
    [FieldOffset(Offset = "0x44")]
    private List<SkillData> m_FailConditionSkills;
    [Token(Token = "0x4001DDE")]
    [FieldOffset(Offset = "0x48")]
    private List<SkillData> m_DisableConditionSkills;
    [Token(Token = "0x4001DDF")]
    [FieldOffset(Offset = "0x4C")]
    private List<SkillData> m_TransformSkills;
    [Token(Token = "0x4001DE0")]
    [FieldOffset(Offset = "0x50")]
    private List<SkillData> m_ProtectSkills;
    [Token(Token = "0x4001DE1")]
    [FieldOffset(Offset = "0x54")]
    private List<SkillData> m_ManipulateSkills;
    [Token(Token = "0x4001DE2")]
    [FieldOffset(Offset = "0x58")]
    private List<SkillData> m_ExeSkills;

    [Token(Token = "0x170002B3")]
    public Unit owner
    {
      [Token(Token = "0x6002F37"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
      [Token(Token = "0x6002F38"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x170002B4")]
    public uint[] skillSeed
    {
      [Token(Token = "0x6002F39"), Address(RVA = "0xFCD5D0", Offset = "0xFCC3D0", VA = "0x10FCD5D0")] set
      {
      }
      [Token(Token = "0x6002F3A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (uint[]) null;
      }
    }

    [Token(Token = "0x170002B5")]
    public List<SkillMap.Data> list
    {
      [Token(Token = "0x6002F3B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<SkillMap.Data>) null;
      }
    }

    [Token(Token = "0x170002B6")]
    public bool isNoExecActionSkill
    {
      [Token(Token = "0x6002F3C"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] set
      {
      }
      [Token(Token = "0x6002F3D"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002B7")]
    public List<SkillData> allSkills
    {
      [Token(Token = "0x6002F3E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002B8")]
    public int attackHeight
    {
      [Token(Token = "0x6002F3F"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] set
      {
      }
      [Token(Token = "0x6002F40"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002B9")]
    public int useSkillNum
    {
      [Token(Token = "0x6002F41"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
      [Token(Token = "0x6002F42"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002BA")]
    public List<List<SkillData>> useSkillLists
    {
      [Token(Token = "0x6002F43"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<List<SkillData>>) null;
      }
    }

    [Token(Token = "0x170002BB")]
    public List<SkillData> forceSkillList
    {
      [Token(Token = "0x6002F44"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002BC")]
    public List<SkillData> healSkills
    {
      [Token(Token = "0x6002F45"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002BD")]
    public List<SkillData> damageSkills
    {
      [Token(Token = "0x6002F46"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002BE")]
    public List<SkillData> supportSkills
    {
      [Token(Token = "0x6002F47"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002BF")]
    public List<SkillData> cureConditionSkills
    {
      [Token(Token = "0x6002F48"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002C0")]
    public List<SkillData> failConditionSkills
    {
      [Token(Token = "0x6002F49"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002C1")]
    public List<SkillData> disableConditionSkills
    {
      [Token(Token = "0x6002F4A"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002C2")]
    public List<SkillData> transformSkills
    {
      [Token(Token = "0x6002F4B"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002C3")]
    public List<SkillData> protectSkills
    {
      [Token(Token = "0x6002F4C"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002C4")]
    public List<SkillData> manipulateSkills
    {
      [Token(Token = "0x6002F4D"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x170002C5")]
    public List<SkillData> exeSkills
    {
      [Token(Token = "0x6002F4E"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x6002F4F")]
    [Address(RVA = "0xFCD270", Offset = "0xFCC070", VA = "0x10FCD270")]
    public SkillMap()
    {
    }

    [Token(Token = "0x6002F50")]
    [Address(RVA = "0xFCC9D0", Offset = "0xFCB7D0", VA = "0x10FCC9D0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6002F51")]
    [Address(RVA = "0xFCD190", Offset = "0xFCBF90", VA = "0x10FCD190")]
    public void Reset()
    {
    }

    [Token(Token = "0x6002F52")]
    [Address(RVA = "0xFCD230", Offset = "0xFCC030", VA = "0x10FCD230")]
    public SkillMap.Data[] ToArray() => (SkillMap.Data[]) null;

    [Token(Token = "0x6002F53")]
    [Address(RVA = "0xFCC980", Offset = "0xFCB780", VA = "0x10FCC980")]
    public void Add(SkillMap.Data data)
    {
    }

    [Token(Token = "0x6002F54")]
    [Address(RVA = "0xFCCDF0", Offset = "0xFCBBF0", VA = "0x10FCCDF0")]
    public SkillMap.Data Get(SkillData skill) => (SkillMap.Data) null;

    [Token(Token = "0x6002F55")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SetUseSkill(BattleCore.SkillResult result)
    {
    }

    [Token(Token = "0x6002F56")]
    [Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")]
    public BattleCore.SkillResult GetUseSkill() => (BattleCore.SkillResult) null;

    [Token(Token = "0x6002F57")]
    [Address(RVA = "0x3683C0", Offset = "0x3671C0", VA = "0x103683C0")]
    public bool HasUseSkill() => new bool();

    [Token(Token = "0x6002F58")]
    [Address(RVA = "0xFCCCD0", Offset = "0xFCBAD0", VA = "0x10FCCCD0")]
    public List<SkillData> GetSkillList(int n) => (List<SkillData>) null;

    [Token(Token = "0x6002F59")]
    [Address(RVA = "0xFCCD60", Offset = "0xFCBB60", VA = "0x10FCCD60")]
    public List<SkillData> GetSkillList() => (List<SkillData>) null;

    [Token(Token = "0x6002F5A")]
    [Address(RVA = "0xFCD180", Offset = "0xFCBF80", VA = "0x10FCD180")]
    public void NextSkillList()
    {
    }

    [Token(Token = "0x6002F5B")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void SetAction(AIAction action)
    {
    }

    [Token(Token = "0x6002F5C")]
    [Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")]
    public AIAction GetAction() => (AIAction) null;

    [Token(Token = "0x6002F5D")]
    [Address(RVA = "0xFCCEC0", Offset = "0xFCBCC0", VA = "0x10FCCEC0")]
    public void NextAction(bool isMove, BattleCore.SkillResult result)
    {
    }

    [Token(Token = "0x6002F5E")]
    [Address(RVA = "0xFCD140", Offset = "0xFCBF40", VA = "0x10FCD140")]
    public void NextAction(bool isMove)
    {
    }

    [Token(Token = "0x6002F5F")]
    [Address(RVA = "0xFCD160", Offset = "0xFCBF60", VA = "0x10FCD160")]
    public void NextAction(BattleCore.SkillResult result)
    {
    }

    [Token(Token = "0x6002F60")]
    [Address(RVA = "0xFCD1F0", Offset = "0xFCBFF0", VA = "0x10FCD1F0")]
    public AIAction SetAction(int index) => (AIAction) null;

    [Token(Token = "0x6002F61")]
    [Address(RVA = "0xFCCCC0", Offset = "0xFCBAC0", VA = "0x10FCCCC0")]
    public static int GetHash(int x, int y) => new int();

    [Token(Token = "0x6002F62")]
    [Address(RVA = "0xFCCCC0", Offset = "0xFCBAC0", VA = "0x10FCCCC0")]
    public static int GetHash(IntVector2 pos) => new int();

    [Token(Token = "0x2000BC7")]
    public class Score
    {
      [Token(Token = "0x4001DE3")]
      [FieldOffset(Offset = "0x8")]
      public int priority;
      [Token(Token = "0x4001DE4")]
      [FieldOffset(Offset = "0xC")]
      public IntVector2 pos;
      [Token(Token = "0x4001DE5")]
      [FieldOffset(Offset = "0x14")]
      public SkillRange range;
      [Token(Token = "0x4001DE6")]
      [FieldOffset(Offset = "0x24")]
      public LogSkill log;

      [Token(Token = "0x6002F63")]
      [Address(RVA = "0xFCC780", Offset = "0xFCB580", VA = "0x10FCC780")]
      public Score(int _x, int _y, int _w, int _h)
      {
      }

      [Token(Token = "0x6002F64")]
      [Address(RVA = "0xFCC760", Offset = "0xFCB560", VA = "0x10FCC760")]
      public bool IsAttackRange(int x, int y) => new bool();
    }

    [Token(Token = "0x2000BC8")]
    public class Target
    {
      [Token(Token = "0x4001DE7")]
      [FieldOffset(Offset = "0x8")]
      public IntVector2 pos;
      [Token(Token = "0x4001DE8")]
      [FieldOffset(Offset = "0x10")]
      public Dictionary<int, SkillMap.Score> scores;

      [Token(Token = "0x6002F65")]
      [Address(RVA = "0xFD2B70", Offset = "0xFD1970", VA = "0x10FD2B70")]
      public void Add(SkillMap.Score score)
      {
      }

      [Token(Token = "0x6002F66")]
      [Address(RVA = "0xFD2BD0", Offset = "0xFD19D0", VA = "0x10FD2BD0")]
      public SkillMap.Score Get(int x, int y) => (SkillMap.Score) null;

      [Token(Token = "0x6002F67")]
      [Address(RVA = "0xFD2DB0", Offset = "0xFD1BB0", VA = "0x10FD2DB0")]
      public bool IsRange(int x, int y) => new bool();

      [Token(Token = "0x6002F68")]
      [Address(RVA = "0xFD2C30", Offset = "0xFD1A30", VA = "0x10FD2C30")]
      public bool IsAttackRange(int x, int y) => new bool();

      [Token(Token = "0x6002F69")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Target()
      {
      }
    }

    [Token(Token = "0x2000BC9")]
    public class Data
    {
      [Token(Token = "0x4001DE9")]
      [FieldOffset(Offset = "0x8")]
      public SkillData skill;
      [Token(Token = "0x4001DEA")]
      [FieldOffset(Offset = "0xC")]
      public Dictionary<int, SkillMap.Target> targets;

      [Token(Token = "0x6002F6A")]
      [Address(RVA = "0xFC8990", Offset = "0xFC7790", VA = "0x10FC8990")]
      public Data(SkillData _skill)
      {
      }

      [Token(Token = "0x6002F6B")]
      [Address(RVA = "0xFC7E30", Offset = "0xFC6C30", VA = "0x10FC7E30")]
      public void Add(SkillMap.Target range)
      {
      }

      [Token(Token = "0x6002F6C")]
      [Address(RVA = "0xFC8260", Offset = "0xFC7060", VA = "0x10FC8260")]
      public SkillMap.Target Get(int x, int y) => (SkillMap.Target) null;

      [Token(Token = "0x6002F6D")]
      [Address(RVA = "0xFC8050", Offset = "0xFC6E50", VA = "0x10FC8050")]
      public SkillMap.Score[] GetScores(int x, int y) => (SkillMap.Score[]) null;

      [Token(Token = "0x6002F6E")]
      [Address(RVA = "0xFC86C0", Offset = "0xFC74C0", VA = "0x10FC86C0")]
      public bool IsRange(int x, int y) => new bool();

      [Token(Token = "0x6002F6F")]
      [Address(RVA = "0xFC82C0", Offset = "0xFC70C0", VA = "0x10FC82C0")]
      public bool IsAttackRange(int x, int y) => new bool();
    }
  }
}
