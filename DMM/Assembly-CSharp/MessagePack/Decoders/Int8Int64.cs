// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int8Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000402")]
  internal sealed class Int8Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E5A")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x600144D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int8Int64()
    {
    }

    [Token(Token = "0x600144E")]
    [Address(RVA = "0x5C2A60", Offset = "0x5C1860", VA = "0x105C2A60", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x600144F")]
    [Address(RVA = "0x5C2A90", Offset = "0x5C1890", VA = "0x105C2A90")]
    static Int8Int64()
    {
    }
  }
}
