// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptCardConditionsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A74")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ConceptCardConditionsParam
  {
    [Token(Token = "0x40061B0")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40061B1")]
    [FieldOffset(Offset = "0xC")]
    public int el_fire;
    [Token(Token = "0x40061B2")]
    [FieldOffset(Offset = "0x10")]
    public int el_watr;
    [Token(Token = "0x40061B3")]
    [FieldOffset(Offset = "0x14")]
    public int el_wind;
    [Token(Token = "0x40061B4")]
    [FieldOffset(Offset = "0x18")]
    public int el_thdr;
    [Token(Token = "0x40061B5")]
    [FieldOffset(Offset = "0x1C")]
    public int el_lit;
    [Token(Token = "0x40061B6")]
    [FieldOffset(Offset = "0x20")]
    public int el_drk;
    [Token(Token = "0x40061B7")]
    [FieldOffset(Offset = "0x24")]
    public string un_group;
    [Token(Token = "0x40061B8")]
    [FieldOffset(Offset = "0x28")]
    public int units_cnds_type;
    [Token(Token = "0x40061B9")]
    [FieldOffset(Offset = "0x2C")]
    public string job_group;
    [Token(Token = "0x40061BA")]
    [FieldOffset(Offset = "0x30")]
    public int jobs_cnds_type;
    [Token(Token = "0x40061BB")]
    [FieldOffset(Offset = "0x34")]
    public int sex;
    [Token(Token = "0x40061BC")]
    [FieldOffset(Offset = "0x38")]
    public int[] birth_id;

    [Token(Token = "0x6006CA7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptCardConditionsParam()
    {
    }
  }
}
