// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.DMMGamesStore.Session
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Device;
using Gsc.Network;
using Gsc.Tasks;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Gsc.Auth.GAuth.DMMGamesStore
{
  [Token(Token = "0x2003679")]
  public class Session : Gsc.Auth.GAuth.GAuth.Session
  {
    [Token(Token = "0x600F3C4")]
    [Address(RVA = "0xB2EAB0", Offset = "0xB2D8B0", VA = "0x10B2EAB0")]
    private static IEnumerator UpdateAccessToken(Session session) => (IEnumerator) null;

    [Token(Token = "0x17002344")]
    public override string DeviceID
    {
      [Token(Token = "0x600F3C5"), Address(RVA = "0xB2EEB0", Offset = "0xB2DCB0", VA = "0x10B2EEB0", Slot = "13")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F3C6")]
    [Address(RVA = "0xB2ED20", Offset = "0xB2DB20", VA = "0x10B2ED20")]
    public Session(string envName, IAccountManager accountManager)
    {
    }

    [Token(Token = "0x600F3C7")]
    [Address(RVA = "0xB2DE20", Offset = "0xB2CC20", VA = "0x10B2DE20", Slot = "16")]
    public override bool CanRefreshToken(Type requestType) => new bool();

    [Token(Token = "0x600F3C8")]
    [Address(RVA = "0xB2E3A0", Offset = "0xB2D1A0", VA = "0x10B2E3A0", Slot = "17")]
    public override IRefreshTokenTask GetRefreshTokenTask() => (IRefreshTokenTask) null;

    [Token(Token = "0x600F3C9")]
    [Address(RVA = "0xB2E930", Offset = "0xB2D730", VA = "0x10B2E930", Slot = "18")]
    public override IWebTask RegisterEmailAddressAndPassword(
      string email,
      string password,
      bool disableValicationEmail,
      Action<RegisterEmailAddressAndPasswordResult> callback)
    {
      return (IWebTask) null;
    }

    [Token(Token = "0x600F3CA")]
    [Address(RVA = "0xB2E400", Offset = "0xB2D200", VA = "0x10B2E400")]
    private static RegisterEmailAddressAndPasswordResult GetRegisterEmailAddressWithPasswordResult(
      Gsc.Auth.GAuth.DMMGamesStore.API.Request.RegisterEmailAddressAndPassword.Response response,
      Gsc.Auth.GAuth.GAuth.API.Response.ErrorResponse error)
    {
      return new RegisterEmailAddressAndPasswordResult();
    }

    [Token(Token = "0x600F3CB")]
    [Address(RVA = "0xB2DA90", Offset = "0xB2C890", VA = "0x10B2DA90", Slot = "19")]
    public override IWebTask AddDeviceWithEmailAddressAndPassword(
      string email,
      string password,
      Action<AddDeviceWithEmailAddressAndPasswordResult> callback)
    {
      return (IWebTask) null;
    }

    [Token(Token = "0x600F3CC")]
    [Address(RVA = "0xB2DFA0", Offset = "0xB2CDA0", VA = "0x10B2DFA0")]
    private static AddDeviceWithEmailAddressAndPasswordResult GetAddDeviceWithEmailAddressAndPassword(
      Gsc.Auth.GAuth.GAuth.API.Response.ErrorResponse error)
    {
      return new AddDeviceWithEmailAddressAndPasswordResult();
    }

    [Token(Token = "0x200367A")]
    public new class RefreshTokenTask : IRefreshTokenTask, ITask
    {
      [Token(Token = "0x400FFA9")]
      [FieldOffset(Offset = "0x8")]
      private readonly Session session;

      [Token(Token = "0x17002345")]
      public WebTaskResult Result
      {
        [Token(Token = "0x600F3CD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "4")] get
        {
          return new WebTaskResult();
        }
        [Token(Token = "0x600F3CE"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] protected set
        {
        }
      }

      [Token(Token = "0x17002346")]
      public bool isDone
      {
        [Token(Token = "0x600F3CF"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70", Slot = "5")] get
        {
          return new bool();
        }
        [Token(Token = "0x600F3D0"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] protected set
        {
        }
      }

      [Token(Token = "0x600F3D1")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public RefreshTokenTask(Session session)
      {
      }

      [Token(Token = "0x600F3D2")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public void OnStart()
      {
      }

      [Token(Token = "0x600F3D3")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public void OnFinish()
      {
      }

      [Token(Token = "0x600F3D4")]
      [Address(RVA = "0xB2AD00", Offset = "0xB29B00", VA = "0x10B2AD00", Slot = "7")]
      public IEnumerator Run() => (IEnumerator) null;
    }
  }
}
