// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CondEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DEA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CondEffectParam
  {
    [Token(Token = "0x4007846")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007847")]
    [FieldOffset(Offset = "0xC")]
    public string job;
    [Token(Token = "0x4007848")]
    [FieldOffset(Offset = "0x10")]
    public string buki;
    [Token(Token = "0x4007849")]
    [FieldOffset(Offset = "0x14")]
    public string birth;
    [Token(Token = "0x400784A")]
    [FieldOffset(Offset = "0x18")]
    public int sex;
    [Token(Token = "0x400784B")]
    [FieldOffset(Offset = "0x1C")]
    public int elem;
    [Token(Token = "0x400784C")]
    [FieldOffset(Offset = "0x20")]
    public int cond;
    [Token(Token = "0x400784D")]
    [FieldOffset(Offset = "0x24")]
    public int type;
    [Token(Token = "0x400784E")]
    [FieldOffset(Offset = "0x28")]
    public int vini;
    [Token(Token = "0x400784F")]
    [FieldOffset(Offset = "0x2C")]
    public int vmax;
    [Token(Token = "0x4007850")]
    [FieldOffset(Offset = "0x30")]
    public int rini;
    [Token(Token = "0x4007851")]
    [FieldOffset(Offset = "0x34")]
    public int rmax;
    [Token(Token = "0x4007852")]
    [FieldOffset(Offset = "0x38")]
    public int tini;
    [Token(Token = "0x4007853")]
    [FieldOffset(Offset = "0x3C")]
    public int tmax;
    [Token(Token = "0x4007854")]
    [FieldOffset(Offset = "0x40")]
    public int chktgt;
    [Token(Token = "0x4007855")]
    [FieldOffset(Offset = "0x44")]
    public int timing;
    [Token(Token = "0x4007856")]
    [FieldOffset(Offset = "0x48")]
    public int[] conds;
    [Token(Token = "0x4007857")]
    [FieldOffset(Offset = "0x4C")]
    public int v_poi;
    [Token(Token = "0x4007858")]
    [FieldOffset(Offset = "0x50")]
    public int v_poifix;
    [Token(Token = "0x4007859")]
    [FieldOffset(Offset = "0x54")]
    public int v_par;
    [Token(Token = "0x400785A")]
    [FieldOffset(Offset = "0x58")]
    public int v_blihit;
    [Token(Token = "0x400785B")]
    [FieldOffset(Offset = "0x5C")]
    public int v_bliavo;
    [Token(Token = "0x400785C")]
    [FieldOffset(Offset = "0x60")]
    public int v_dea;
    [Token(Token = "0x400785D")]
    [FieldOffset(Offset = "0x64")]
    public int v_beratk;
    [Token(Token = "0x400785E")]
    [FieldOffset(Offset = "0x68")]
    public int v_berdef;
    [Token(Token = "0x400785F")]
    [FieldOffset(Offset = "0x6C")]
    public int v_fast;
    [Token(Token = "0x4007860")]
    [FieldOffset(Offset = "0x70")]
    public int v_slow;
    [Token(Token = "0x4007861")]
    [FieldOffset(Offset = "0x74")]
    public int v_don;
    [Token(Token = "0x4007862")]
    [FieldOffset(Offset = "0x78")]
    public int v_ahp;
    [Token(Token = "0x4007863")]
    [FieldOffset(Offset = "0x7C")]
    public int v_ahpfix;
    [Token(Token = "0x4007864")]
    [FieldOffset(Offset = "0x80")]
    public int v_amp;
    [Token(Token = "0x4007865")]
    [FieldOffset(Offset = "0x84")]
    public int v_ampfix;
    [Token(Token = "0x4007866")]
    [FieldOffset(Offset = "0x88")]
    public int curse;
    [Token(Token = "0x4007867")]
    [FieldOffset(Offset = "0x8C")]
    public string[] buffs;
    [Token(Token = "0x4007868")]
    [FieldOffset(Offset = "0x90")]
    public int is_lb_dupli;
    [Token(Token = "0x4007869")]
    [FieldOffset(Offset = "0x94")]
    public int is_lb_resist;
    [Token(Token = "0x400786A")]
    [FieldOffset(Offset = "0x98")]
    public string tag;
    [Token(Token = "0x400786B")]
    [FieldOffset(Offset = "0x9C")]
    public string un_group;
    [Token(Token = "0x400786C")]
    [FieldOffset(Offset = "0xA0")]
    public string[] custom_targets;

    [Token(Token = "0x6007A64")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CondEffectParam()
    {
    }
  }
}
