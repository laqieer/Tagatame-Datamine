// Decompiled with JetBrains decompiler
// Type: Gsc.Network.EnvLoader`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003555")]
  public class EnvLoader<T> : Request<EnvLoader<T>, EnvLoader<T>.Response> where T : struct, Configuration.IEnvironment
  {
    [Token(Token = "0x400FCDA")]
    [FieldOffset(Offset = "0x0")]
    private string url;

    [Token(Token = "0x600EC67")]
    protected override Dictionary<string, object> GetParameters()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600EC68")]
    public EnvLoader(string url)
    {
    }

    [Token(Token = "0x600EC69")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600EC6A")]
    public override string GetPath() => (string) null;

    [Token(Token = "0x600EC6B")]
    public override string GetUrl() => (string) null;

    [Token(Token = "0x2003556")]
    public class Response : Gsc.Network.Response<EnvLoader<T>.Response>
    {
      [Token(Token = "0x400FCDB")]
      [FieldOffset(Offset = "0x0")]
      public readonly Dictionary<string, string> VerRoute;
      [Token(Token = "0x400FCDC")]
      [FieldOffset(Offset = "0x0")]
      public readonly Dictionary<string, Configuration.IEnvironment> Envs;

      [Token(Token = "0x600EC6C")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}
