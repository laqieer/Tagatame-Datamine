// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GoogleReview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018C9")]
  public class Json_GoogleReview
  {
    [Token(Token = "0x4005965")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x4005966")]
    [FieldOffset(Offset = "0xC")]
    public Json_Unit[] units;
    [Token(Token = "0x4005967")]
    [FieldOffset(Offset = "0x10")]
    public Json_Item[] items;
    [Token(Token = "0x4005968")]
    [FieldOffset(Offset = "0x14")]
    public Json_Mail[] mails;

    [Token(Token = "0x6006379")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GoogleReview()
    {
    }
  }
}
