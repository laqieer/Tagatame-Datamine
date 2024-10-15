// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixNegativeInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003FC")]
  internal sealed class FixNegativeInt64 : IInt64Decoder
  {
    [Token(Token = "0x4000E54")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x600143B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixNegativeInt64()
    {
    }

    [Token(Token = "0x600143C")]
    [Address(RVA = "0x5C0430", Offset = "0x5BF230", VA = "0x105C0430", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x600143D")]
    [Address(RVA = "0x5C0460", Offset = "0x5BF260", VA = "0x105C0460")]
    static FixNegativeInt64()
    {
    }
  }
}
