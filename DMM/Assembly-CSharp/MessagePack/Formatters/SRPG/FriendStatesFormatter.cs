// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FriendStatesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200058D")]
  public sealed class FriendStatesFormatter : 
    IMessagePackFormatter<FriendStates>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019F5")]
    [Address(RVA = "0x78F3B0", Offset = "0x78E1B0", VA = "0x1078F3B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FriendStates value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019F6")]
    [Address(RVA = "0x78F360", Offset = "0x78E160", VA = "0x1078F360", Slot = "5")]
    public FriendStates Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new FriendStates();
    }

    [Token(Token = "0x60019F7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FriendStatesFormatter()
    {
    }
  }
}
