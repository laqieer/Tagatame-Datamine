// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalSortCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA2")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalSortCondParam
  {
    [Token(Token = "0x40062B5")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x40062B6")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40062B7")]
    [FieldOffset(Offset = "0x10")]
    public int sort_type;
    [Token(Token = "0x40062B8")]
    [FieldOffset(Offset = "0x14")]
    public int param_type;
    [Token(Token = "0x40062B9")]
    [FieldOffset(Offset = "0x18")]
    public string tag_name;

    [Token(Token = "0x6006DC4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalSortCondParam()
    {
    }
  }
}
