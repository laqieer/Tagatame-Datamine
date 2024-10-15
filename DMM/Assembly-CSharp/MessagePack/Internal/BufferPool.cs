// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.BufferPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000458")]
  internal sealed class BufferPool : ArrayPool<byte>
  {
    [Token(Token = "0x4000ECB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly BufferPool Default;

    [Token(Token = "0x6001556")]
    [Address(RVA = "0x5BD170", Offset = "0x5BBF70", VA = "0x105BD170")]
    public BufferPool(int bufferLength)
    {
    }

    [Token(Token = "0x6001557")]
    [Address(RVA = "0x5BD0E0", Offset = "0x5BBEE0", VA = "0x105BD0E0")]
    static BufferPool()
    {
    }
  }
}
