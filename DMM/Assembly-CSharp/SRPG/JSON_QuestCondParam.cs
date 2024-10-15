// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C37")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_QuestCondParam
  {
    [Token(Token = "0x4006D8C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D8D")]
    [FieldOffset(Offset = "0xC")]
    public int plvmax;
    [Token(Token = "0x4006D8E")]
    [FieldOffset(Offset = "0x10")]
    public int plvmin;
    [Token(Token = "0x4006D8F")]
    [FieldOffset(Offset = "0x14")]
    public int ulvmax;
    [Token(Token = "0x4006D90")]
    [FieldOffset(Offset = "0x18")]
    public int ulvmin;
    [Token(Token = "0x4006D91")]
    [FieldOffset(Offset = "0x1C")]
    public int el_none;
    [Token(Token = "0x4006D92")]
    [FieldOffset(Offset = "0x20")]
    public int el_fire;
    [Token(Token = "0x4006D93")]
    [FieldOffset(Offset = "0x24")]
    public int el_watr;
    [Token(Token = "0x4006D94")]
    [FieldOffset(Offset = "0x28")]
    public int el_wind;
    [Token(Token = "0x4006D95")]
    [FieldOffset(Offset = "0x2C")]
    public int el_thdr;
    [Token(Token = "0x4006D96")]
    [FieldOffset(Offset = "0x30")]
    public int el_lit;
    [Token(Token = "0x4006D97")]
    [FieldOffset(Offset = "0x34")]
    public int el_drk;
    [Token(Token = "0x4006D98")]
    [FieldOffset(Offset = "0x38")]
    public string[] job;
    [Token(Token = "0x4006D99")]
    [FieldOffset(Offset = "0x3C")]
    public int party_type;
    [Token(Token = "0x4006D9A")]
    [FieldOffset(Offset = "0x40")]
    public string[] unit;
    [Token(Token = "0x4006D9B")]
    [FieldOffset(Offset = "0x44")]
    public int sex;
    [Token(Token = "0x4006D9C")]
    [FieldOffset(Offset = "0x48")]
    public int rmax;
    [Token(Token = "0x4006D9D")]
    [FieldOffset(Offset = "0x4C")]
    public int rmin;
    [Token(Token = "0x4006D9E")]
    [FieldOffset(Offset = "0x50")]
    public int rmax_ini;
    [Token(Token = "0x4006D9F")]
    [FieldOffset(Offset = "0x54")]
    public int rmin_ini;
    [Token(Token = "0x4006DA0")]
    [FieldOffset(Offset = "0x58")]
    public int hmax;
    [Token(Token = "0x4006DA1")]
    [FieldOffset(Offset = "0x5C")]
    public int hmin;
    [Token(Token = "0x4006DA2")]
    [FieldOffset(Offset = "0x60")]
    public int wmax;
    [Token(Token = "0x4006DA3")]
    [FieldOffset(Offset = "0x64")]
    public int wmin;
    [Token(Token = "0x4006DA4")]
    [FieldOffset(Offset = "0x68")]
    public int jobset1;
    [Token(Token = "0x4006DA5")]
    [FieldOffset(Offset = "0x6C")]
    public int jobset2;
    [Token(Token = "0x4006DA6")]
    [FieldOffset(Offset = "0x70")]
    public int jobset3;
    [Token(Token = "0x4006DA7")]
    [FieldOffset(Offset = "0x74")]
    public string[] birth;
    [Token(Token = "0x4006DA8")]
    [FieldOffset(Offset = "0x78")]
    public int not_solo;

    [Token(Token = "0x600740E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestCondParam()
    {
    }
  }
}
