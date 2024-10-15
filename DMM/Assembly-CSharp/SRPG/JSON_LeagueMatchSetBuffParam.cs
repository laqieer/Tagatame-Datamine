// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchSetBuffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BB1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchSetBuffParam
  {
    [Token(Token = "0x40069F5")]
    [FieldOffset(Offset = "0x8")]
    public int target;
    [Token(Token = "0x40069F6")]
    [FieldOffset(Offset = "0xC")]
    public string buff_iname;
    [Token(Token = "0x40069F7")]
    [FieldOffset(Offset = "0x10")]
    public string icon_name;
    [Token(Token = "0x40069F8")]
    [FieldOffset(Offset = "0x14")]
    public string buff_name;
    [Token(Token = "0x40069F9")]
    [FieldOffset(Offset = "0x18")]
    public string buff_description;
    [Token(Token = "0x40069FA")]
    [FieldOffset(Offset = "0x1C")]
    public int num;
    [Token(Token = "0x40069FB")]
    [FieldOffset(Offset = "0x20")]
    public int select_set;

    [Token(Token = "0x6007258")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchSetBuffParam()
    {
    }
  }
}
