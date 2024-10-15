// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.Session
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Device;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x200365D")]
  public static class Session
  {
    [Token(Token = "0x1700230E")]
    public static ISession DefaultSession
    {
      [Token(Token = "0x600F316"), Address(RVA = "0xB2EE30", Offset = "0xB2DC30", VA = "0x10B2EE30")] get
      {
        return (ISession) null;
      }
      [Token(Token = "0x600F317"), Address(RVA = "0xB2EF90", Offset = "0xB2DD90", VA = "0x10B2EF90")] private set
      {
      }
    }

    [Token(Token = "0x600F318")]
    [Address(RVA = "0xB2E660", Offset = "0xB2D460", VA = "0x10B2E660")]
    public static void Init(string envName, IAccountManager accountManager)
    {
    }
  }
}
