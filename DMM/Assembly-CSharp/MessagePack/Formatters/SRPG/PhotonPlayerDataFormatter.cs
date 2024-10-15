// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PhotonPlayerDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F3")]
  public sealed class PhotonPlayerDataFormatter : 
    IMessagePackFormatter<PhotonPlayerData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001476")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001477")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002127")]
    [Address(RVA = "0xD37CA0", Offset = "0xD36AA0", VA = "0x10D37CA0")]
    public PhotonPlayerDataFormatter()
    {
    }

    [Token(Token = "0x6002128")]
    [Address(RVA = "0xD374F0", Offset = "0xD362F0", VA = "0x10D374F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonPlayerData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002129")]
    [Address(RVA = "0xD36C70", Offset = "0xD35A70", VA = "0x10D36C70", Slot = "5")]
    public PhotonPlayerData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PhotonPlayerData) null;
    }
  }
}
