// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.Session
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Device;
using Gsc.Network;
using Gsc.Tasks;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth
{
  [Token(Token = "0x200365F")]
  public class Session : ISession
  {
    [Token(Token = "0x400FF65")]
    [FieldOffset(Offset = "0x8")]
    public readonly string EnvName;
    [Token(Token = "0x400FF67")]
    [FieldOffset(Offset = "0x10")]
    private readonly IAccountManager accountManager;
    [Token(Token = "0x400FF68")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string userAgentCache;

    [Token(Token = "0x17002313")]
    public string AccessToken
    {
      [Token(Token = "0x600F31F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "6")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F320"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] protected set
      {
      }
    }

    [Token(Token = "0x17002314")]
    public virtual string DeviceID
    {
      [Token(Token = "0x600F321"), Address(RVA = "0xB2EE60", Offset = "0xB2DC60", VA = "0x10B2EE60", Slot = "13")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002315")]
    public virtual string SecretKey
    {
      [Token(Token = "0x600F322"), Address(RVA = "0xB2EF00", Offset = "0xB2DD00", VA = "0x10B2EF00", Slot = "14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002316")]
    public virtual string UserAgent
    {
      [Token(Token = "0x600F323"), Address(RVA = "0xB2EF50", Offset = "0xB2DD50", VA = "0x10B2EF50", Slot = "15")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F324")]
    [Address(RVA = "0xB2EB00", Offset = "0xB2D900", VA = "0x10B2EB00")]
    static Session()
    {
    }

    [Token(Token = "0x600F325")]
    [Address(RVA = "0xB2EDF0", Offset = "0xB2DBF0", VA = "0x10B2EDF0")]
    public Session(string envName, IAccountManager accountManager)
    {
    }

    [Token(Token = "0x600F326")]
    [Address(RVA = "0xB2DEF0", Offset = "0xB2CCF0", VA = "0x10B2DEF0", Slot = "8")]
    public void DeleteAuthKeys()
    {
    }

    [Token(Token = "0x600F327")]
    [Address(RVA = "0xB2DDA0", Offset = "0xB2CBA0", VA = "0x10B2DDA0", Slot = "16")]
    public virtual bool CanRefreshToken(System.Type requestType) => new bool();

    [Token(Token = "0x600F328")]
    [Address(RVA = "0xB2E340", Offset = "0xB2D140", VA = "0x10B2E340", Slot = "17")]
    public virtual IRefreshTokenTask GetRefreshTokenTask() => (IRefreshTokenTask) null;

    [Token(Token = "0x600F329")]
    [Address(RVA = "0xB2E7A0", Offset = "0xB2D5A0", VA = "0x10B2E7A0", Slot = "18")]
    public virtual IWebTask RegisterEmailAddressAndPassword(
      string email,
      string password,
      bool disableValicationEmail,
      Action<RegisterEmailAddressAndPasswordResult> callback)
    {
      return (IWebTask) null;
    }

    [Token(Token = "0x600F32A")]
    [Address(RVA = "0xB2E530", Offset = "0xB2D330", VA = "0x10B2E530")]
    private static RegisterEmailAddressAndPasswordResult GetRegisterEmailAddressWithPasswordResult(
      Gsc.Auth.GAuth.GAuth.API.Response.RegisterEmailAddressAndPassword response,
      Gsc.Auth.GAuth.GAuth.API.Response.ErrorResponse error)
    {
      return new RegisterEmailAddressAndPasswordResult();
    }

    [Token(Token = "0x600F32B")]
    [Address(RVA = "0xB2DC10", Offset = "0xB2CA10", VA = "0x10B2DC10", Slot = "19")]
    public virtual IWebTask AddDeviceWithEmailAddressAndPassword(
      string email,
      string password,
      Action<AddDeviceWithEmailAddressAndPasswordResult> callback)
    {
      return (IWebTask) null;
    }

    [Token(Token = "0x600F32C")]
    [Address(RVA = "0xB2E170", Offset = "0xB2CF70", VA = "0x10B2E170")]
    private static AddDeviceWithEmailAddressAndPasswordResult GetAddDeviceWithEmailAddressAndPassword(
      Gsc.Auth.GAuth.GAuth.API.Response.ErrorResponse error)
    {
      return new AddDeviceWithEmailAddressAndPasswordResult();
    }

    [Token(Token = "0x2003660")]
    public class AccessTokenChecker : MonoBehaviour
    {
      [Token(Token = "0x400FF69")]
      private const float FAILED_POLLING_INTERVAL = 30f;
      [Token(Token = "0x400FF6A")]
      private const WebTaskAttribute TASK_ATTRIBUTES = WebTaskAttribute.Reliable | WebTaskAttribute.Silent | WebTaskAttribute.Parallel;
      [Token(Token = "0x400FF6B")]
      private const WebTaskResult ACCEPT_RESULTS = WebTaskResult.kLocalResult | WebTaskResult.kGrobalResult | WebTaskResult.kCreticalError | WebTaskResult.Maintenance | WebTaskResult.UpdateApplication;
      [Token(Token = "0x400FF6C")]
      [FieldOffset(Offset = "0xC")]
      private bool isRunning;
      [Token(Token = "0x400FF6D")]
      [FieldOffset(Offset = "0x10")]
      private int cachedInstanceId;

      [Token(Token = "0x600F32D")]
      [Address(RVA = "0xB1D2C0", Offset = "0xB1C0C0", VA = "0x10B1D2C0")]
      private void Awake()
      {
      }

      [Token(Token = "0x600F32E")]
      [Address(RVA = "0xB1D350", Offset = "0xB1C150", VA = "0x10B1D350")]
      private void OnApplicationFocus(bool focusState)
      {
      }

      [Token(Token = "0x600F32F")]
      [Address(RVA = "0xB1D2E0", Offset = "0xB1C0E0", VA = "0x10B1D2E0")]
      private IEnumerator CheckToken() => (IEnumerator) null;

      [Token(Token = "0x600F330")]
      [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
      public AccessTokenChecker()
      {
      }
    }

    [Token(Token = "0x2003662")]
    public class RefreshTokenTask : IRefreshTokenTask, ITask
    {
      [Token(Token = "0x400FF72")]
      [FieldOffset(Offset = "0x8")]
      private readonly Session session;

      [Token(Token = "0x17002319")]
      public WebTaskResult Result
      {
        [Token(Token = "0x600F337"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "4")] get
        {
          return new WebTaskResult();
        }
        [Token(Token = "0x600F338"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] protected set
        {
        }
      }

      [Token(Token = "0x1700231A")]
      public bool isDone
      {
        [Token(Token = "0x600F339"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70", Slot = "5")] get
        {
          return new bool();
        }
        [Token(Token = "0x600F33A"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] protected set
        {
        }
      }

      [Token(Token = "0x600F33B")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public RefreshTokenTask(Session session)
      {
      }

      [Token(Token = "0x600F33C")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public void OnStart()
      {
      }

      [Token(Token = "0x600F33D")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public void OnFinish()
      {
      }

      [Token(Token = "0x600F33E")]
      [Address(RVA = "0xB2AC90", Offset = "0xB29A90", VA = "0x10B2AC90", Slot = "7")]
      public IEnumerator Run() => (IEnumerator) null;
    }
  }
}
