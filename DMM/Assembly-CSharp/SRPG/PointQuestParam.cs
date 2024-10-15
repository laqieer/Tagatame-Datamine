// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C0F")]
  public class PointQuestParam
  {
    [Token(Token = "0x4006CBA")]
    [FieldOffset(Offset = "0x8")]
    private string mQuestIname;
    [Token(Token = "0x4006CBB")]
    [FieldOffset(Offset = "0xC")]
    private int mSkipRate;
    [Token(Token = "0x4006CBC")]
    [FieldOffset(Offset = "0x10")]
    private List<PointQuestVariables> mVariables;
    [Token(Token = "0x4006CBD")]
    [FieldOffset(Offset = "0x14")]
    private string mMissionIname;
    [Token(Token = "0x4006CBE")]
    [FieldOffset(Offset = "0x18")]
    private PointQuestActionCountType mActionNumMethod;
    [Token(Token = "0x4006CBF")]
    [FieldOffset(Offset = "0x1C")]
    private string mUnit;

    [Token(Token = "0x17000E74")]
    public string QuestIname
    {
      [Token(Token = "0x6007398"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E75")]
    public int SkipRate
    {
      [Token(Token = "0x6007399"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E76")]
    public List<PointQuestVariables> Variables
    {
      [Token(Token = "0x600739A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<PointQuestVariables>) null;
      }
    }

    [Token(Token = "0x17000E77")]
    public string MissionIname
    {
      [Token(Token = "0x600739B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E78")]
    public PointQuestActionCountType ActionNumMethod
    {
      [Token(Token = "0x600739C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new PointQuestActionCountType();
      }
    }

    [Token(Token = "0x17000E79")]
    public string Unit
    {
      [Token(Token = "0x600739D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600739E")]
    [Address(RVA = "0x37E750", Offset = "0x37D550", VA = "0x1037E750")]
    public void Deserialize(JSON_PointQuestParam json)
    {
    }

    [Token(Token = "0x600739F")]
    [Address(RVA = "0x37E940", Offset = "0x37D740", VA = "0x1037E940")]
    public static void Deserialize(
      ref ParamDictionary<string, PointQuestParam> ref_params,
      JSON_PointQuestParam[] jsons)
    {
    }

    [Token(Token = "0x60073A0")]
    [Address(RVA = "0x37EC00", Offset = "0x37DA00", VA = "0x1037EC00")]
    public static PointQuestParam GetPointQuestParam(string id) => (PointQuestParam) null;

    [Token(Token = "0x60073A1")]
    [Address(RVA = "0x37EA70", Offset = "0x37D870", VA = "0x1037EA70")]
    public int GetActionNum(BattleCore btl, List<SRPG.Unit> list) => new int();

    [Token(Token = "0x60073A2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestParam()
    {
    }
  }
}
