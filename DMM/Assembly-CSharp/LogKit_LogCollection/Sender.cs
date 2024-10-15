// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.Sender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x2003525")]
  public class Sender
  {
    [Token(Token = "0x400FC3C")]
    [FieldOffset(Offset = "0x8")]
    private readonly LinkedList<Guid> queue;
    [Token(Token = "0x400FC3D")]
    [FieldOffset(Offset = "0xC")]
    private readonly string key;

    [Token(Token = "0x600EB39")]
    [Address(RVA = "0xAF73F0", Offset = "0xAF61F0", VA = "0x10AF73F0")]
    public Sender(string key)
    {
    }

    [Token(Token = "0x600EB3A")]
    [Address(RVA = "0xAF6F90", Offset = "0xAF5D90", VA = "0x10AF6F90")]
    private void Init()
    {
    }

    [Token(Token = "0x600EB3B")]
    [Address(RVA = "0xAF6F10", Offset = "0xAF5D10", VA = "0x10AF6F10")]
    private static void FileDeleteThread(object data)
    {
    }

    [Token(Token = "0x600EB3C")]
    [Address(RVA = "0xAF72E0", Offset = "0xAF60E0", VA = "0x10AF72E0")]
    public void Push(Guid logId)
    {
    }

    [Token(Token = "0x600EB3D")]
    [Address(RVA = "0xAF7110", Offset = "0xAF5F10", VA = "0x10AF7110")]
    private void Pop(Guid logId)
    {
    }

    [Token(Token = "0x600EB3E")]
    [Address(RVA = "0xAF6680", Offset = "0xAF5480", VA = "0x10AF6680")]
    public void Emit()
    {
    }
  }
}
