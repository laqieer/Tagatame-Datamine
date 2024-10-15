// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RoomTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000595")]
  public sealed class RoomTypeFormatter : 
    IMessagePackFormatter<PhotonRoomData.RoomType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001A0D")]
    [Address(RVA = "0x7A4B90", Offset = "0x7A3990", VA = "0x107A4B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonRoomData.RoomType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A0E")]
    [Address(RVA = "0x7A4B40", Offset = "0x7A3940", VA = "0x107A4B40", Slot = "5")]
    public PhotonRoomData.RoomType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new PhotonRoomData.RoomType();
    }

    [Token(Token = "0x6001A0F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RoomTypeFormatter()
    {
    }
  }
}
