// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideUnitItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D11")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideUnitItemParam
  {
    [Token(Token = "0x40071EA")]
    [FieldOffset(Offset = "0x8")]
    public string unit_iname;
    [Token(Token = "0x40071EB")]
    [FieldOffset(Offset = "0xC")]
    public string need_item_open;
    [Token(Token = "0x40071EC")]
    [FieldOffset(Offset = "0x10")]
    public string need_item_relottery;

    [Token(Token = "0x600775C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideUnitItemParam()
    {
    }
  }
}
