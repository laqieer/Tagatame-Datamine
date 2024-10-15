// Decompiled with JetBrains decompiler
// Type: Gsc.App.AccountManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Device;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.App
{
  [Token(Token = "0x2003540")]
  public class AccountManager : IAccountManager
  {
    [Token(Token = "0x400FC98")]
    [FieldOffset(Offset = "0x8")]
    private string secretKey;
    [Token(Token = "0x400FC99")]
    [FieldOffset(Offset = "0xC")]
    private string deviceId;

    [Token(Token = "0x600EBDB")]
    [Address(RVA = "0xAFFAB0", Offset = "0xAFE8B0", VA = "0x10AFFAB0")]
    private void LoadKeys()
    {
    }

    [Token(Token = "0x600EBDC")]
    [Address(RVA = "0xAFFA90", Offset = "0xAFE890", VA = "0x10AFFA90", Slot = "4")]
    public string GetSecretKey(string name) => (string) null;

    [Token(Token = "0x600EBDD")]
    [Address(RVA = "0xAFFA00", Offset = "0xAFE800", VA = "0x10AFFA00", Slot = "5")]
    public string GetDeviceId(string name) => (string) null;

    [Token(Token = "0x600EBDE")]
    [Address(RVA = "0xAFFDA0", Offset = "0xAFEBA0", VA = "0x10AFFDA0", Slot = "6")]
    public void SetKeyPair(string name, string secretKey, string deviceId)
    {
    }

    [Token(Token = "0x600EBDF")]
    [Address(RVA = "0xAFFCD0", Offset = "0xAFEAD0", VA = "0x10AFFCD0", Slot = "7")]
    public void SetDeviceId(string name, string deviceId)
    {
    }

    [Token(Token = "0x600EBE0")]
    [Address(RVA = "0xAFFC20", Offset = "0xAFEA20", VA = "0x10AFFC20", Slot = "8")]
    public void Remove(string name)
    {
    }

    [Token(Token = "0x600EBE1")]
    [Address(RVA = "0xAFFC90", Offset = "0xAFEA90", VA = "0x10AFFC90", Slot = "9")]
    public void Reset()
    {
    }

    [Token(Token = "0x600EBE2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AccountManager()
    {
    }
  }
}
