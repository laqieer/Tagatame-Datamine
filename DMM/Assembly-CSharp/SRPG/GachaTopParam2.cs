// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTopParam2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F12")]
  public class GachaTopParam2
  {
    [Token(Token = "0x4002EAD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002EAE")]
    [FieldOffset(Offset = "0xC")]
    public string category;
    [Token(Token = "0x4002EAF")]
    [FieldOffset(Offset = "0x10")]
    public int coin;
    [Token(Token = "0x4002EB0")]
    [FieldOffset(Offset = "0x14")]
    public int coin_p;
    [Token(Token = "0x4002EB1")]
    [FieldOffset(Offset = "0x18")]
    public int gold;
    [Token(Token = "0x4002EB2")]
    [FieldOffset(Offset = "0x1C")]
    public int gold_p;
    [Token(Token = "0x4002EB3")]
    [FieldOffset(Offset = "0x20")]
    public List<UnitParam> units;
    [Token(Token = "0x4002EB4")]
    [FieldOffset(Offset = "0x24")]
    public int num;
    [Token(Token = "0x4002EB5")]
    [FieldOffset(Offset = "0x28")]
    public string ticket;
    [Token(Token = "0x4002EB6")]
    [FieldOffset(Offset = "0x2C")]
    public int ticket_num;
    [Token(Token = "0x4002EB7")]
    [FieldOffset(Offset = "0x30")]
    public bool step;
    [Token(Token = "0x4002EB8")]
    [FieldOffset(Offset = "0x34")]
    public int step_num;
    [Token(Token = "0x4002EB9")]
    [FieldOffset(Offset = "0x38")]
    public int step_index;
    [Token(Token = "0x4002EBA")]
    [FieldOffset(Offset = "0x3C")]
    public bool limit;
    [Token(Token = "0x4002EBB")]
    [FieldOffset(Offset = "0x40")]
    public int limit_num;
    [Token(Token = "0x4002EBC")]
    [FieldOffset(Offset = "0x44")]
    public int limit_stock;
    [Token(Token = "0x4002EBD")]
    [FieldOffset(Offset = "0x48")]
    public string type;
    [Token(Token = "0x4002EBE")]
    [FieldOffset(Offset = "0x4C")]
    public string asset_title;
    [Token(Token = "0x4002EBF")]
    [FieldOffset(Offset = "0x50")]
    public string asset_bg;
    [Token(Token = "0x4002EC0")]
    [FieldOffset(Offset = "0x54")]
    public string group;
    [Token(Token = "0x4002EC1")]
    [FieldOffset(Offset = "0x58")]
    public string btext;
    [Token(Token = "0x4002EC2")]
    [FieldOffset(Offset = "0x5C")]
    public string confirm;

    [Token(Token = "0x6003ECD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaTopParam2()
    {
    }
  }
}
