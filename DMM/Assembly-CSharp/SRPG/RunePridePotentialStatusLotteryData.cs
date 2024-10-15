// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePotentialStatusLotteryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D09")]
  [MessagePackObject(true)]
  public class RunePridePotentialStatusLotteryData
  {
    [Token(Token = "0x40071D0")]
    [FieldOffset(Offset = "0x8")]
    private string draw_name;
    [Token(Token = "0x40071D1")]
    [FieldOffset(Offset = "0xC")]
    private ParamTypes type;
    [Token(Token = "0x40071D2")]
    [FieldOffset(Offset = "0x10")]
    private string tag;
    [Token(Token = "0x40071D3")]
    [FieldOffset(Offset = "0x14")]
    private ExTypes ex_type;
    [Token(Token = "0x40071D4")]
    [FieldOffset(Offset = "0x18")]
    private SkillParamCalcTypes calc_type;
    [Token(Token = "0x40071D5")]
    [FieldOffset(Offset = "0x1C")]
    private int min;
    [Token(Token = "0x40071D6")]
    [FieldOffset(Offset = "0x20")]
    private int max;

    [Token(Token = "0x17000FB0")]
    public string DrawName
    {
      [Token(Token = "0x6007739"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FB1")]
    public ParamTypes Type
    {
      [Token(Token = "0x600773A"), Address(RVA = "0x39B080", Offset = "0x399E80", VA = "0x1039B080")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x17000FB2")]
    public string Tag
    {
      [Token(Token = "0x600773B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FB3")]
    public ExTypes ExType
    {
      [Token(Token = "0x600773C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new ExTypes();
      }
    }

    [Token(Token = "0x17000FB4")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x600773D"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x17000FB5")]
    public int Min
    {
      [Token(Token = "0x600773E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FB6")]
    public int Max
    {
      [Token(Token = "0x600773F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007740")]
    [Address(RVA = "0x39CCE0", Offset = "0x39BAE0", VA = "0x1039CCE0")]
    public void Deserialize(JSON_RunePridePotentialStatusLotteryData json)
    {
    }

    [Token(Token = "0x6007741")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePotentialStatusLotteryData()
    {
    }
  }
}
