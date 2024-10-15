// Decompiled with JetBrains decompiler
// Type: Gsc.Device.IAccountManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Device
{
  [Token(Token = "0x20035DE")]
  public interface IAccountManager
  {
    [Token(Token = "0x600F005")]
    string GetSecretKey(string name);

    [Token(Token = "0x600F006")]
    string GetDeviceId(string name);

    [Token(Token = "0x600F007")]
    void SetKeyPair(string name, string secretKey, string deviceId);

    [Token(Token = "0x600F008")]
    void SetDeviceId(string name, string deviceId);

    [Token(Token = "0x600F009")]
    void Remove(string name);

    [Token(Token = "0x600F00A")]
    void Reset();
  }
}
