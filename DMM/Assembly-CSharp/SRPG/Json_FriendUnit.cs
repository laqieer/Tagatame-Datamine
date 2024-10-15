// Decompiled with JetBrains decompiler
// Type: SRPG.Json_FriendUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001013")]
  public class Json_FriendUnit
  {
    [Token(Token = "0x400392E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400392F")]
    [FieldOffset(Offset = "0xC")]
    public int lv;
    [Token(Token = "0x4003930")]
    [FieldOffset(Offset = "0x10")]
    public int rare;
    [Token(Token = "0x4003931")]
    [FieldOffset(Offset = "0x14")]
    public int plus;
    [Token(Token = "0x4003932")]
    [FieldOffset(Offset = "0x18")]
    public Json_FriendSelectable select;

    [Token(Token = "0x6004277")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_FriendUnit()
    {
    }
  }
}
