// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.ResultCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035FC")]
  public enum ResultCode
  {
    [Token(Token = "0x400FE5D")] Succeeded,
    [Token(Token = "0x400FE5E")] Failed,
    [Token(Token = "0x400FE5F")] Unavailabled,
    [Token(Token = "0x400FE60")] Canceled,
    [Token(Token = "0x400FE61")] AlreadyOwned,
    [Token(Token = "0x400FE62")] Deferred,
    [Token(Token = "0x400FE63")] Pending,
    [Token(Token = "0x400FE64")] PendingExists,
    [Token(Token = "0x400FE65")] OverCreditLimit,
    [Token(Token = "0x400FE66")] InsufficientBalances,
  }
}
