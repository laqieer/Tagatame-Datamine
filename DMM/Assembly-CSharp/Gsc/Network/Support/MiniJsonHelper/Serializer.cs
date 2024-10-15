// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Support.MiniJsonHelper.Serializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network.Support.MiniJsonHelper
{
  [Token(Token = "0x200359C")]
  public class Serializer
  {
    [Token(Token = "0x400FD7B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Serializer Instance;
    [Token(Token = "0x400FD7C")]
    [FieldOffset(Offset = "0x8")]
    private Stack<Delegate> stack;
    [Token(Token = "0x400FD7D")]
    [FieldOffset(Offset = "0xC")]
    private List<Delegate> functions;

    [Token(Token = "0x600EDCC")]
    [Address(RVA = "0xB117F0", Offset = "0xB105F0", VA = "0x10B117F0")]
    static Serializer()
    {
    }

    [Token(Token = "0x600EDCD")]
    [Address(RVA = "0xB118F0", Offset = "0xB106F0", VA = "0x10B118F0")]
    private Serializer()
    {
    }

    [Token(Token = "0x600EDCE")]
    public Serializer WithArray<T>() => (Serializer) null;

    [Token(Token = "0x600EDCF")]
    public Serializer WithArray<T>(Func<T, object> func) => (Serializer) null;

    [Token(Token = "0x600EDD0")]
    public Serializer WithDict<TKey, TValue>() => (Serializer) null;

    [Token(Token = "0x600EDD1")]
    public Serializer WithDict<TKey, TValue>(
      Func<TKey, object> keyFunc,
      Func<TValue, object> valueFunc)
    {
      return (Serializer) null;
    }

    [Token(Token = "0x600EDD2")]
    public Serializer Add<T>(Func<T, object> func) => (Serializer) null;

    [Token(Token = "0x600EDD3")]
    public object Serialize<T>(T source) => (object) null;

    [Token(Token = "0x600EDD4")]
    private object FromArray<T>(List<T> source) => (object) null;

    [Token(Token = "0x600EDD5")]
    private object FromDictionary<TKey, TValue>(Dictionary<TKey, TValue> source) => (object) null;

    [Token(Token = "0x600EDD6")]
    public static object FromObject<T>(T source) where T : IRequestObject => (object) null;

    [Token(Token = "0x600EDD7")]
    [Address(RVA = "0xB11740", Offset = "0xB10540", VA = "0x10B11740")]
    public static object FromDateTime(DateTime source) => (object) null;

    [Token(Token = "0x600EDD8")]
    public static object From<T>(T source) => (object) null;
  }
}
