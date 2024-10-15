// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideUnitItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D12")]
  [MessagePackObject(true)]
  public class RunePrideUnitItemParam
  {
    [Token(Token = "0x40071ED")]
    [FieldOffset(Offset = "0x8")]
    private string unit_iname;
    [Token(Token = "0x40071EE")]
    [FieldOffset(Offset = "0xC")]
    public string need_item_open;
    [Token(Token = "0x40071EF")]
    [FieldOffset(Offset = "0x10")]
    public string need_item_relottery;

    [Token(Token = "0x17000FC2")]
    public string UnitIname
    {
      [Token(Token = "0x600775D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FC3")]
    public string NeedItemOpen
    {
      [Token(Token = "0x600775E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FC4")]
    public string NeedItemRelottery
    {
      [Token(Token = "0x600775F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007760")]
    [Address(RVA = "0x3550B0", Offset = "0x353EB0", VA = "0x103550B0")]
    public bool Deserialize(JSON_RunePrideUnitItemParam json) => new bool();

    [Token(Token = "0x6007761")]
    [Address(RVA = "0x39D710", Offset = "0x39C510", VA = "0x1039D710")]
    public static bool Deserialize(
      ref List<RunePrideUnitItemParam> paramList,
      JSON_RunePrideUnitItemParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007762")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideUnitItemParam()
    {
    }
  }
}
