// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Response`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003564")]
  public abstract class Response<T> : IResponse<T>, IResponse where T : IResponse<T>
  {
    [Token(Token = "0x600ECB2")]
    protected virtual Dictionary<string, object> GetResult(byte[] payload)
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600ECB3")]
    protected virtual IValue GetResponseRoot(IDocument document) => (IValue) null;

    [Token(Token = "0x600ECB4")]
    protected Response()
    {
    }
  }
}
