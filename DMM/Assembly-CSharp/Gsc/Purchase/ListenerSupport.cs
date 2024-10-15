// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.ListenerSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F5")]
  public static class ListenerSupport
  {
    [Token(Token = "0x600F07F")]
    [Address(RVA = "0xB0BF30", Offset = "0xB0AD30", VA = "0x10B0BF30")]
    private static bool IsAliveMethod(bool enabledInactiveCallback, Delegate method) => new bool();

    [Token(Token = "0x600F080")]
    public static bool IsAliveObject<T>(bool enabledInactiveCallback, T obj) => new bool();

    [Token(Token = "0x600F081")]
    [Address(RVA = "0xB0BED0", Offset = "0xB0ACD0", VA = "0x10B0BED0")]
    public static bool Call(bool enabledInactiveCallback, Action method) => new bool();

    [Token(Token = "0x600F082")]
    public static bool Call<T1>(bool enabledInactiveCallback, Action<T1> method, T1 arg1)
    {
      return new bool();
    }

    [Token(Token = "0x600F083")]
    public static bool Call<T1, T2>(
      bool enabledInactiveCallback,
      Action<T1, T2> method,
      T1 arg1,
      T2 arg2)
    {
      return new bool();
    }

    [Token(Token = "0x600F084")]
    [Address(RVA = "0xB0BC50", Offset = "0xB0AA50", VA = "0x10B0BC50")]
    public static bool CallResult(
      bool enabledInactiveCallback,
      IPurchaseResultListener listener,
      ResultCode resultCode,
      FulfillmentResult result)
    {
      return new bool();
    }
  }
}
