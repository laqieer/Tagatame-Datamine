// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.IDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x2003656")]
  public interface IDevice
  {
    [Token(Token = "0x17002302")]
    bool initialized { [Token(Token = "0x600F2F2")] get; }

    [Token(Token = "0x17002303")]
    bool hasError { [Token(Token = "0x600F2F3")] get; }

    [Token(Token = "0x17002304")]
    string Platform { [Token(Token = "0x600F2F4")] get; }
  }
}
