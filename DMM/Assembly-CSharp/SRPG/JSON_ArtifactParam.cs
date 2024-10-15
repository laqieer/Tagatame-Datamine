// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200198E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ArtifactParam
  {
    [Token(Token = "0x4005D20")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005D21")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4005D22")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4005D23")]
    [FieldOffset(Offset = "0x14")]
    public string flavor;
    [Token(Token = "0x4005D24")]
    [FieldOffset(Offset = "0x18")]
    public string spec;
    [Token(Token = "0x4005D25")]
    [FieldOffset(Offset = "0x1C")]
    public string asset;
    [Token(Token = "0x4005D26")]
    [FieldOffset(Offset = "0x20")]
    public string voice;
    [Token(Token = "0x4005D27")]
    [FieldOffset(Offset = "0x24")]
    public string icon;
    [Token(Token = "0x4005D28")]
    [FieldOffset(Offset = "0x28")]
    public int type;
    [Token(Token = "0x4005D29")]
    [FieldOffset(Offset = "0x2C")]
    public int rini;
    [Token(Token = "0x4005D2A")]
    [FieldOffset(Offset = "0x30")]
    public int rmax;
    [Token(Token = "0x4005D2B")]
    [FieldOffset(Offset = "0x34")]
    public string kakera;
    [Token(Token = "0x4005D2C")]
    [FieldOffset(Offset = "0x38")]
    public int notsmn;
    [Token(Token = "0x4005D2D")]
    [FieldOffset(Offset = "0x3C")]
    public int maxnum;
    [Token(Token = "0x4005D2E")]
    [FieldOffset(Offset = "0x40")]
    public string[] skills;
    [Token(Token = "0x4005D2F")]
    [FieldOffset(Offset = "0x44")]
    public string equip1;
    [Token(Token = "0x4005D30")]
    [FieldOffset(Offset = "0x48")]
    public string equip2;
    [Token(Token = "0x4005D31")]
    [FieldOffset(Offset = "0x4C")]
    public string equip3;
    [Token(Token = "0x4005D32")]
    [FieldOffset(Offset = "0x50")]
    public string equip4;
    [Token(Token = "0x4005D33")]
    [FieldOffset(Offset = "0x54")]
    public string equip5;
    [Token(Token = "0x4005D34")]
    [FieldOffset(Offset = "0x58")]
    public string attack1;
    [Token(Token = "0x4005D35")]
    [FieldOffset(Offset = "0x5C")]
    public string attack2;
    [Token(Token = "0x4005D36")]
    [FieldOffset(Offset = "0x60")]
    public string attack3;
    [Token(Token = "0x4005D37")]
    [FieldOffset(Offset = "0x64")]
    public string attack4;
    [Token(Token = "0x4005D38")]
    [FieldOffset(Offset = "0x68")]
    public string attack5;
    [Token(Token = "0x4005D39")]
    [FieldOffset(Offset = "0x6C")]
    public string[] abils;
    [Token(Token = "0x4005D3A")]
    [FieldOffset(Offset = "0x70")]
    public int[] abshows;
    [Token(Token = "0x4005D3B")]
    [FieldOffset(Offset = "0x74")]
    public int[] ablvs;
    [Token(Token = "0x4005D3C")]
    [FieldOffset(Offset = "0x78")]
    public int[] abrares;
    [Token(Token = "0x4005D3D")]
    [FieldOffset(Offset = "0x7C")]
    public string[] abconds;
    [Token(Token = "0x4005D3E")]
    [FieldOffset(Offset = "0x80")]
    public int kc;
    [Token(Token = "0x4005D3F")]
    [FieldOffset(Offset = "0x84")]
    public int tc;
    [Token(Token = "0x4005D40")]
    [FieldOffset(Offset = "0x88")]
    public int ac;
    [Token(Token = "0x4005D41")]
    [FieldOffset(Offset = "0x8C")]
    public int mc;
    [Token(Token = "0x4005D42")]
    [FieldOffset(Offset = "0x90")]
    public int pp;
    [Token(Token = "0x4005D43")]
    [FieldOffset(Offset = "0x94")]
    public int buy;
    [Token(Token = "0x4005D44")]
    [FieldOffset(Offset = "0x98")]
    public int sell;
    [Token(Token = "0x4005D45")]
    [FieldOffset(Offset = "0x9C")]
    public int ecost;
    [Token(Token = "0x4005D46")]
    [FieldOffset(Offset = "0xA0")]
    public string tag;
    [Token(Token = "0x4005D47")]
    [FieldOffset(Offset = "0xA4")]
    public string eqcond;
    [Token(Token = "0x4005D48")]
    [FieldOffset(Offset = "0xA8")]
    public string[] units;
    [Token(Token = "0x4005D49")]
    [FieldOffset(Offset = "0xAC")]
    public string[] jobs;
    [Token(Token = "0x4005D4A")]
    [FieldOffset(Offset = "0xB0")]
    public string birth;
    [Token(Token = "0x4005D4B")]
    [FieldOffset(Offset = "0xB4")]
    public int sex;
    [Token(Token = "0x4005D4C")]
    [FieldOffset(Offset = "0xB8")]
    public int elem;
    [Token(Token = "0x4005D4D")]
    [FieldOffset(Offset = "0xBC")]
    public int eqlv;
    [Token(Token = "0x4005D4E")]
    [FieldOffset(Offset = "0xC0")]
    public int eqrmin;
    [Token(Token = "0x4005D4F")]
    [FieldOffset(Offset = "0xC4")]
    public int eqrmax;
    [Token(Token = "0x4005D50")]
    [FieldOffset(Offset = "0xC8")]
    public string cond_sm;
    [Token(Token = "0x4005D51")]
    [FieldOffset(Offset = "0xCC")]
    public int skin_hide;
    [Token(Token = "0x4005D52")]
    [FieldOffset(Offset = "0xD0")]
    public string insp_skill;
    [Token(Token = "0x4005D53")]
    [FieldOffset(Offset = "0xD4")]
    public int insp_lv_bonus;
    [Token(Token = "0x4005D54")]
    [FieldOffset(Offset = "0xD8")]
    public int gallery_view;
    [Token(Token = "0x4005D55")]
    [FieldOffset(Offset = "0xDC")]
    public int stone_no_open;
    [Token(Token = "0x4005D56")]
    [FieldOffset(Offset = "0xE0")]
    public int stone_no_ch;
    [Token(Token = "0x4005D57")]
    [FieldOffset(Offset = "0xE4")]
    public int[] stone_conversion_item_counts;

    [Token(Token = "0x6006821")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ArtifactParam()
    {
    }
  }
}
