// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TutorialSkipResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007EB")]
  public sealed class TutorialSkipResponseFormatter : 
    IMessagePackFormatter<TutorialSkipResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001466")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001467")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600210F")]
    [Address(RVA = "0xD3D9F0", Offset = "0xD3C7F0", VA = "0x10D3D9F0")]
    public TutorialSkipResponseFormatter()
    {
    }

    [Token(Token = "0x6002110")]
    [Address(RVA = "0xD3D700", Offset = "0xD3C500", VA = "0x10D3D700", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TutorialSkipResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002111")]
    [Address(RVA = "0xD3D2D0", Offset = "0xD3C0D0", VA = "0x10D3D2D0", Slot = "5")]
    public TutorialSkipResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TutorialSkipResponse) null;
    }
  }
}
