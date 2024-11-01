﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_UnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E93")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_UnitParam
  {
    [Token(Token = "0x4007F18")]
    [FieldOffset(Offset = "0x8")]
    public int no;
    [Token(Token = "0x4007F19")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4007F1A")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007F1B")]
    [FieldOffset(Offset = "0x14")]
    public string ai;
    [Token(Token = "0x4007F1C")]
    [FieldOffset(Offset = "0x18")]
    public string mdl;
    [Token(Token = "0x4007F1D")]
    [FieldOffset(Offset = "0x1C")]
    public string tag;
    [Token(Token = "0x4007F1E")]
    [FieldOffset(Offset = "0x20")]
    public string grow;
    [Token(Token = "0x4007F1F")]
    [FieldOffset(Offset = "0x24")]
    public string[] jobsets;
    [Token(Token = "0x4007F20")]
    [FieldOffset(Offset = "0x28")]
    public string piece;
    [Token(Token = "0x4007F21")]
    [FieldOffset(Offset = "0x2C")]
    public string sub_piece;
    [Token(Token = "0x4007F22")]
    [FieldOffset(Offset = "0x30")]
    public string birth;
    [Token(Token = "0x4007F23")]
    [FieldOffset(Offset = "0x34")]
    public int birth_id;
    [Token(Token = "0x4007F24")]
    [FieldOffset(Offset = "0x38")]
    public string skill;
    [Token(Token = "0x4007F25")]
    [FieldOffset(Offset = "0x3C")]
    public string ability;
    [Token(Token = "0x4007F26")]
    [FieldOffset(Offset = "0x40")]
    public string ma_quest;
    [Token(Token = "0x4007F27")]
    [FieldOffset(Offset = "0x44")]
    public int sw;
    [Token(Token = "0x4007F28")]
    [FieldOffset(Offset = "0x48")]
    public int sh;
    [Token(Token = "0x4007F29")]
    [FieldOffset(Offset = "0x4C")]
    public int sd;
    [Token(Token = "0x4007F2A")]
    [FieldOffset(Offset = "0x50")]
    public int sex;
    [Token(Token = "0x4007F2B")]
    [FieldOffset(Offset = "0x54")]
    public int rare;
    [Token(Token = "0x4007F2C")]
    [FieldOffset(Offset = "0x58")]
    public int raremax;
    [Token(Token = "0x4007F2D")]
    [FieldOffset(Offset = "0x5C")]
    public int type;
    [Token(Token = "0x4007F2E")]
    [FieldOffset(Offset = "0x60")]
    public int elem;
    [Token(Token = "0x4007F2F")]
    [FieldOffset(Offset = "0x64")]
    public int hero;
    [Token(Token = "0x4007F30")]
    [FieldOffset(Offset = "0x68")]
    public int search;
    [Token(Token = "0x4007F31")]
    [FieldOffset(Offset = "0x6C")]
    public int stop;
    [Token(Token = "0x4007F32")]
    [FieldOffset(Offset = "0x70")]
    public int notsmn;
    [Token(Token = "0x4007F33")]
    [FieldOffset(Offset = "0x74")]
    public string available_at;
    [Token(Token = "0x4007F34")]
    [FieldOffset(Offset = "0x78")]
    public int height;
    [Token(Token = "0x4007F35")]
    [FieldOffset(Offset = "0x7C")]
    public int weight;
    [Token(Token = "0x4007F36")]
    [FieldOffset(Offset = "0x80")]
    public int hp;
    [Token(Token = "0x4007F37")]
    [FieldOffset(Offset = "0x84")]
    public int mp;
    [Token(Token = "0x4007F38")]
    [FieldOffset(Offset = "0x88")]
    public int atk;
    [Token(Token = "0x4007F39")]
    [FieldOffset(Offset = "0x8C")]
    public int def;
    [Token(Token = "0x4007F3A")]
    [FieldOffset(Offset = "0x90")]
    public int mag;
    [Token(Token = "0x4007F3B")]
    [FieldOffset(Offset = "0x94")]
    public int mnd;
    [Token(Token = "0x4007F3C")]
    [FieldOffset(Offset = "0x98")]
    public int dex;
    [Token(Token = "0x4007F3D")]
    [FieldOffset(Offset = "0x9C")]
    public int spd;
    [Token(Token = "0x4007F3E")]
    [FieldOffset(Offset = "0xA0")]
    public int cri;
    [Token(Token = "0x4007F3F")]
    [FieldOffset(Offset = "0xA4")]
    public int luk;
    [Token(Token = "0x4007F40")]
    [FieldOffset(Offset = "0xA8")]
    public int apo;
    [Token(Token = "0x4007F41")]
    [FieldOffset(Offset = "0xAC")]
    public int apa;
    [Token(Token = "0x4007F42")]
    [FieldOffset(Offset = "0xB0")]
    public int ast;
    [Token(Token = "0x4007F43")]
    [FieldOffset(Offset = "0xB4")]
    public int asl;
    [Token(Token = "0x4007F44")]
    [FieldOffset(Offset = "0xB8")]
    public int ach;
    [Token(Token = "0x4007F45")]
    [FieldOffset(Offset = "0xBC")]
    public int asn;
    [Token(Token = "0x4007F46")]
    [FieldOffset(Offset = "0xC0")]
    public int abl;
    [Token(Token = "0x4007F47")]
    [FieldOffset(Offset = "0xC4")]
    public int ans;
    [Token(Token = "0x4007F48")]
    [FieldOffset(Offset = "0xC8")]
    public int anm;
    [Token(Token = "0x4007F49")]
    [FieldOffset(Offset = "0xCC")]
    public int ana;
    [Token(Token = "0x4007F4A")]
    [FieldOffset(Offset = "0xD0")]
    public int azo;
    [Token(Token = "0x4007F4B")]
    [FieldOffset(Offset = "0xD4")]
    public int ade;
    [Token(Token = "0x4007F4C")]
    [FieldOffset(Offset = "0xD8")]
    public int akn;
    [Token(Token = "0x4007F4D")]
    [FieldOffset(Offset = "0xDC")]
    public int rpo;
    [Token(Token = "0x4007F4E")]
    [FieldOffset(Offset = "0xE0")]
    public int rpa;
    [Token(Token = "0x4007F4F")]
    [FieldOffset(Offset = "0xE4")]
    public int rst;
    [Token(Token = "0x4007F50")]
    [FieldOffset(Offset = "0xE8")]
    public int rsl;
    [Token(Token = "0x4007F51")]
    [FieldOffset(Offset = "0xEC")]
    public int rch;
    [Token(Token = "0x4007F52")]
    [FieldOffset(Offset = "0xF0")]
    public int rsn;
    [Token(Token = "0x4007F53")]
    [FieldOffset(Offset = "0xF4")]
    public int rbl;
    [Token(Token = "0x4007F54")]
    [FieldOffset(Offset = "0xF8")]
    public int rns;
    [Token(Token = "0x4007F55")]
    [FieldOffset(Offset = "0xFC")]
    public int rnm;
    [Token(Token = "0x4007F56")]
    [FieldOffset(Offset = "0x100")]
    public int rna;
    [Token(Token = "0x4007F57")]
    [FieldOffset(Offset = "0x104")]
    public int rzo;
    [Token(Token = "0x4007F58")]
    [FieldOffset(Offset = "0x108")]
    public int rde;
    [Token(Token = "0x4007F59")]
    [FieldOffset(Offset = "0x10C")]
    public int rkn;
    [Token(Token = "0x4007F5A")]
    [FieldOffset(Offset = "0x110")]
    public int rdf;
    [Token(Token = "0x4007F5B")]
    [FieldOffset(Offset = "0x114")]
    public int rbe;
    [Token(Token = "0x4007F5C")]
    [FieldOffset(Offset = "0x118")]
    public int rcs;
    [Token(Token = "0x4007F5D")]
    [FieldOffset(Offset = "0x11C")]
    public int rcu;
    [Token(Token = "0x4007F5E")]
    [FieldOffset(Offset = "0x120")]
    public int rcd;
    [Token(Token = "0x4007F5F")]
    [FieldOffset(Offset = "0x124")]
    public int rdo;
    [Token(Token = "0x4007F60")]
    [FieldOffset(Offset = "0x128")]
    public int rra;
    [Token(Token = "0x4007F61")]
    [FieldOffset(Offset = "0x12C")]
    public int rsa;
    [Token(Token = "0x4007F62")]
    [FieldOffset(Offset = "0x130")]
    public int raa;
    [Token(Token = "0x4007F63")]
    [FieldOffset(Offset = "0x134")]
    public int rdc;
    [Token(Token = "0x4007F64")]
    [FieldOffset(Offset = "0x138")]
    public int ric;
    [Token(Token = "0x4007F65")]
    [FieldOffset(Offset = "0x13C")]
    public int ras;
    [Token(Token = "0x4007F66")]
    [FieldOffset(Offset = "0x140")]
    public int rab;
    [Token(Token = "0x4007F67")]
    [FieldOffset(Offset = "0x144")]
    public int ror;
    [Token(Token = "0x4007F68")]
    [FieldOffset(Offset = "0x148")]
    public int rft;
    [Token(Token = "0x4007F69")]
    [FieldOffset(Offset = "0x14C")]
    public int dsu;
    [Token(Token = "0x4007F6A")]
    [FieldOffset(Offset = "0x150")]
    public int rdh;
    [Token(Token = "0x4007F6B")]
    [FieldOffset(Offset = "0x154")]
    public int bom;
    [Token(Token = "0x4007F6C")]
    [FieldOffset(Offset = "0x158")]
    public int slp;
    [Token(Token = "0x4007F6D")]
    [FieldOffset(Offset = "0x15C")]
    public int rfrz;
    [Token(Token = "0x4007F6E")]
    [FieldOffset(Offset = "0x160")]
    public int down;
    [Token(Token = "0x4007F6F")]
    [FieldOffset(Offset = "0x164")]
    public int mhp;
    [Token(Token = "0x4007F70")]
    [FieldOffset(Offset = "0x168")]
    public int mmp;
    [Token(Token = "0x4007F71")]
    [FieldOffset(Offset = "0x16C")]
    public int matk;
    [Token(Token = "0x4007F72")]
    [FieldOffset(Offset = "0x170")]
    public int mdef;
    [Token(Token = "0x4007F73")]
    [FieldOffset(Offset = "0x174")]
    public int mmag;
    [Token(Token = "0x4007F74")]
    [FieldOffset(Offset = "0x178")]
    public int mmnd;
    [Token(Token = "0x4007F75")]
    [FieldOffset(Offset = "0x17C")]
    public int mdex;
    [Token(Token = "0x4007F76")]
    [FieldOffset(Offset = "0x180")]
    public int mspd;
    [Token(Token = "0x4007F77")]
    [FieldOffset(Offset = "0x184")]
    public int mcri;
    [Token(Token = "0x4007F78")]
    [FieldOffset(Offset = "0x188")]
    public int mluk;
    [Token(Token = "0x4007F79")]
    [FieldOffset(Offset = "0x18C")]
    public int mapo;
    [Token(Token = "0x4007F7A")]
    [FieldOffset(Offset = "0x190")]
    public int mapa;
    [Token(Token = "0x4007F7B")]
    [FieldOffset(Offset = "0x194")]
    public int mast;
    [Token(Token = "0x4007F7C")]
    [FieldOffset(Offset = "0x198")]
    public int masl;
    [Token(Token = "0x4007F7D")]
    [FieldOffset(Offset = "0x19C")]
    public int mach;
    [Token(Token = "0x4007F7E")]
    [FieldOffset(Offset = "0x1A0")]
    public int masn;
    [Token(Token = "0x4007F7F")]
    [FieldOffset(Offset = "0x1A4")]
    public int mabl;
    [Token(Token = "0x4007F80")]
    [FieldOffset(Offset = "0x1A8")]
    public int mans;
    [Token(Token = "0x4007F81")]
    [FieldOffset(Offset = "0x1AC")]
    public int manm;
    [Token(Token = "0x4007F82")]
    [FieldOffset(Offset = "0x1B0")]
    public int mana;
    [Token(Token = "0x4007F83")]
    [FieldOffset(Offset = "0x1B4")]
    public int mazo;
    [Token(Token = "0x4007F84")]
    [FieldOffset(Offset = "0x1B8")]
    public int made;
    [Token(Token = "0x4007F85")]
    [FieldOffset(Offset = "0x1BC")]
    public int makn;
    [Token(Token = "0x4007F86")]
    [FieldOffset(Offset = "0x1C0")]
    public int mrpo;
    [Token(Token = "0x4007F87")]
    [FieldOffset(Offset = "0x1C4")]
    public int mrpa;
    [Token(Token = "0x4007F88")]
    [FieldOffset(Offset = "0x1C8")]
    public int mrst;
    [Token(Token = "0x4007F89")]
    [FieldOffset(Offset = "0x1CC")]
    public int mrsl;
    [Token(Token = "0x4007F8A")]
    [FieldOffset(Offset = "0x1D0")]
    public int mrch;
    [Token(Token = "0x4007F8B")]
    [FieldOffset(Offset = "0x1D4")]
    public int mrsn;
    [Token(Token = "0x4007F8C")]
    [FieldOffset(Offset = "0x1D8")]
    public int mrbl;
    [Token(Token = "0x4007F8D")]
    [FieldOffset(Offset = "0x1DC")]
    public int mrns;
    [Token(Token = "0x4007F8E")]
    [FieldOffset(Offset = "0x1E0")]
    public int mrnm;
    [Token(Token = "0x4007F8F")]
    [FieldOffset(Offset = "0x1E4")]
    public int mrna;
    [Token(Token = "0x4007F90")]
    [FieldOffset(Offset = "0x1E8")]
    public int mrzo;
    [Token(Token = "0x4007F91")]
    [FieldOffset(Offset = "0x1EC")]
    public int mrde;
    [Token(Token = "0x4007F92")]
    [FieldOffset(Offset = "0x1F0")]
    public int mrkn;
    [Token(Token = "0x4007F93")]
    [FieldOffset(Offset = "0x1F4")]
    public int mrdf;
    [Token(Token = "0x4007F94")]
    [FieldOffset(Offset = "0x1F8")]
    public int mrbe;
    [Token(Token = "0x4007F95")]
    [FieldOffset(Offset = "0x1FC")]
    public int mrcs;
    [Token(Token = "0x4007F96")]
    [FieldOffset(Offset = "0x200")]
    public int mrcu;
    [Token(Token = "0x4007F97")]
    [FieldOffset(Offset = "0x204")]
    public int mrcd;
    [Token(Token = "0x4007F98")]
    [FieldOffset(Offset = "0x208")]
    public int mrdo;
    [Token(Token = "0x4007F99")]
    [FieldOffset(Offset = "0x20C")]
    public int mrra;
    [Token(Token = "0x4007F9A")]
    [FieldOffset(Offset = "0x210")]
    public int mrsa;
    [Token(Token = "0x4007F9B")]
    [FieldOffset(Offset = "0x214")]
    public int mraa;
    [Token(Token = "0x4007F9C")]
    [FieldOffset(Offset = "0x218")]
    public int mrdc;
    [Token(Token = "0x4007F9D")]
    [FieldOffset(Offset = "0x21C")]
    public int mric;
    [Token(Token = "0x4007F9E")]
    [FieldOffset(Offset = "0x220")]
    public int mras;
    [Token(Token = "0x4007F9F")]
    [FieldOffset(Offset = "0x224")]
    public int mrab;
    [Token(Token = "0x4007FA0")]
    [FieldOffset(Offset = "0x228")]
    public int mror;
    [Token(Token = "0x4007FA1")]
    [FieldOffset(Offset = "0x22C")]
    public int mrft;
    [Token(Token = "0x4007FA2")]
    [FieldOffset(Offset = "0x230")]
    public int mdsu;
    [Token(Token = "0x4007FA3")]
    [FieldOffset(Offset = "0x234")]
    public int mrdh;
    [Token(Token = "0x4007FA4")]
    [FieldOffset(Offset = "0x238")]
    public int mbom;
    [Token(Token = "0x4007FA5")]
    [FieldOffset(Offset = "0x23C")]
    public int mslp;
    [Token(Token = "0x4007FA6")]
    [FieldOffset(Offset = "0x240")]
    public int mrfrz;
    [Token(Token = "0x4007FA7")]
    [FieldOffset(Offset = "0x244")]
    public int mdown;
    [Token(Token = "0x4007FA8")]
    [FieldOffset(Offset = "0x248")]
    public string ls1;
    [Token(Token = "0x4007FA9")]
    [FieldOffset(Offset = "0x24C")]
    public string ls2;
    [Token(Token = "0x4007FAA")]
    [FieldOffset(Offset = "0x250")]
    public string ls3;
    [Token(Token = "0x4007FAB")]
    [FieldOffset(Offset = "0x254")]
    public string ls4;
    [Token(Token = "0x4007FAC")]
    [FieldOffset(Offset = "0x258")]
    public string ls5;
    [Token(Token = "0x4007FAD")]
    [FieldOffset(Offset = "0x25C")]
    public string ls6;
    [Token(Token = "0x4007FAE")]
    [FieldOffset(Offset = "0x260")]
    public string recipe1;
    [Token(Token = "0x4007FAF")]
    [FieldOffset(Offset = "0x264")]
    public string recipe2;
    [Token(Token = "0x4007FB0")]
    [FieldOffset(Offset = "0x268")]
    public string recipe3;
    [Token(Token = "0x4007FB1")]
    [FieldOffset(Offset = "0x26C")]
    public string recipe4;
    [Token(Token = "0x4007FB2")]
    [FieldOffset(Offset = "0x270")]
    public string recipe5;
    [Token(Token = "0x4007FB3")]
    [FieldOffset(Offset = "0x274")]
    public string recipe6;
    [Token(Token = "0x4007FB4")]
    [FieldOffset(Offset = "0x278")]
    public string img;
    [Token(Token = "0x4007FB5")]
    [FieldOffset(Offset = "0x27C")]
    public string vce;
    [Token(Token = "0x4007FB6")]
    [FieldOffset(Offset = "0x280")]
    public string dskl;
    [Token(Token = "0x4007FB7")]
    [FieldOffset(Offset = "0x284")]
    public string[] dabi;
    [Token(Token = "0x4007FB8")]
    [FieldOffset(Offset = "0x288")]
    public string djob;
    [Token(Token = "0x4007FB9")]
    [FieldOffset(Offset = "0x28C")]
    public string dbuki;
    [Token(Token = "0x4007FBA")]
    [FieldOffset(Offset = "0x290")]
    public int jt;
    [Token(Token = "0x4007FBB")]
    [FieldOffset(Offset = "0x294")]
    public int role;
    [Token(Token = "0x4007FBC")]
    [FieldOffset(Offset = "0x298")]
    public int mov;
    [Token(Token = "0x4007FBD")]
    [FieldOffset(Offset = "0x29C")]
    public int jmp;
    [Token(Token = "0x4007FBE")]
    [FieldOffset(Offset = "0x2A0")]
    public int inimp;
    [Token(Token = "0x4007FBF")]
    [FieldOffset(Offset = "0x2A4")]
    public int ma_rarity;
    [Token(Token = "0x4007FC0")]
    [FieldOffset(Offset = "0x2A8")]
    public int ma_lv;
    [Token(Token = "0x4007FC1")]
    [FieldOffset(Offset = "0x2AC")]
    public string[] skins;
    [Token(Token = "0x4007FC2")]
    [FieldOffset(Offset = "0x2B0")]
    public string[] jidx;
    [Token(Token = "0x4007FC3")]
    [FieldOffset(Offset = "0x2B4")]
    public string[] jimgs;
    [Token(Token = "0x4007FC4")]
    [FieldOffset(Offset = "0x2B8")]
    public string[] jvcs;
    [Token(Token = "0x4007FC5")]
    [FieldOffset(Offset = "0x2BC")]
    public int no_trw;
    [Token(Token = "0x4007FC6")]
    [FieldOffset(Offset = "0x2C0")]
    public int no_kb;
    [Token(Token = "0x4007FC7")]
    [FieldOffset(Offset = "0x2C4")]
    public int no_chg;
    [Token(Token = "0x4007FC8")]
    [FieldOffset(Offset = "0x2C8")]
    public string unlck_t;
    [Token(Token = "0x4007FC9")]
    [FieldOffset(Offset = "0x2CC")]
    public int no_insp;
    [Token(Token = "0x4007FCA")]
    [FieldOffset(Offset = "0x2D0")]
    public int no_recommended;
    [Token(Token = "0x4007FCB")]
    [FieldOffset(Offset = "0x2D4")]
    public string unit_piece_shop_group;
    [Token(Token = "0x4007FCC")]
    [FieldOffset(Offset = "0x2D8")]
    public int no_pass;
    [Token(Token = "0x4007FCD")]
    [FieldOffset(Offset = "0x2DC")]
    public string truth_equipment_iname;
    [Token(Token = "0x4007FCE")]
    [FieldOffset(Offset = "0x2E0")]
    public int ele_plus;
    [Token(Token = "0x4007FCF")]
    [FieldOffset(Offset = "0x2E4")]
    public string rune_pride_pattern;
    [Token(Token = "0x4007FD0")]
    [FieldOffset(Offset = "0x2E8")]
    public string is_ignore_search;

    [Token(Token = "0x6007D6F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_UnitParam()
    {
    }
  }
}
