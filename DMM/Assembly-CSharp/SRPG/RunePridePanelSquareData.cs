// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelSquareData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CFF")]
  [MessagePackObject(true)]
  public class RunePridePanelSquareData
  {
    [Token(Token = "0x40071A6")]
    [FieldOffset(Offset = "0x8")]
    private int id;
    [Token(Token = "0x40071A7")]
    [FieldOffset(Offset = "0xC")]
    private int fork_id;
    [Token(Token = "0x40071A8")]
    [FieldOffset(Offset = "0x10")]
    private int route_id;
    [Token(Token = "0x40071A9")]
    [FieldOffset(Offset = "0x14")]
    private int fork_id2;
    [Token(Token = "0x40071AA")]
    [FieldOffset(Offset = "0x18")]
    private int route_id2;
    [Token(Token = "0x40071AB")]
    [FieldOffset(Offset = "0x1C")]
    private int[] prev_ids;
    [Token(Token = "0x40071AC")]
    [FieldOffset(Offset = "0x20")]
    private bool is_goal;
    [Token(Token = "0x40071AD")]
    [FieldOffset(Offset = "0x24")]
    private int potential_num;
    [Token(Token = "0x40071AE")]
    [FieldOffset(Offset = "0x28")]
    private string draw_name;
    [Token(Token = "0x40071AF")]
    [FieldOffset(Offset = "0x2C")]
    private ParamTypes type;
    [Token(Token = "0x40071B0")]
    [FieldOffset(Offset = "0x2E")]
    private SkillParamCalcTypes calc_type;
    [Token(Token = "0x40071B1")]
    [FieldOffset(Offset = "0x30")]
    private int value;
    [Token(Token = "0x40071B2")]
    [FieldOffset(Offset = "0x34")]
    private string need_item;
    [Token(Token = "0x40071B3")]
    [FieldOffset(Offset = "0x38")]
    private string tag;

    [Token(Token = "0x17000F98")]
    public int Id
    {
      [Token(Token = "0x600770E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F99")]
    public int ForkId
    {
      [Token(Token = "0x600770F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F9A")]
    public int RouteId
    {
      [Token(Token = "0x6007710"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F9B")]
    public int SecondForkId
    {
      [Token(Token = "0x6007711"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F9C")]
    public int SecondRouteId
    {
      [Token(Token = "0x6007712"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F9D")]
    public int[] PrevIds
    {
      [Token(Token = "0x6007713"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x17000F9E")]
    public bool IsGoal
    {
      [Token(Token = "0x6007714"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000F9F")]
    public int PotentialNum
    {
      [Token(Token = "0x6007715"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA0")]
    public string DrawName
    {
      [Token(Token = "0x6007716"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FA1")]
    public ParamTypes Type
    {
      [Token(Token = "0x6007717"), Address(RVA = "0x39CB60", Offset = "0x39B960", VA = "0x1039CB60")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x17000FA2")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x6007718"), Address(RVA = "0x39CB50", Offset = "0x39B950", VA = "0x1039CB50")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x17000FA3")]
    public int Value
    {
      [Token(Token = "0x6007719"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA4")]
    public string NeedItem
    {
      [Token(Token = "0x600771A"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FA5")]
    public string Tag
    {
      [Token(Token = "0x600771B"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600771C")]
    [Address(RVA = "0x39CA80", Offset = "0x39B880", VA = "0x1039CA80")]
    public void Deserialize(JSON_RunePridePanelSquareData json)
    {
    }

    [Token(Token = "0x600771D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePanelSquareData()
    {
    }
  }
}
