// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF2")]
  [MessagePackObject(true)]
  public class RunePrideBonusParam
  {
    [Token(Token = "0x400716A")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x400716B")]
    [FieldOffset(Offset = "0xC")]
    private string unit_group;
    [Token(Token = "0x400716C")]
    [FieldOffset(Offset = "0x10")]
    private int star_num;
    [Token(Token = "0x400716D")]
    [FieldOffset(Offset = "0x14")]
    private string bonus_id;
    [Token(Token = "0x400716E")]
    [FieldOffset(Offset = "0x18")]
    private string potential_id;

    [Token(Token = "0x17000F80")]
    public string Iname
    {
      [Token(Token = "0x60076DA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F81")]
    public string UnitGroup
    {
      [Token(Token = "0x60076DB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F82")]
    public int StarNum
    {
      [Token(Token = "0x60076DC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F83")]
    public string BonusId
    {
      [Token(Token = "0x60076DD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F84")]
    public string PotentialId
    {
      [Token(Token = "0x60076DE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60076DF")]
    [Address(RVA = "0x39B090", Offset = "0x399E90", VA = "0x1039B090")]
    public bool Deserialize(JSON_RunePrideBonusParam json) => new bool();

    [Token(Token = "0x60076E0")]
    [Address(RVA = "0x39B0F0", Offset = "0x399EF0", VA = "0x1039B0F0")]
    public static bool Deserialize(
      ref List<RunePrideBonusParam> paramList,
      JSON_RunePrideBonusParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x60076E1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideBonusParam()
    {
    }
  }
}
