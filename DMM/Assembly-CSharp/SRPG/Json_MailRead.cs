// Decompiled with JetBrains decompiler
// Type: SRPG.Json_MailRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018C8")]
  public class Json_MailRead
  {
    [Token(Token = "0x400595F")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x4005960")]
    [FieldOffset(Offset = "0xC")]
    public Json_Unit[] units;
    [Token(Token = "0x4005961")]
    [FieldOffset(Offset = "0x10")]
    public Json_Item[] items;
    [Token(Token = "0x4005962")]
    [FieldOffset(Offset = "0x14")]
    public Json_Friend[] friends;
    [Token(Token = "0x4005963")]
    [FieldOffset(Offset = "0x18")]
    public Json_Artifact[] artifacts;
    [Token(Token = "0x4005964")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Mail[] processed;

    [Token(Token = "0x6006378")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_MailRead()
    {
    }
  }
}
