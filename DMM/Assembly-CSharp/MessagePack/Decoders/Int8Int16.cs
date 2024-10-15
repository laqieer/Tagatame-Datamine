// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int8Int16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003EE")]
  internal sealed class Int8Int16 : IInt16Decoder
  {
    [Token(Token = "0x4000E48")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x6001415")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int8Int16()
    {
    }

    [Token(Token = "0x6001416")]
    [Address(RVA = "0x5C2940", Offset = "0x5C1740", VA = "0x105C2940", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x6001417")]
    [Address(RVA = "0x5C2970", Offset = "0x5C1770", VA = "0x105C2970")]
    static Int8Int16()
    {
    }
  }
}
