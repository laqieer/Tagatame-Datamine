// Decompiled with JetBrains decompiler
// Type: SRPG.Json_FriendList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200102F")]
  public class Json_FriendList
  {
    [Token(Token = "0x4003991")]
    [FieldOffset(Offset = "0x8")]
    public Json_Friend[] friends;
    [Token(Token = "0x4003992")]
    [FieldOffset(Offset = "0xC")]
    public int first_count;
    [Token(Token = "0x4003993")]
    [FieldOffset(Offset = "0x10")]
    public int follower_count;

    [Token(Token = "0x6004295")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_FriendList()
    {
    }
  }
}
