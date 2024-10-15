// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8Int16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003EC")]
  internal sealed class UInt8Int16 : IInt16Decoder
  {
    [Token(Token = "0x4000E46")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x600140F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8Int16()
    {
    }

    [Token(Token = "0x6001410")]
    [Address(RVA = "0x5CC880", Offset = "0x5CB680", VA = "0x105CC880", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x6001411")]
    [Address(RVA = "0x5CC8B0", Offset = "0x5CB6B0", VA = "0x105CC8B0")]
    static UInt8Int16()
    {
    }
  }
}
