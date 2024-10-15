// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BAD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ItemParam
  {
    [Token(Token = "0x40069B2")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40069B3")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40069B4")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40069B5")]
    [FieldOffset(Offset = "0x14")]
    public string flavor;
    [Token(Token = "0x40069B6")]
    [FieldOffset(Offset = "0x18")]
    public int type;
    [Token(Token = "0x40069B7")]
    [FieldOffset(Offset = "0x1C")]
    public int tabtype;
    [Token(Token = "0x40069B8")]
    [FieldOffset(Offset = "0x20")]
    public int rare;
    [Token(Token = "0x40069B9")]
    [FieldOffset(Offset = "0x24")]
    public int cap;
    [Token(Token = "0x40069BA")]
    [FieldOffset(Offset = "0x28")]
    public int invcap;
    [Token(Token = "0x40069BB")]
    [FieldOffset(Offset = "0x2C")]
    public int eqlv;
    [Token(Token = "0x40069BC")]
    [FieldOffset(Offset = "0x30")]
    public int coin;
    [Token(Token = "0x40069BD")]
    [FieldOffset(Offset = "0x34")]
    public int tc;
    [Token(Token = "0x40069BE")]
    [FieldOffset(Offset = "0x38")]
    public int ac;
    [Token(Token = "0x40069BF")]
    [FieldOffset(Offset = "0x3C")]
    public int ec;
    [Token(Token = "0x40069C0")]
    [FieldOffset(Offset = "0x40")]
    public int mc;
    [Token(Token = "0x40069C1")]
    [FieldOffset(Offset = "0x44")]
    public int pp;
    [Token(Token = "0x40069C2")]
    [FieldOffset(Offset = "0x48")]
    public int buy;
    [Token(Token = "0x40069C3")]
    [FieldOffset(Offset = "0x4C")]
    public int sell;
    [Token(Token = "0x40069C4")]
    [FieldOffset(Offset = "0x50")]
    public int encost;
    [Token(Token = "0x40069C5")]
    [FieldOffset(Offset = "0x54")]
    public int enpt;
    [Token(Token = "0x40069C6")]
    [FieldOffset(Offset = "0x58")]
    public int facilitypt;
    [Token(Token = "0x40069C7")]
    [FieldOffset(Offset = "0x5C")]
    public int val;
    [Token(Token = "0x40069C8")]
    [FieldOffset(Offset = "0x60")]
    public string icon;
    [Token(Token = "0x40069C9")]
    [FieldOffset(Offset = "0x64")]
    public string skill;
    [Token(Token = "0x40069CA")]
    [FieldOffset(Offset = "0x68")]
    public string recipe;
    [Token(Token = "0x40069CB")]
    [FieldOffset(Offset = "0x6C")]
    public int is_valuables;
    [Token(Token = "0x40069CC")]
    [FieldOffset(Offset = "0x70")]
    public int is_cmn;
    [Token(Token = "0x40069CD")]
    [FieldOffset(Offset = "0x74")]
    public byte cmn_type;
    [Token(Token = "0x40069CE")]
    [FieldOffset(Offset = "0x78")]
    public int gallery_view;
    [Token(Token = "0x40069CF")]
    [FieldOffset(Offset = "0x7C")]
    public string begin_at;
    [Token(Token = "0x40069D0")]
    [FieldOffset(Offset = "0x80")]
    public string end_at;

    [Token(Token = "0x6007246")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ItemParam()
    {
    }
  }
}
