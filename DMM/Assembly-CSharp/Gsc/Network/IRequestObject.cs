// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IRequestObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003559")]
  public interface IRequestObject : IObject
  {
    [Token(Token = "0x600EC72")]
    Dictionary<string, object> GetPayload();
  }
}
