// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ArchiveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001987")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ArchiveParam
  {
    [Token(Token = "0x4005CF7")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005CF8")]
    [FieldOffset(Offset = "0xC")]
    public string[] area_inames;
    [Token(Token = "0x4005CF9")]
    [FieldOffset(Offset = "0x10")]
    public string area_iname_multi;
    [Token(Token = "0x4005CFA")]
    [FieldOffset(Offset = "0x14")]
    public int type;
    [Token(Token = "0x4005CFB")]
    [FieldOffset(Offset = "0x18")]
    public string[] missions;
    [Token(Token = "0x4005CFC")]
    [FieldOffset(Offset = "0x1C")]
    public string begin_at;
    [Token(Token = "0x4005CFD")]
    [FieldOffset(Offset = "0x20")]
    public string end_at;
    [Token(Token = "0x4005CFE")]
    [FieldOffset(Offset = "0x24")]
    public string keyitem1;
    [Token(Token = "0x4005CFF")]
    [FieldOffset(Offset = "0x28")]
    public int keynum1;
    [Token(Token = "0x4005D00")]
    [FieldOffset(Offset = "0x2C")]
    public int keytime;
    [Token(Token = "0x4005D01")]
    [FieldOffset(Offset = "0x30")]
    public string unit1;
    [Token(Token = "0x4005D02")]
    [FieldOffset(Offset = "0x34")]
    public string unit2;
    [Token(Token = "0x4005D03")]
    [FieldOffset(Offset = "0x38")]
    public JSON_ArchiveItemsParam[] items;

    [Token(Token = "0x6006808")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ArchiveParam()
    {
    }
  }
}
