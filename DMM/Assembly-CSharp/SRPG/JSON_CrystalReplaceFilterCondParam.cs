// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalReplaceFilterCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A92")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalReplaceFilterCondParam
  {
    [Token(Token = "0x4006266")]
    [FieldOffset(Offset = "0x8")]
    public int filter_type;
    [Token(Token = "0x4006267")]
    [FieldOffset(Offset = "0xC")]
    public string cnds_iname;
    [Token(Token = "0x4006268")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4006269")]
    [FieldOffset(Offset = "0x14")]
    public int param;
    [Token(Token = "0x400626A")]
    [FieldOffset(Offset = "0x18")]
    public int rank;
    [Token(Token = "0x400626B")]
    [FieldOffset(Offset = "0x1C")]
    public int set_bonus_param;
    [Token(Token = "0x400626C")]
    [FieldOffset(Offset = "0x20")]
    public int[] party_types;

    [Token(Token = "0x6006D52")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalReplaceFilterCondParam()
    {
    }
  }
}
