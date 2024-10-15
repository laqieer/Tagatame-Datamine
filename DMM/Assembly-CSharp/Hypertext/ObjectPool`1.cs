// Decompiled with JetBrains decompiler
// Type: Hypertext.ObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Hypertext
{
  [Token(Token = "0x2000B46")]
  public class ObjectPool<T> where T : new()
  {
    [Token(Token = "0x4001B28")]
    [FieldOffset(Offset = "0x0")]
    private readonly Stack<T> stack;
    [Token(Token = "0x4001B29")]
    [FieldOffset(Offset = "0x0")]
    private readonly Action<T> onGet;
    [Token(Token = "0x4001B2A")]
    [FieldOffset(Offset = "0x0")]
    private readonly Action<T> onRelease;

    [Token(Token = "0x17000214")]
    public int CountAll
    {
      [Token(Token = "0x6002B28")] get => new int();
      [Token(Token = "0x6002B29")] set
      {
      }
    }

    [Token(Token = "0x17000215")]
    public int CountActive
    {
      [Token(Token = "0x6002B2A")] get => new int();
    }

    [Token(Token = "0x17000216")]
    public int CountInactive
    {
      [Token(Token = "0x6002B2B")] get => new int();
    }

    [Token(Token = "0x6002B2C")]
    public ObjectPool(Action<T> onGet, Action<T> onRelease)
    {
    }

    [Token(Token = "0x6002B2D")]
    public T Get() => (T) null;

    [Token(Token = "0x6002B2E")]
    public void Release(T element)
    {
    }
  }
}
