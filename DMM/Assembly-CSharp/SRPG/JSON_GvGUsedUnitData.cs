// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGUsedUnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025B3")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGUsedUnitData
  {
    [Token(Token = "0x400AEFD")]
    [FieldOffset(Offset = "0x8")]
    public int uiid;
    [Token(Token = "0x400AEFE")]
    [FieldOffset(Offset = "0xC")]
    public string limit;
    [Token(Token = "0x400AEFF")]
    [FieldOffset(Offset = "0x10")]
    public string used;

    [Token(Token = "0x600A75C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGUsedUnitData()
    {
    }
  }
}
