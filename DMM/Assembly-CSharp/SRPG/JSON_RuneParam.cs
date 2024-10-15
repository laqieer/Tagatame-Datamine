// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD2")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneParam
  {
    [Token(Token = "0x40070F7")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40070F8")]
    [FieldOffset(Offset = "0xC")]
    public string item_iname;
    [Token(Token = "0x40070F9")]
    [FieldOffset(Offset = "0x10")]
    public int slot;
    [Token(Token = "0x40070FA")]
    [FieldOffset(Offset = "0x14")]
    public int seteff_type;
    [Token(Token = "0x40070FB")]
    [FieldOffset(Offset = "0x18")]
    public string base_state;
    [Token(Token = "0x40070FC")]
    [FieldOffset(Offset = "0x1C")]
    public string evo_state;

    [Token(Token = "0x600768D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneParam()
    {
    }
  }
}
