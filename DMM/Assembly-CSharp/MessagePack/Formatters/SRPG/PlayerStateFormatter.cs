// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PlayerStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200058E")]
  public sealed class PlayerStateFormatter : 
    IMessagePackFormatter<PhotonPlayerData.PlayerState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019F8")]
    [Address(RVA = "0x7A3E40", Offset = "0x7A2C40", VA = "0x107A3E40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonPlayerData.PlayerState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019F9")]
    [Address(RVA = "0x7A3DF0", Offset = "0x7A2BF0", VA = "0x107A3DF0", Slot = "5")]
    public PhotonPlayerData.PlayerState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new PhotonPlayerData.PlayerState();
    }

    [Token(Token = "0x60019FA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerStateFormatter()
    {
    }
  }
}
