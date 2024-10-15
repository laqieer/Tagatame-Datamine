// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.AddDeviceWithEmailAddressAndPasswordResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x200365C")]
  public struct AddDeviceWithEmailAddressAndPasswordResult
  {
    [Token(Token = "0x1700230B")]
    public AddDeviceWithEmailAddressAndPasswordResultCode ResultCode
    {
      [Token(Token = "0x600F308"), Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060")] readonly get
      {
        return new AddDeviceWithEmailAddressAndPasswordResultCode();
      }
      [Token(Token = "0x600F309"), Address(RVA = "0x2939C0", Offset = "0x2927C0", VA = "0x102939C0")] private set
      {
      }
    }

    [Token(Token = "0x1700230C")]
    public int LockedExpiresIn
    {
      [Token(Token = "0x600F30A"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600F30B"), Address(RVA = "0x2EC6B0", Offset = "0x2EB4B0", VA = "0x102EC6B0")] private set
      {
      }
    }

    [Token(Token = "0x1700230D")]
    public int TrialCounter
    {
      [Token(Token = "0x600F30C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600F30D"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x600F30E")]
    [Address(RVA = "0xB1E310", Offset = "0xB1D110", VA = "0x10B1E310")]
    public AddDeviceWithEmailAddressAndPasswordResult(
      AddDeviceWithEmailAddressAndPasswordResultCode resultCode)
    {
    }

    [Token(Token = "0x600F30F")]
    [Address(RVA = "0xB1E2F0", Offset = "0xB1D0F0", VA = "0x10B1E2F0")]
    public AddDeviceWithEmailAddressAndPasswordResult(
      AddDeviceWithEmailAddressAndPasswordResultCode resultCode,
      int lockedExpiresIn,
      int trialCounter)
    {
    }

    [Token(Token = "0x600F310")]
    [Address(RVA = "0x39DD30", Offset = "0x39CB30", VA = "0x1039DD30")]
    public static bool operator true(AddDeviceWithEmailAddressAndPasswordResult self) => new bool();

    [Token(Token = "0x600F311")]
    [Address(RVA = "0xB1E340", Offset = "0xB1D140", VA = "0x10B1E340")]
    public static bool operator false(AddDeviceWithEmailAddressAndPasswordResult self)
    {
      return new bool();
    }

    [Token(Token = "0x600F312")]
    [Address(RVA = "0xB1E330", Offset = "0xB1D130", VA = "0x10B1E330")]
    public static bool operator ==(
      AddDeviceWithEmailAddressAndPasswordResult self,
      AddDeviceWithEmailAddressAndPasswordResultCode resultCode)
    {
      return new bool();
    }

    [Token(Token = "0x600F313")]
    [Address(RVA = "0xB1E350", Offset = "0xB1D150", VA = "0x10B1E350")]
    public static bool operator !=(
      AddDeviceWithEmailAddressAndPasswordResult self,
      AddDeviceWithEmailAddressAndPasswordResultCode resultCode)
    {
      return new bool();
    }

    [Token(Token = "0x600F314")]
    [Address(RVA = "0xB1E230", Offset = "0xB1D030", VA = "0x10B1E230", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F315")]
    [Address(RVA = "0xB1E290", Offset = "0xB1D090", VA = "0x10B1E290", Slot = "2")]
    public override int GetHashCode() => new int();
  }
}
