// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.RegisterEmailAddressAndPasswordResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x200365B")]
  public struct RegisterEmailAddressAndPasswordResult
  {
    [Token(Token = "0x1700230A")]
    public RegisterEmailAddressAndPasswordResultCode ResultCode
    {
      [Token(Token = "0x600F2FF"), Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060")] readonly get
      {
        return new RegisterEmailAddressAndPasswordResultCode();
      }
      [Token(Token = "0x600F300"), Address(RVA = "0x2939C0", Offset = "0x2927C0", VA = "0x102939C0")] private set
      {
      }
    }

    [Token(Token = "0x600F301")]
    [Address(RVA = "0x2939C0", Offset = "0x2927C0", VA = "0x102939C0")]
    public RegisterEmailAddressAndPasswordResult(
      RegisterEmailAddressAndPasswordResultCode resultCode)
    {
    }

    [Token(Token = "0x600F302")]
    [Address(RVA = "0x39DD30", Offset = "0x39CB30", VA = "0x1039DD30")]
    public static bool operator true(RegisterEmailAddressAndPasswordResult self) => new bool();

    [Token(Token = "0x600F303")]
    [Address(RVA = "0xB1E340", Offset = "0xB1D140", VA = "0x10B1E340")]
    public static bool operator false(RegisterEmailAddressAndPasswordResult self) => new bool();

    [Token(Token = "0x600F304")]
    [Address(RVA = "0xB2AE10", Offset = "0xB29C10", VA = "0x10B2AE10")]
    public static bool operator ==(
      RegisterEmailAddressAndPasswordResult self,
      RegisterEmailAddressAndPasswordResultCode resultCode)
    {
      return new bool();
    }

    [Token(Token = "0x600F305")]
    [Address(RVA = "0xB2AE20", Offset = "0xB29C20", VA = "0x10B2AE20")]
    public static bool operator !=(
      RegisterEmailAddressAndPasswordResult self,
      RegisterEmailAddressAndPasswordResultCode resultCode)
    {
      return new bool();
    }

    [Token(Token = "0x600F306")]
    [Address(RVA = "0xB2AD70", Offset = "0xB29B70", VA = "0x10B2AD70", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F307")]
    [Address(RVA = "0xB2ADC0", Offset = "0xB29BC0", VA = "0x10B2ADC0", Slot = "2")]
    public override int GetHashCode() => new int();
  }
}
