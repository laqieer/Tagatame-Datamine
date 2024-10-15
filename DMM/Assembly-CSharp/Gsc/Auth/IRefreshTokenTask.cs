// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.IRefreshTokenTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Tasks;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x2003658")]
  public interface IRefreshTokenTask : ITask
  {
    [Token(Token = "0x17002309")]
    WebTaskResult Result { [Token(Token = "0x600F2FE")] get; }
  }
}
