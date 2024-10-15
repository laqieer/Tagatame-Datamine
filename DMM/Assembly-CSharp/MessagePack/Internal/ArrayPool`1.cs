// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ArrayPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000459")]
  internal class ArrayPool<T>
  {
    [Token(Token = "0x4000ECC")]
    [FieldOffset(Offset = "0x0")]
    private readonly int bufferLength;
    [Token(Token = "0x4000ECD")]
    [FieldOffset(Offset = "0x0")]
    private readonly object gate;
    [Token(Token = "0x4000ECE")]
    [FieldOffset(Offset = "0x0")]
    private int index;
    [Token(Token = "0x4000ECF")]
    [FieldOffset(Offset = "0x0")]
    private T[][] buffers;

    [Token(Token = "0x6001558")]
    public ArrayPool(int bufferLength)
    {
    }

    [Token(Token = "0x6001559")]
    public T[] Rent() => (T[]) null;

    [Token(Token = "0x600155A")]
    public void Return(T[] array)
    {
    }
  }
}
