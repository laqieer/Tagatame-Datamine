// Decompiled with JetBrains decompiler
// Type: Gsc.Device.AccountManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Device
{
  [Token(Token = "0x20035DC")]
  public class AccountManager : IAccountManager
  {
    [Token(Token = "0x400FE0C")]
    [FieldOffset(Offset = "0x8")]
    private string secretKey;
    [Token(Token = "0x400FE0D")]
    [FieldOffset(Offset = "0xC")]
    private string deviceId;

    [Token(Token = "0x600EFF6")]
    [Address(RVA = "0xAFF930", Offset = "0xAFE730", VA = "0x10AFF930")]
    public static IAccountManager Create(IAccountManager customManager) => (IAccountManager) null;

    [Token(Token = "0x600EFF7")]
    [Address(RVA = "0xAFFA20", Offset = "0xAFE820", VA = "0x10AFFA20", Slot = "4")]
    public string GetSecretKey(string name) => (string) null;

    [Token(Token = "0x600EFF8")]
    [Address(RVA = "0xAFF990", Offset = "0xAFE790", VA = "0x10AFF990", Slot = "5")]
    public string GetDeviceId(string name) => (string) null;

    [Token(Token = "0x600EFF9")]
    [Address(RVA = "0xAFFE10", Offset = "0xAFEC10", VA = "0x10AFFE10", Slot = "6")]
    public void SetKeyPair(string name, string secretKey, string deviceId)
    {
    }

    [Token(Token = "0x600EFFA")]
    [Address(RVA = "0xAFFD30", Offset = "0xAFEB30", VA = "0x10AFFD30", Slot = "7")]
    public void SetDeviceId(string name, string deviceId)
    {
    }

    [Token(Token = "0x600EFFB")]
    [Address(RVA = "0xAFFBB0", Offset = "0xAFE9B0", VA = "0x10AFFBB0", Slot = "8")]
    public void Remove(string name)
    {
    }

    [Token(Token = "0x600EFFC")]
    [Address(RVA = "0xAFFC90", Offset = "0xAFEA90", VA = "0x10AFFC90", Slot = "9")]
    public void Reset()
    {
    }

    [Token(Token = "0x600EFFD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AccountManager()
    {
    }
  }
}
