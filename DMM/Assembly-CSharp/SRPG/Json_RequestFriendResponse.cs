// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RequestFriendResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015CA")]
  public class Json_RequestFriendResponse
  {
    [Token(Token = "0x4004F44")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x4004F45")]
    [FieldOffset(Offset = "0xC")]
    public Json_RequestFriendErrors errors;
    [Token(Token = "0x4004F46")]
    [FieldOffset(Offset = "0x10")]
    public string[] blocks;

    [Token(Token = "0x600599B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RequestFriendResponse()
    {
    }
  }
}
