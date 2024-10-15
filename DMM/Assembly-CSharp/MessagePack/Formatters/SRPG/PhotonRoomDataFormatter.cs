// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PhotonRoomDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009CF")]
  public sealed class PhotonRoomDataFormatter : 
    IMessagePackFormatter<PhotonRoomData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400182E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400182F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026BB")]
    [Address(RVA = "0xE76D90", Offset = "0xE75B90", VA = "0x10E76D90")]
    public PhotonRoomDataFormatter()
    {
    }

    [Token(Token = "0x60026BC")]
    [Address(RVA = "0xE76640", Offset = "0xE75440", VA = "0x10E76640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonRoomData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026BD")]
    [Address(RVA = "0xE75DB0", Offset = "0xE74BB0", VA = "0x10E75DB0", Slot = "5")]
    public PhotonRoomData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PhotonRoomData) null;
    }
  }
}
