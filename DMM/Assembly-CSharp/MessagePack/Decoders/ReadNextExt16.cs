// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextExt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000454")]
  internal sealed class ReadNextExt16 : IReadNextDecoder
  {
    [Token(Token = "0x4000EA3")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001531")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextExt16()
    {
    }

    [Token(Token = "0x6001532")]
    [Address(RVA = "0x5C9870", Offset = "0x5C8670", VA = "0x105C9870", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001533")]
    [Address(RVA = "0x5C98B0", Offset = "0x5C86B0", VA = "0x105C98B0")]
    static ReadNextExt16()
    {
    }
  }
}
