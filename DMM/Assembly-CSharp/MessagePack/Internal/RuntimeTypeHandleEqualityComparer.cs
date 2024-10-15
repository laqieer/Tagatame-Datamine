// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.RuntimeTypeHandleEqualityComparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200047A")]
  public class RuntimeTypeHandleEqualityComparer : IEqualityComparer<RuntimeTypeHandle>
  {
    [Token(Token = "0x4000F30")]
    [FieldOffset(Offset = "0x0")]
    public static IEqualityComparer<RuntimeTypeHandle> Default;

    [Token(Token = "0x6001646")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private RuntimeTypeHandleEqualityComparer()
    {
    }

    [Token(Token = "0x6001647")]
    [Address(RVA = "0x6A9B70", Offset = "0x6A8970", VA = "0x106A9B70", Slot = "4")]
    public bool Equals(RuntimeTypeHandle x, RuntimeTypeHandle y) => new bool();

    [Token(Token = "0x6001648")]
    [Address(RVA = "0x6A9B90", Offset = "0x6A8990", VA = "0x106A9B90", Slot = "5")]
    public int GetHashCode(RuntimeTypeHandle obj) => new int();

    [Token(Token = "0x6001649")]
    [Address(RVA = "0x6A9BB0", Offset = "0x6A89B0", VA = "0x106A9BB0")]
    static RuntimeTypeHandleEqualityComparer()
    {
    }
  }
}
