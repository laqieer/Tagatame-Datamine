// Decompiled with JetBrains decompiler
// Type: SRPG.ArchiveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001989")]
  public class ArchiveParam
  {
    [Token(Token = "0x4005D06")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005D07")]
    [FieldOffset(Offset = "0xC")]
    public string[] area_inames;
    [Token(Token = "0x4005D08")]
    [FieldOffset(Offset = "0x10")]
    public string area_iname_multi;
    [Token(Token = "0x4005D09")]
    [FieldOffset(Offset = "0x14")]
    public ArchiveTypes type;
    [Token(Token = "0x4005D0A")]
    [FieldOffset(Offset = "0x18")]
    public string[] missions;
    [Token(Token = "0x4005D0B")]
    [FieldOffset(Offset = "0x20")]
    public DateTime begin_at;
    [Token(Token = "0x4005D0C")]
    [FieldOffset(Offset = "0x28")]
    public DateTime end_at;
    [Token(Token = "0x4005D0D")]
    [FieldOffset(Offset = "0x30")]
    public List<KeyItem> keys;
    [Token(Token = "0x4005D0E")]
    [FieldOffset(Offset = "0x34")]
    public int keytime;
    [Token(Token = "0x4005D0F")]
    [FieldOffset(Offset = "0x38")]
    public string unit1;
    [Token(Token = "0x4005D10")]
    [FieldOffset(Offset = "0x3C")]
    public string unit2;
    [Token(Token = "0x4005D11")]
    [FieldOffset(Offset = "0x40")]
    public ArchiveItemsParam[] items;

    [Token(Token = "0x600680A")]
    [Address(RVA = "0x31EB90", Offset = "0x31D990", VA = "0x1031EB90")]
    public void Deserialize(JSON_ArchiveParam json)
    {
    }

    [Token(Token = "0x600680B")]
    [Address(RVA = "0x31EF60", Offset = "0x31DD60", VA = "0x1031EF60")]
    public bool IsAvailable() => new bool();

    [Token(Token = "0x600680C")]
    [Address(RVA = "0x31E880", Offset = "0x31D680", VA = "0x1031E880")]
    public bool ArePrerequsiteQuestsCleared(bool isHiddenCheck = true) => new bool();

    [Token(Token = "0x17000AC5")]
    public bool IsAreas
    {
      [Token(Token = "0x600680D"), Address(RVA = "0x31F030", Offset = "0x31DE30", VA = "0x1031F030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600680E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArchiveParam()
    {
    }
  }
}
