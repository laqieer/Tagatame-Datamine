// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideBonusStatusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF6")]
  [MessagePackObject(true)]
  public class RunePrideBonusStatusParam
  {
    [Token(Token = "0x400717D")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x400717E")]
    [FieldOffset(Offset = "0xC")]
    private List<RunePrideBonusData> bonuses;

    [Token(Token = "0x17000F8B")]
    public string Iname
    {
      [Token(Token = "0x60076EC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F8C")]
    public List<RunePrideBonusData> Bonuses
    {
      [Token(Token = "0x60076ED"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RunePrideBonusData>) null;
      }
    }

    [Token(Token = "0x60076EE")]
    [Address(RVA = "0x39B290", Offset = "0x39A090", VA = "0x1039B290")]
    public bool Deserialize(JSON_RunePrideBonusStatusParam json) => new bool();

    [Token(Token = "0x60076EF")]
    [Address(RVA = "0x39B420", Offset = "0x39A220", VA = "0x1039B420")]
    public static bool Deserialize(
      ref List<RunePrideBonusStatusParam> paramList,
      JSON_RunePrideBonusStatusParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x60076F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideBonusStatusParam()
    {
    }
  }
}
