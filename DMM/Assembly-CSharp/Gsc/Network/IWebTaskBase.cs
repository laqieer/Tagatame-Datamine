// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IWebTaskBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Tasks;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003589")]
  public interface IWebTaskBase : ITask, IEnumerator
  {
    [Token(Token = "0x170021E3")]
    bool isBreak { [Token(Token = "0x600ED34")] get; }

    [Token(Token = "0x600ED35")]
    void Break();
  }
}
