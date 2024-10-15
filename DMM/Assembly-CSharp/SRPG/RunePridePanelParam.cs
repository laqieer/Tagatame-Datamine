// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelParam
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
  [Token(Token = "0x2001D02")]
  [MessagePackObject(true)]
  public class RunePridePanelParam
  {
    [Token(Token = "0x40071BA")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40071BB")]
    [FieldOffset(Offset = "0x10")]
    private DateTime open_date;
    [Token(Token = "0x40071BC")]
    [FieldOffset(Offset = "0x18")]
    private int bonus_max;
    [Token(Token = "0x40071BD")]
    [FieldOffset(Offset = "0x1C")]
    private string prefab;

    [Token(Token = "0x17000FA8")]
    public string Iname
    {
      [Token(Token = "0x6007724"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FA9")]
    public DateTime OpenDate
    {
      [Token(Token = "0x6007725"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000FAA")]
    public int BonusMax
    {
      [Token(Token = "0x6007726"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FAB")]
    public string Prefab
    {
      [Token(Token = "0x6007727"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007728")]
    [Address(RVA = "0x39C620", Offset = "0x39B420", VA = "0x1039C620")]
    public bool Deserialize(JSON_RunePridePanelParam json) => new bool();

    [Token(Token = "0x6007729")]
    [Address(RVA = "0x39C700", Offset = "0x39B500", VA = "0x1039C700")]
    public static bool Deserialize(
      ref List<RunePridePanelParam> paramList,
      JSON_RunePridePanelParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600772A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePanelParam()
    {
    }
  }
}
