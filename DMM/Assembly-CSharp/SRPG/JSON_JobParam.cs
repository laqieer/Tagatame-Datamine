// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_JobParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E0C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_JobParam
  {
    [Token(Token = "0x40079C3")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40079C4")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40079C5")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40079C6")]
    [FieldOffset(Offset = "0x14")]
    public string mdl;
    [Token(Token = "0x40079C7")]
    [FieldOffset(Offset = "0x18")]
    public string ac2d;
    [Token(Token = "0x40079C8")]
    [FieldOffset(Offset = "0x1C")]
    public string mdlp;
    [Token(Token = "0x40079C9")]
    [FieldOffset(Offset = "0x20")]
    public string pet;
    [Token(Token = "0x40079CA")]
    [FieldOffset(Offset = "0x24")]
    public string buki;
    [Token(Token = "0x40079CB")]
    [FieldOffset(Offset = "0x28")]
    public string origin;
    [Token(Token = "0x40079CC")]
    [FieldOffset(Offset = "0x2C")]
    public int type;
    [Token(Token = "0x40079CD")]
    [FieldOffset(Offset = "0x30")]
    public int role;
    [Token(Token = "0x40079CE")]
    [FieldOffset(Offset = "0x34")]
    public int jmov;
    [Token(Token = "0x40079CF")]
    [FieldOffset(Offset = "0x38")]
    public int jjmp;
    [Token(Token = "0x40079D0")]
    [FieldOffset(Offset = "0x3C")]
    public string wepmdl;
    [Token(Token = "0x40079D1")]
    [FieldOffset(Offset = "0x40")]
    public string atkskl;
    [Token(Token = "0x40079D2")]
    [FieldOffset(Offset = "0x44")]
    public string atkfi;
    [Token(Token = "0x40079D3")]
    [FieldOffset(Offset = "0x48")]
    public string atkwa;
    [Token(Token = "0x40079D4")]
    [FieldOffset(Offset = "0x4C")]
    public string atkwi;
    [Token(Token = "0x40079D5")]
    [FieldOffset(Offset = "0x50")]
    public string atkth;
    [Token(Token = "0x40079D6")]
    [FieldOffset(Offset = "0x54")]
    public string atksh;
    [Token(Token = "0x40079D7")]
    [FieldOffset(Offset = "0x58")]
    public string atkda;
    [Token(Token = "0x40079D8")]
    [FieldOffset(Offset = "0x5C")]
    public string fixabl;
    [Token(Token = "0x40079D9")]
    [FieldOffset(Offset = "0x60")]
    public string artifact;
    [Token(Token = "0x40079DA")]
    [FieldOffset(Offset = "0x64")]
    public string ai;
    [Token(Token = "0x40079DB")]
    [FieldOffset(Offset = "0x68")]
    public string master;
    [Token(Token = "0x40079DC")]
    [FieldOffset(Offset = "0x6C")]
    public string me_abl;
    [Token(Token = "0x40079DD")]
    [FieldOffset(Offset = "0x70")]
    public int is_me_rr;
    [Token(Token = "0x40079DE")]
    [FieldOffset(Offset = "0x74")]
    public string desc_ch;
    [Token(Token = "0x40079DF")]
    [FieldOffset(Offset = "0x78")]
    public string desc_ot;
    [Token(Token = "0x40079E0")]
    [FieldOffset(Offset = "0x7C")]
    public int hp;
    [Token(Token = "0x40079E1")]
    [FieldOffset(Offset = "0x80")]
    public int mp;
    [Token(Token = "0x40079E2")]
    [FieldOffset(Offset = "0x84")]
    public int atk;
    [Token(Token = "0x40079E3")]
    [FieldOffset(Offset = "0x88")]
    public int def;
    [Token(Token = "0x40079E4")]
    [FieldOffset(Offset = "0x8C")]
    public int mag;
    [Token(Token = "0x40079E5")]
    [FieldOffset(Offset = "0x90")]
    public int mnd;
    [Token(Token = "0x40079E6")]
    [FieldOffset(Offset = "0x94")]
    public int dex;
    [Token(Token = "0x40079E7")]
    [FieldOffset(Offset = "0x98")]
    public int spd;
    [Token(Token = "0x40079E8")]
    [FieldOffset(Offset = "0x9C")]
    public int cri;
    [Token(Token = "0x40079E9")]
    [FieldOffset(Offset = "0xA0")]
    public int luk;
    [Token(Token = "0x40079EA")]
    [FieldOffset(Offset = "0xA4")]
    public int avoid;
    [Token(Token = "0x40079EB")]
    [FieldOffset(Offset = "0xA8")]
    public int inimp;
    [Token(Token = "0x40079EC")]
    [FieldOffset(Offset = "0xAC")]
    public JSON_JobRankParam[] ranks;
    [Token(Token = "0x40079ED")]
    [FieldOffset(Offset = "0xB0")]
    public string unit_image;
    [Token(Token = "0x40079EE")]
    [FieldOffset(Offset = "0xB4")]
    public int mov_type;
    [Token(Token = "0x40079EF")]
    [FieldOffset(Offset = "0xB8")]
    public int is_riding;
    [Token(Token = "0x40079F0")]
    [FieldOffset(Offset = "0xBC")]
    public int no_pass;
    [Token(Token = "0x40079F1")]
    [FieldOffset(Offset = "0xC0")]
    public string[] tags;
    [Token(Token = "0x40079F2")]
    [FieldOffset(Offset = "0xC4")]
    public string buff;

    [Token(Token = "0x6007B58")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_JobParam()
    {
    }
  }
}
