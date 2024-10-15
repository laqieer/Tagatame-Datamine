// Decompiled with JetBrains decompiler
// Type: Gsc.Configuration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Device;
using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc
{
  [Token(Token = "0x2003534")]
  public struct Configuration
  {
    [Token(Token = "0x400FC77")]
    [FieldOffset(Offset = "0x0")]
    public readonly string AppName;
    [Token(Token = "0x400FC78")]
    [FieldOffset(Offset = "0x4")]
    public readonly string EnvName;
    [Token(Token = "0x400FC79")]
    [FieldOffset(Offset = "0x8")]
    public readonly Configuration.IEnvironment Env;
    [Token(Token = "0x400FC7A")]
    [FieldOffset(Offset = "0xC")]
    public readonly IAccountManager accountManager;
    [Token(Token = "0x400FC7B")]
    [FieldOffset(Offset = "0x10")]
    public readonly IWebQueueObserver webQueueObserver;

    [Token(Token = "0x600EB97")]
    [Address(RVA = "0xB02100", Offset = "0xB00F00", VA = "0x10B02100")]
    public Configuration(
      Configuration.IBuilder builder,
      string envName,
      Configuration.IEnvironment env)
    {
    }

    [Token(Token = "0x600EB98")]
    public T GetEnv<T>() where T : struct, Configuration.IEnvironment => (T) null;

    [Token(Token = "0x2003535")]
    public interface IEnvironment
    {
      [Token(Token = "0x17002198")]
      string ServerUrl { [Token(Token = "0x600EB99")] get; }

      [Token(Token = "0x17002199")]
      string NativeBaseUrl { [Token(Token = "0x600EB9A")] get; }

      [Token(Token = "0x1700219A")]
      string LogCollectionUrl { [Token(Token = "0x600EB9B")] get; }

      [Token(Token = "0x1700219B")]
      string LogCollectionActionLogUrl { [Token(Token = "0x600EB9C")] get; }

      [Token(Token = "0x1700219C")]
      string LogCollectionNativebaseLogUrl { [Token(Token = "0x600EB9D")] get; }

      [Token(Token = "0x1700219D")]
      string ClientErrorApi { [Token(Token = "0x600EB9E")] get; }

      [Token(Token = "0x1700219E")]
      string AuthApiPrefix { [Token(Token = "0x600EB9F")] get; }

      [Token(Token = "0x1700219F")]
      string PurchaseApiPrefix { [Token(Token = "0x600EBA0")] get; }

      [Token(Token = "0x600EBA1")]
      void SetValue(string key, string value);
    }

    [Token(Token = "0x2003536")]
    public interface IBuilder
    {
      [Token(Token = "0x170021A0")]
      string name { [Token(Token = "0x600EBA2")] get; }

      [Token(Token = "0x170021A1")]
      IAccountManager accountManager { [Token(Token = "0x600EBA3")] get; }

      [Token(Token = "0x170021A2")]
      IWebQueueObserver webQueueObserver { [Token(Token = "0x600EBA4")] get; }
    }

    [Token(Token = "0x2003537")]
    public class Builder<T> : Configuration.IBuilder where T : struct, Configuration.IEnvironment
    {
      [Token(Token = "0x400FC7C")]
      [FieldOffset(Offset = "0x0")]
      public string envUrl;
      [Token(Token = "0x400FC7D")]
      [FieldOffset(Offset = "0x0")]
      public Dictionary<string, Configuration.IEnvironment> envCollection;

      [Token(Token = "0x170021A3")]
      public string name
      {
        [Token(Token = "0x600EBA5")] get => (string) null;
        [Token(Token = "0x600EBA6")] private set
        {
        }
      }

      [Token(Token = "0x170021A4")]
      public string version
      {
        [Token(Token = "0x600EBA7")] get => (string) null;
        [Token(Token = "0x600EBA8")] private set
        {
        }
      }

      [Token(Token = "0x170021A5")]
      public IAccountManager accountManager
      {
        [Token(Token = "0x600EBA9")] get => (IAccountManager) null;
        [Token(Token = "0x600EBAA")] private set
        {
        }
      }

      [Token(Token = "0x170021A6")]
      public IWebQueueObserver webQueueObserver
      {
        [Token(Token = "0x600EBAB")] get => (IWebQueueObserver) null;
        [Token(Token = "0x600EBAC")] private set
        {
        }
      }

      [Token(Token = "0x600EBAD")]
      public Builder()
      {
      }

      [Token(Token = "0x600EBAE")]
      public Configuration.Builder<T> SetApplicationName(string name)
      {
        return (Configuration.Builder<T>) null;
      }

      [Token(Token = "0x600EBAF")]
      public Configuration.Builder<T> SetApplicationVersion(string version)
      {
        return (Configuration.Builder<T>) null;
      }

      [Token(Token = "0x600EBB0")]
      public Configuration.Builder<T> SetEnvironment(string url) => (Configuration.Builder<T>) null;

      [Token(Token = "0x600EBB1")]
      public Configuration.Builder<T> AddEnvironment(string label, T env)
      {
        return (Configuration.Builder<T>) null;
      }

      [Token(Token = "0x600EBB2")]
      public Configuration.Builder<T> SetWebQueueObserver(IWebQueueObserver observer)
      {
        return (Configuration.Builder<T>) null;
      }

      [Token(Token = "0x600EBB3")]
      public Configuration.Builder<T> SetAccountManager(IAccountManager accountManager)
      {
        return (Configuration.Builder<T>) null;
      }
    }
  }
}
