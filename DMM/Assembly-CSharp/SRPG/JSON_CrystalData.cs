// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200227C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalData
  {
    [Token(Token = "0x4009908")]
    [FieldOffset(Offset = "0x8")]
    public long id;
    [Token(Token = "0x4009909")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x400990A")]
    [FieldOffset(Offset = "0x14")]
    public int rank;
    [Token(Token = "0x400990B")]
    [FieldOffset(Offset = "0x18")]
    public int plus;
    [Token(Token = "0x400990C")]
    [FieldOffset(Offset = "0x1C")]
    public int slot;
    [Token(Token = "0x400990D")]
    [FieldOffset(Offset = "0x20")]
    public int favorite;
    [Token(Token = "0x400990E")]
    [FieldOffset(Offset = "0x24")]
    public int is_mail;

    [Token(Token = "0x6009341")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalData()
    {
    }
  }
}
